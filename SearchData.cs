using Safiye.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using Safiye.Boss;
using Safiye.Color;
using Safiye.Controls;
using Safiye.Data;

namespace Safiye
{
    
    public partial class Form1 : Form
    {
        int _apcDetail=0;
        private OracleRepository _repositorDev;
        private OracleRepository _repositoryInt;
        private OracleRepository _repositorUat;
        private OracleRepository _repositorProd;

        #region Variables

        string _dscr = "";
        public static string rrn = "";

        public OracleConnection Conn { get; set; }


        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Startup();
        }

        private void Startup()
        {
            ConfigBoss.Instance.Initiliaze();
            SetStartupRepositories();
            SetStartupFormValues();
            SetColors(ColorBoss.GetColorBase(cmbThem.SelectedItem.ToString()));
        }

        private void SetStartupFormValues()
        {
            numericUpDown1.Text = DateTime.Today.DayOfYear.ToString();
            numericUpDown1.Focus();
            rdUat.Checked = true;
            toolTip1.SetToolTip(btnTextSearch, "Text Search");
            toolTip1.SetToolTip(BtnFind, "RRN Search");
            toolTip1.SetToolTip(BtnCopyDate, "Tarih YYYYMMDD formatında kopyalanır");
            toolTip1.SetToolTip(BtnCopyDate, "DB Log");
            txtRrn.Focus();
            cmbThem.SelectedIndex = cmbThem.FindString(ConfigBoss.Instance.IniFile.IniReadValue("Personal", "Tema"));
        }

        private void SetStartupRepositories()
        {
            _repositorDev = new OracleRepository(ConfigBoss.Instance.GetConnString(ConnType.Dev));
            _repositoryInt = new OracleRepository(ConfigBoss.Instance.GetConnString(ConnType.Int));
            _repositorUat = new OracleRepository(ConfigBoss.Instance.GetConnString(ConnType.Uat));
            _repositorProd = new OracleRepository(ConfigBoss.Instance.GetConnString(ConnType.Prod));
        }

        private void SetColors(ColorBase color)
        {
            ColorBoss.SetBaseColor(color);
            ColorBoss.SetColors(this);
            ColorBoss.SetPrimaryColor(new MyControl(this));
            ColorBoss.SetPrimaryColor(new MyControl(mainGroupBox));
            ColorBoss.SetPrimaryColor(new MyControl(apcGroupBox));
            ColorBoss.SetPrimaryDarkColor(new MyGridControl(grid1));
            ColorBoss.SetPrimaryLightColor(new MyGridControl(grid2));
            ColorBoss.SetPrimaryMoreLightColor(new MyGridControl(grid3));
        }

        private OracleRepository GetRepository()
        {
            if (rdProd.Checked)
            {
                return _repositorProd;
            }
            if (rdUat.Checked)
            {
                return _repositorUat;
            }
            if (rdInt.Checked)
            {
                return _repositoryInt;
            }
            if (rdDev.Checked)
            {
                return _repositorDev;
            }
            return null;
        }
        

        
        public DateTime ConvertFromJulian(int mJulianDate)
        {
            DateTime theDate;
            if (txtRrn.Text != "" && txtRrn.Text.Substring(0, 1) == "4")
            {
                theDate = new DateTime(DateTime.Today.Year - 1, 1, 1).AddDays(mJulianDate - 1);
            }
            else
            {
                theDate = new DateTime(DateTime.Today.Year, 1, 1).AddDays(mJulianDate - 1);
            }
            return theDate;
        }
        
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            numericUpDown1.Text = dateTimePicker1.Value.DayOfYear.ToString();
        }
        
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePicker1.Value = ConvertFromJulian(Convert.ToInt32(numericUpDown1.Value));
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Conn = new OracleConnection(GetConnString());
                Conn.Open();
                var cmd = new OracleCommand()
                {
                    Connection = Conn,
                    CommandText = "select DSCR from CARD.INT_RET_CODES_INFO where ret_code = '" + txtErrorCode.Text + "'",
                    CommandType = CommandType.Text
                };
                var dr = cmd.ExecuteReader();
                dr.Read();
                Conn.Dispose();
                MessageBox.Show(_dscr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Dispose();
            }
        }
        
        private void BtnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int slct = 0;
                var repository = GetRepository();
                var prm = new OracleParameter[10];
                String sqlWhere = "";
                if (!String.IsNullOrEmpty(txtRrn.Text.Trim()))
                {
                    prm[0] = new OracleParameter(":PI_RRN", txtRrn.Text.Trim());
                    sqlWhere = sqlWhere + "AND SUB.RRN= :PI_RRN  ";
                    slct++;
                }
                if (!String.IsNullOrEmpty(txtTerminal.Text.Trim()))
                {
                    prm[1] = new OracleParameter(":PI_TERM_ID", txtTerminal.Text.Trim());
                    sqlWhere = sqlWhere + "AND SUB.TERM_ID= :PI_TERM_ID  ";
                    slct++;
                }
                if (!String.IsNullOrEmpty(txtMerchant.Text.Trim()))
                {
                    prm[2] = new OracleParameter(":PI_MRC_NO", txtMerchant.Text.Trim());
                    sqlWhere = sqlWhere + "AND SUB.MRC_NO= :PI_MRC_NO  ";
                    slct++;
                }
                if (!String.IsNullOrEmpty(txtCardNo.Text.Trim().Replace(" ", "")))
                {
                    prm[3] = new OracleParameter(":PI_CARDNO", txtCardNo.Text.Trim().Replace(" ", ""));
                    sqlWhere = sqlWhere + "AND SUB.CARDNO= :PI_CARDNO  ";
                    slct++;
                }
                string pdate = "";
                if (!String.IsNullOrEmpty(txtRrn.Text.Trim()))
                {
                    pdate = ConvertFromJulian(int.Parse(txtRrn.Text.Substring(1, 3))).ToString("yyyyMMdd");
                    slct++;
                }
                else
                {
                    pdate = dateTimePicker1.Value.ToString("yyyyMMdd");
                    slct++;
                }

                var objParam = new OracleParameter
                {
                    OracleType = OracleType.Int32,
                    Direction = ParameterDirection.Input,
                    ParameterName = ":PI_DATE",
                    Value = pdate
                };
                prm[4] = objParam;

                if (slct < 2)
                {
                    MessageBox.Show(Resources.Form1_button3_Click_Lütfen_en_az_iki_kriter_giriniz);
                    return;
                }
                var sSql = (chkMngmnt.Checked ? Query.SqlSelectMgmnt: Query.SqlSelectProcess ) + sqlWhere + "  ORDER BY SUB.PROCESS_DATE DESC, SUB.SYS_ENTRY_DATE DESC, SUB .SYS_ENTRY_TIME ";
                var ds = repository.FillTable(sSql, prm);
                if (ds.Rows.Count == 0)
                {
                    MessageBox.Show(Resources.Form1_button3_Click_İşlem_bulunamadı);
                    return;
                }
                grid1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void SortColumn(DataTable table)
        {

            var columnArray = new DataColumn[table.Columns.Count];
            table.Columns.CopyTo(columnArray, 0);
            var ordinal = -1;
            var columnArray2 = columnArray.OrderBy(c => c.ColumnName);
            foreach (var orderedColumn in columnArray.OrderBy(c => c.ColumnName))
            {
                ordinal++;
                table.Columns[orderedColumn.ColumnName].SetOrdinal(ordinal);
            }
        }
        
        public void RunQuery(string commandText,OracleParameter[] oracleParameter,Boolean openForm, MyForm form)
        {
            try
            {
                if (form == null )
                {
                    form = new Form2();
                }
                
                OpenForm(commandText, oracleParameter, openForm, form);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
        
        private void OpenForm(string commandText, OracleParameter[] oracleParameter, bool openForm, MyForm form)
        {
            var repository = GetRepository();            
            var ds = repository.FillTable(commandText, oracleParameter);
            if (openForm)
            {
                ColorBoss.SetColors(form);
                form.SetDataTable(ds);
                form.ShowDialog();
            }
        }

        private Boolean ValidateField(TextBox textboxt,Label lbl)
        {
            if (String.IsNullOrEmpty(textboxt.Text))
            {
                MessageBox.Show(lbl.Text + Resources.Form1_ValidateField__giriniz);
                textboxt.Focus();
                return false;
            }
            return true;
        }
        
        private void BtnMerchant_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateField(txtMerchant, lblMerchant))
                {
                    var prm = new OracleParameter[1];
                    prm[0] = new OracleParameter(":PI_MRC_NO", txtMerchant.Text);
                    RunQuery(Query.SqlMerchant, prm, true,null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private string GetConnString()
        {
            string oradb = "";
            if (rdProd.Checked)
            {
                oradb = String.Format("Data Source=SAFIR_114;User Id={0};Password={1};", ConfigBoss.Instance.DbUser, ConfigBoss.Instance.DbPass);
            }
            if (rdUat.Checked)
            {
                oradb = "Data Source=SRV_SAFIR_OLUAT;User Id=SFRRW;Password=sfrWuat1;";
            }
            if (rdInt.Checked)
            {
                oradb = "Data Source=SRV_SAFIR_OLINT ;User Id=SFRADM;Password=sfrAint3;";
            }
            if (rdDev.Checked)
            {
                oradb = "Data Source=SRV_SAFIR_OLDEV ;User Id=SFRADM;Password=sfrAdev3;";
            }
            return oradb;
        }
        
        private void btnTextSearch_Click(object sender, EventArgs e)
        {
            SearchText srch = new SearchText();
            if (rdProd.Checked)
            {
                if (!String.IsNullOrEmpty(txtSourceFui.Text))
                {
                    string setNumber = txtSourceFui.Text.Substring(txtSourceFui.Text.Length - 1, 1);
                    srch.SServer = "SET" + setNumber;
                }
                else
                {
                    srch.SServer = "SET1";
                }
            }
            if (rdUat.Checked)
            {
                srch.SServer = "UAT";
            }
            if (rdInt.Checked)
            {
                srch.SServer = "INT";
            }
            if (rdDev.Checked)
            {
                srch.SServer = "DEV";
            }
            srch.SRrn = txtRrn.Text;
            srch.SDate = txtSysDate.Text.Length>0 ? new DateTime( int.Parse(txtSysDate.Text.Substring(0,4)), int.Parse( txtSysDate.Text.Substring(4,2)), int.Parse( txtSysDate.Text.Substring(6,2))) : dateTimePicker1.Value;
            srch.STime = txtSysTime.Text;
            srch.Show();
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtTerminal.Text))
                {
                    MessageBox.Show(Resources.Form1_btnTerminal_Click_Terminal_giriniz);
                    return;
                }
                else
                {
                    var prm = new OracleParameter[1];
                    prm[0] = new OracleParameter(":PI_TERM_ID", txtTerminal.Text);
                    RunQuery(Query.SqlTerminal, prm, true, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
        }

        private void btnPcode_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateField(txtPcode, lblPcode))
                {
                    var prm = new OracleParameter[1];
                    prm[0] = new OracleParameter(":PI_PCODE", txtPcode.Text);
                    RunQuery(Query.SqlPcode, prm, true, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCardNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateField(txtCardNo, lblCardNo))
                {
                    var prm = new OracleParameter[1];
                    prm[0] = new OracleParameter(":PI_CARD_NO",txtCardNo.Text.Trim().Replace(" ", ""));
                    RunQuery(rdProd.Checked ? Query.SqlCardProd : Query.SqlCard, prm, true, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void txtRrn_TextChanged(object sender, EventArgs e)
        {
            txtRrn.Text = txtRrn.Text.Trim().Replace(" ", ""); 
        }
        
        private void txtRrn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        
        private void btnSeqNo_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtMerchant.Text))
                {
                    MessageBox.Show(Resources.Form1_btnSeqNo_Click_İşyeri_No_giriniz);
                    return;
                }
                var prm = new OracleParameter[1];
                prm[0] = new OracleParameter(":PI_MRC_NO", txtMerchant.Text);
                RunQuery(Query.SqlBank, prm, true, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }
        }
        
        private void btnClear_Click_3(object sender, EventArgs e)
        {
            ClearForm();
        }
        
        private void ClearForm()
        {
            foreach (Control item in this.mainGroupBox.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            numericUpDown1.Text = DateTime.Today.DayOfYear.ToString();
            grid1.DataSource = null;
            grid2.DataSource = null;
            grid3.DataSource = null;            
        }
        
        private void SetField()
        {
            txtRrn.Text = grid1.SelectedRows[0].Cells["RRN"].Value.ToString();
            txtMerchant.Text = grid1.SelectedRows[0].Cells["MRC_NO"].Value.ToString();
            txtTerminal.Text = grid1.SelectedRows[0].Cells["TERM_ID"].Value.ToString();
            txtErrorCode.Text = grid1.SelectedRows[0].Cells["INT_RES_CODE"].Value.ToString();
            try
            {
                numericUpDown1.Value = decimal.Parse(grid1.SelectedRows[0].Cells["RRN"].Value.ToString().Substring(1, 3));
            }
            catch
            {
                // ignored
            }
            txtPcode.Text = grid1.SelectedRows[0].Cells["F3"].Value.ToString();
            txtMTI.Text = grid1.SelectedRows[0].Cells["MSG_TYPE"].Value.ToString();
            txtTrnxCode.Text = grid1.SelectedRows[0].Cells["TRNX_CODE"].Value.ToString();
            txtTrnxSubCode.Text = grid1.SelectedRows[0].Cells["TRNX_SUB_CODE"].Value.ToString();
            txtTime.Text = grid1.SelectedRows[0].Cells["SYS_ENTRY_TIME"].Value.ToString();
            if (!chkMngmnt.Checked)
            {
                txtCardNo.Text = grid1.SelectedRows[0].Cells["CARDNO"].Value.ToString();
                txtDestFui.Text = grid1.SelectedRows[0].Cells["DEST_FUI"].Value.ToString();
                txtDest.Text = grid1.SelectedRows[0].Cells["DEST"].Value.ToString();
                txtBankCode.Text = grid1.SelectedRows[0].Cells["ISS_BANK_CODE"].Value.ToString();
                txtTrnxType.Text = grid1.SelectedRows[0].Cells["TRNX_TYPE"].Value.ToString();
                txtSysDate.Text = grid1.SelectedRows[0].Cells["SYS_ENTRY_DATE"].Value.ToString();
                txtSysTime.Text = grid1.SelectedRows[0].Cells["SYS_ENTRY_TIME"].Value.ToString();
            }
            txtSeqNo.Text = grid1.SelectedRows[0].Cells["SEQUENCE_NO"].Value.ToString();
            txtProcesResult.Text = grid1.SelectedRows[0].Cells["KART_CEVAP"].Value.ToString();
            txtSourceFui.Text = grid1.SelectedRows[0].Cells["SOURCE_FUI"].Value.ToString();
            txtPosGuid.Text = grid1.SelectedRows[0].Cells["POS_GUID"].Value.ToString();
            FillPosTrnxInfo(grid1.SelectedRows[0].Cells["SRC_TBL"].Value.ToString());
            FillPosTrnxDetailInfo();
        }
        
        private void FillPosTrnxDetailInfo()
        {
            try
            {
                var repository = GetRepository();
                var prm = new OracleParameter[3];
                prm[0] = new OracleParameter(":F37", txtRrn.Text);
                prm[1] = new OracleParameter(":PROCESS_DATE", dateTimePicker1.Value.ToString("yyyyMMdd"));
                prm[2] = new OracleParameter(":TRNX_TYPE", txtTrnxType.Text);
                grid3.DataSource = repository.FillTable(Query.SqlPosTrnxDetail,prm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void FillPosTrnxInfo(string info)
        {
            try
            {
                var repository = GetRepository();
                var prm = new OracleParameter[3];
                prm[0]=new OracleParameter(":F37", txtRrn.Text);
                prm[1] = new OracleParameter(":PROCESS_DATE", dateTimePicker1.Value.ToString("yyyyMMdd"));
                if (info != "MGMNNT")
                {
                    prm[2] =new OracleParameter(":TRNX_TYPE", txtTrnxType.Text);
                }
                string sql="";
                switch (info)
                {
                    case "INFO":
                        sql = Query.SqlPosTrnxInfo;
                        break;
                    case "DECL":
                        sql = Query.SqlPosTrnxDeclinedInfo;
                        break;
                    case "HOLD":
                        sql = Query.SqlPosTrnxHoldInfo;
                        break;
                    case "MGMNNT":
                        sql = Query.SqlPosTrnxMngmntInfo;
                        break;
                }
                grid2.DataSource = repository.FillTable(sql,prm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnBank_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBankCode.Text))
                {
                    MessageBox.Show(Resources.Form1_btnBank_Click_Banka_No_giriniz);
                    return;
                }
                var prm = new OracleParameter[1];
                prm[0] = new OracleParameter(":PI_BANK_NO", txtBankCode.Text);
                RunQuery(Query.SqlBank, prm, true, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void BtnCopyDate_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(dateTimePicker1.Value.ToString("yyyyMMdd"));
        }

        private void btnDbLog_Click(object sender, EventArgs e)
        {
            try
            {
                string pdate = "";
                var prm = new OracleParameter[2];

                if (!String.IsNullOrEmpty(txtRrn.Text.Trim()))
                {
                    pdate = ConvertFromJulian(int.Parse(txtRrn.Text.Substring(1, 3))).ToString("yyyyMMdd");
                    prm[0] = new OracleParameter(":PI_DATE", pdate);
                    prm[1] = new OracleParameter(":PI_RRN", txtRrn.Text);
                    RunQuery(Query.SqlLog + " AND f37 = :PI_RRN ", prm, true, null);
                }
                else
                {
                    pdate = dateTimePicker1.Value.ToString("yyyyMMdd");
                    prm[0] = new OracleParameter(":PI_DATE", pdate);
                    prm[1] = new OracleParameter(":PI_POS_GUID", txtPosGuid.Text);
                    RunQuery(Query.SqlLog + " AND POS_GUID = :PI_POS_GUID", prm, true, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApc_Click(object sender, EventArgs e)
        {
            try
            {
                string pdate = "";
                var prm = new OracleParameter[1];
                pdate = dateTimePicker1.Value.ToString("yyyyMMdd");
                var sql = Query.SqlSelectApc;
                if (!String.IsNullOrEmpty(txtCardNo.Text))
                {
                    prm = new OracleParameter[2];
                    sql += " AND CARD_NO = :PI_CARD_NO";
                    prm[1] = new OracleParameter(":PI_CARD_NO", txtCardNo.Text.Trim().Replace(" ", ""));
                }

                sql += String.Format(" AND ONLINE_BATCH_IND ='{0}' ", rdBatch.Checked ?"B": "O");
                prm[0] = new OracleParameter(":PI_DATE", pdate);
                RunQuery(sql, prm, true, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnApcReport_Click(object sender, EventArgs e)
        {
            try
            {
                _apcDetail++;
                string pdate = "";
                pdate = dateTimePicker1.Value.ToString("yyyyMMdd");
                var form = new Report();
                var prm = new OracleParameter[1];
                prm[0] = new OracleParameter(":PI_DATE", pdate);
                if (_apcDetail % 2 == 0)
                {
                    RunQuery(rdBatch.Checked ? Query.SqlApcReportBillDetailBatch : Query.SqlApcReportBillOnlineDetail, prm, true, form);

                }
                else
                {
                    RunQuery(rdBatch.Checked ? Query.SqlApcReportBillBatch : Query.SqlApcReportBillOnline, prm, true, form);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdBatch_CheckedChanged(object sender, EventArgs e)
        {
            _apcDetail = 0;
        }

        private void rdOnline_CheckedChanged(object sender, EventArgs e)
        {
            _apcDetail = 0;
        }

        private void btnSurum_Click(object sender, EventArgs e)
        {
            Surum formSurum=new Surum();
            formSurum.Show();
        }

        private void grid1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grid1.SelectedRows.Count == 0)
            {
                MessageBox.Show(Resources.Form1_Satır_seçiniz);
                return;
            }
            SetField();
        }

        private void ShowDetail(object sender, DataGridViewCellMouseEventArgs e)
        {
            var grid = (DataGridView)sender;
            var rowIndex = e.RowIndex;
            RecordDetail.ShowGridDetail(grid, rowIndex);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cmbThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColors(ColorBoss.GetColorBase(cmbThem.SelectedItem.ToString()));
            ConfigBoss.Instance.IniFile.IniWriteValue("Personal", "Tema", cmbThem.SelectedItem.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PathBoss.ExtractPath());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _repositorDev.Close();
            _repositoryInt.Close();
            _repositorUat.Close();
            _repositorProd.Close();
        }
    }

    
}


