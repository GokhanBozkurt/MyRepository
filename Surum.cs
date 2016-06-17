using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safiye.Boss;
using Safiye.Data;

namespace Safiye
{
    public partial class Surum : Form
    {
        public Surum()
        {
            InitializeComponent();
        }


        private OracleRepository _repository ;
        private readonly string _connStr = String.Format("Data Source=SAFIR_114;User Id={0};Password={1};", ConfigBoss.Instance.DbUser, ConfigBoss.Instance.DbPass);
        private void button1_Click(object sender, EventArgs e)
        {
            var prm = GetDbParameters();
            var commandText = GetCommandText();
            var ds= _repository.FillTable(commandText, prm);
            gridSurum.DataSource = ds;
        }

        private OracleParameter[] GetDbParameters()
        {
            string pdate = "";
            var prm = new OracleParameter[2];
            if (textBox1.Text != "")
            {
                prm = new OracleParameter[3];
                prm[2] = new OracleParameter(":PI_SET_NO", textBox1.Text);
            }
            pdate = dateTimePicker1.Value.ToString("yyyyMMdd");
            prm[0] = new OracleParameter(":PI_DATE", pdate);
            prm[1] = new OracleParameter(":PI_SYS_ENTRY_TIME", dateTimePicker2.Text.Replace(":",""));
            
            return prm;
        }

        private string GetCommandText()
        {
            var commandText = Query.SqlSurum1;

            if (radioButton1.Checked)
            {
                commandText = Query.SqlSurum1;
            }
            else if (radioButton2.Checked)
            {
                commandText = Query.SqlSurum2;
            }
            else if (radioButton3.Checked)
            {
                commandText = Query.SqlSurum3;
            }
            else if (radioButton4.Checked)
            {
                commandText = Query.SqlSurum4;
            }
            if (textBox1.Text != "")
            {
                commandText += "  AND SET_NO = :PI_SET_NO ";
            }
            commandText += "  ORDER BY CNT DESC ";
            return commandText;
        }

        private void Surum_Load(object sender, EventArgs e)
        {
            _repository = new OracleRepository(ConfigBoss.Instance.GetConnString(ConnType.Prod));
        }
    }
}
