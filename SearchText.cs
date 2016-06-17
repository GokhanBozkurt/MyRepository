using System;
using System.Collections;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Safiye.Boss;
using Safiye.Color;
using Safiye.Controls;
using Safiye.Properties;

namespace Safiye
{
    public partial class SearchText : Form
    {
        public string SRrn;
        public string SServer;
        public DateTime SDate;
        public string STime;
        private Task _task;
        private CancellationTokenSource _cancellationToken = new CancellationTokenSource();
        private bool _taskRunning;


        enum ServiceAction
        {
            ReStart,
            Stop
        };
        public SearchText()
        {
            InitializeComponent();
        }

        private void SearchText_Load(object sender, EventArgs e)
        {
            Startup();
        }
        private void Startup()
        {

            cmbSearchPattern.SelectedIndex = 0;
            if (!String.IsNullOrEmpty(SRrn))
            {
                txtText.Text = SRrn;
            }
            if (!String.IsNullOrEmpty(SServer))
            {
                cmbFolder.SelectedIndex = cmbFolder.Items.IndexOf(SServer);
            }
            dateTimePicker1.Value = SDate;
            if (!String.IsNullOrEmpty(STime))
            {
                SetTime();
            }
            ColorBoss.SetColors(this);
            ControlBoss.SetOwnerControl(this);
        }
        private void SetTime ()
        {

            switch (STime.Length)
            {
                case 1 :
                    txtStartTime.Text = "00:00:0" + STime.Substring(0, 1);
                    txtEndTime.Text = "00:00:0" + STime.Substring(0, 1);
                    break;
                case 2:
                    txtStartTime.Text = "00:00:" + STime.Substring(0, 2);
                    txtEndTime.Text = "00:00:" + STime.Substring(0, 2);
                    break;
                case 3:
                    txtStartTime.Text =  "00:0" + STime.Substring(0, 1) + ":" + STime.Substring(1, 2);
                    txtEndTime.Text = "00:0" + STime.Substring(0, 1) + ":" + STime.Substring(1, 2);
                    break;
                case 4:
                    txtStartTime.Text = "00:" + STime.Substring(0, 2) + ":" + STime.Substring(2, 2);
                    txtEndTime.Text = "00:" + STime.Substring(0, 2) + ":" + STime.Substring(2, 2);
                    break;
                case 5:
                    txtStartTime.Text = "0"  + STime.Substring(0, 1) + ":" + STime.Substring(1, 2) + ":" + STime.Substring(3, 2);
                    txtEndTime.Text = "0" + STime.Substring(0, 1) + ":" + STime.Substring(1, 2) + ":" + STime.Substring(3, 2);
                    break;
                case 6:
                    txtStartTime.Text = STime.Substring(0, 2) + ":" + STime.Substring(2, 2) + ":" + STime.Substring(4, 2);
                    txtEndTime.Text = STime.Substring(0, 2) + ":" + STime.Substring(2, 2) + ":" + STime.Substring(4, 2);
                    break;
                default:
                    break;
            }
            
        }
        private DateTime GetSearchStartDateTime()
        {
            DateTime dt;
            int year, month, day, hour, minute, seconds;

            dt = chkDate.Checked ? dateTimePicker1.Value : DateTime.Today;

            year = dt.Year;
            month = dt.Month;
            day = dt.Day;

            hour = int.Parse(txtStartTime.Text.Substring(0, 2));
            minute = int.Parse(txtStartTime.Text.Substring(3, 2));
            seconds = int.Parse(txtStartTime.Text.Substring(6, 2));

            dt = new DateTime(year, month, day, hour, minute, seconds);
            return dt;
        }
        private DateTime GetSearchEndDateTime()
        {
            DateTime dt;
            int year, month, day, hour, minute, seconds;

            dt = ControlBoss.GetCheckBoxChecked(chkDate) ?ControlBoss.GetDateTimePickerValue(dateTimePicker1): DateTime.Today;

            year = dt.Year;
            month = dt.Month;
            day = dt.Day;

            hour = int.Parse(txtEndTime.Text.Substring(0, 2));
            minute = int.Parse(txtEndTime.Text.Substring(3, 2));
            seconds = int.Parse(txtEndTime.Text.Substring(6, 2));

            dt = new DateTime(year, month, day, hour, minute, seconds);
            return dt;

        }

        private Boolean CheckUat()
        {
            if ( ControlBoss.GetControlText(cmbFolder)== Resources.SearchText_UAT)
            {
                var pdate=ControlBoss.GetDateTimePickerValue(dateTimePicker1);
                var diff = String.Equals(DateTime.Now.ToShortDateString(), pdate.ToShortDateString());
                if (!diff)
                {
                    string formatted = pdate.ToString("dd.MM.yyyy");
                    string file = GetServers(ControlBoss.GetControlText(cmbFolder)) + "\\"+ formatted + ".zip";
                    if (!File.Exists(file))
                    {
                        return false;
                    }
                    FileInfo ff = new FileInfo(file);
                    SetStatusText("Decompressing file : " + ff.Name);
                    PathBoss.DecompressFolder(ff);
                    return true;
                }
            }
            return false;

        }

        
        private bool GetFilesFromFolder(bool searchtext, Button sender, CancellationTokenSource token)
        {
            _taskRunning = true;
            IOrderedEnumerable<string> sFiles;
            string[] files = { "" };
            int fnd = 0;
            int fnd2 = 0;

            Cost.Start();
            ControlBoss.SetControlText(lblFileCount, "Searching.");
            ControlBoss.SetControlText(lblFoundFile, "");
            ControlBoss.EnabledControls(false);
            ControlBoss.EnabledControl(sender, true);
            ControlBoss.VisibledControl(pictureBox1, true);
            if (!ValidateForm(searchtext))
            {
                ControlBoss.EnabledControls(true);
                return false;
            }
            PathBoss.DeleteFile();
            var selectedIndex = ControlBoss.ListBoxSelectedIndex(lstResult);
            if (selectedIndex != -1)
            {
                files[0] = ControlBoss.ListBoxGetSelectedIndex(lstResult,selectedIndex);
                sFiles = files.OrderBy(a => a);
            }
            else
            {
                var sPath = GetServers(ControlBoss.GetControlText(cmbFolder));
                if (CheckUat())
                {
                    sPath = PathBoss.ExtractPath();
                }
                sFiles = Directory.GetFiles(sPath, ControlBoss.GetControlText(cmbSearchPattern), chkSubFolders.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).OrderByDescending(f => new FileInfo(f).Name);
            }

            ControlBoss.ListBoxItemsClear(lstResult);
            foreach (String sFile in sFiles)
            {
                if (token.IsCancellationRequested)
                {
                    ControlBoss.EnabledControls(true);
                    ControlBoss.VisibledControl(pictureBox1, false);
                    _taskRunning = false;
                    return true;
                }
                SetStatusText(String.Format("Searching {0}", sFile));
                SearchInFile(searchtext, ref fnd, ref fnd2, sFile);
            }
            ControlBoss.SetControlText(lblFileCount,String.Format("{0} file readed . Cost [{1}] ", fnd2, Cost.CostBySeconds));
            ControlBoss.SetControlText(lblFoundFile, String.Format("{0} file found", fnd));
            ControlBoss.EnabledControls(true);
            ControlBoss.VisibledControl(pictureBox1, false);
            _taskRunning = false;
            return true;
        }


        private void SetStatusText(string text)
        {
            ControlBoss.SetControlText(lblFileCount, text);
        }

        private Boolean GetFilesFromAllSet(bool searchtext, Button sender, CancellationTokenSource token)
        {
            Cost.Start();
            int fnd = 0;
            int fnd2 = 0;
            int fnd3 = 0;
            int fnd4 = 0;
            var allSet = new ArrayList(4) { "SET1", "SET2", "SET3" ,"SET4"};
             
            ControlBoss.SetControlText(lblFileCount, "Searching.");
            ControlBoss.SetControlText(lblFoundFile, "");
            ControlBoss.EnabledControls(false);
            ControlBoss.EnabledControl(sender, true);

            if (!ValidateForm(searchtext))
            {
                ControlBoss.EnabledControls(true);
                return false;
            }
            PathBoss.DeleteFile();
            ControlBoss.ListBoxItemsClear(lstResult);

            foreach (string item in allSet)
            {
                if (token.IsCancellationRequested)
                {
                    ControlBoss.EnabledControls(true);
                    ControlBoss.VisibledControl(pictureBox1, false);
                    _taskRunning = false;
                    return true;
                }
                string sPath = GetServers(item);
                var files = Directory.GetFiles(sPath, ControlBoss.GetControlText(cmbSearchPattern), ControlBoss.GetCheckBoxChecked(chkSubFolders) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                foreach (String sFile in files)
                {
                    ControlBoss.SetControlText(lblFileCount, String.Format("Searching {0}", sFile));
                    SearchInFile(searchtext, ref fnd, ref fnd2, sFile);
                } 
                fnd3=fnd3+fnd;
                fnd4=fnd4+fnd2;
            }

            ControlBoss.SetControlText(lblFileCount, String.Format("{0} file readed . Cost [{1}] ", fnd3, Cost.CostBySeconds));
            ControlBoss.SetControlText(lblFoundFile, String.Format("{0} file found", fnd4));
            ControlBoss.EnabledControls(true);

            return true;
        }

        private void SearchInFile(bool searchtext, ref int fnd, ref int fnd2, String sFile)
        {
            String sfilename = sFile.Replace("Dosya :", "");
            var sLastWriteTime = File.GetLastWriteTime(sfilename);
            bool diff = true;
            bool diffstarttime = true;
            bool diffendttime = true;
            FileInfo file = new FileInfo(sfilename);

            if (ControlBoss.GetCheckBoxChecked(chkDate))
            {
                diff = String.Equals(sLastWriteTime.ToShortDateString(), dateTimePicker1.Value.ToShortDateString());
            }

            if (ControlBoss.GetCheckBoxChecked(chkStartTime))
            {
                var tt = GetSearchStartDateTime().Subtract(sLastWriteTime);

                diffstarttime = !(tt.TotalSeconds > 0);
            }

            if (ControlBoss.GetCheckBoxChecked(chkEndTime) )
            {
                var tt = sLastWriteTime.Subtract(GetSearchEndDateTime());

                diffendttime = !(tt.TotalSeconds > 0);
            }
            if (file.Extension.ToUpper() == ".ZİP")
            {
                diff = true;
                diffendttime = true;
                diffstarttime = true;
            }

            if (diff && diffstarttime & diffendttime)
            {
                fnd2++;

                sfilename = PathBoss.CheckFile(file, searchtext);
                file = new FileInfo(sfilename);
                if (searchtext)
                {
                    if (SearchTextFile(sfilename, file))
                        fnd++;
                }
                else
                {
                    ControlBoss.ListBoxAddItem(lstResult, "Dosya :" + file.FullName);
                }

            }
        }



        private bool SearchTextFile(string fileName, FileInfo file)
        {
            var returnValue = LogBoss.SearchTextFile(txtText.Text, file.FullName);
            try
            {
                if (returnValue.Success)
                {
                    ControlBoss.ListBoxAddItem(lstResult, "Dosya :" + file.Name);
                    foreach (var item in returnValue.Value)
                    {
                        ControlBoss.ListBoxAddItem(lstResult, item.ToString());
                    }
                }
                else
                {
                    File.Delete(fileName);
                }
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GC.Collect();

            Thread.Sleep(100);    
            return returnValue.Success;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!_taskRunning)
            {
                _taskRunning = false;
                _cancellationToken=new CancellationTokenSource();
                if (chkAllSet.Checked)
                {
                    _task = new Task(() => GetFilesFromAllSet(true, btnSearch, _cancellationToken));
                    _task.Start();
                }
                else
                {
                    _task = new Task(() => GetFilesFromFolder(true, btnSearch, _cancellationToken));
                    _task.Start();
                }
            }
            else 
            {
                _cancellationToken.Cancel();
                ControlBoss.EnabledControls(true);
            }
        }
  
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string curItem = lstResult.SelectedItem.ToString();
            if (curItem.Contains("Dosya"))
            {
                if (!String.IsNullOrEmpty(txtText.Text))
                {
                    Clipboard.SetText(txtText.Text.Replace(" ", ""));
                }

                string file = curItem.Replace("Dosya :", "");
                string filepath = "";
                if (File.Exists(file))
                {
                    filepath = file;    
                }
                else
                {
                    filepath = System.IO.Path.GetFullPath(PathBoss.ExtractPath() + file);
                }

                System.Diagnostics.Process.Start("explorer.exe", filepath);
                lstResult.SelectedIndex = -1;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result.ToString() == "OK")
            {
                cmbFolder.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private string GetTime()
        {
            if (chkStartTime.Checked)
            {
                return txtStartTime.Text;
            }
            else if (chkEndTime.Checked)
            {
                return txtEndTime.Text;

            }
            else if (!String.IsNullOrEmpty(STime))
            {
                return STime;
            }
            else
            {
                return "00:00:00";
            }
        }
        private string GetServers(string folder)
        {
            String LogType =   "";
            if (chkError.Checked)
            {
                LogType = "ERROR";
            }
            else
            {
                LogType = "TRACE";
            }
            switch (folder)
            {
                case "DEV":
                    return @"\\10.87.8.74\c$\Safir\Logs\" + LogType;
                case "UAT":
                    return @"\\10.87.21.192\Loglar\" + LogType ;
                case "INT":
                    return @"\\10.87.16.204\Loglar\" + LogType;
                case "SET1":
                case "SET2":
                case "SET3":
                case "SET4":
                    PathBoss.Date = dateTimePicker1.Value;
                    PathBoss.SetNumber = folder.Substring(folder.Length - 1, 1);
                    PathBoss.Time = GetTime();
                    PathBoss.LogType = LogType;
                    return PathBoss.GetPath();
                case "LOCAL":
                    return @"C:\LOGS\\" + LogType;
                default:
                    return folder;
            }
        }

        private Boolean ValidateForm(bool searchtext)
        {
            if (String.IsNullOrEmpty( ControlBoss.GetControlText(txtText)) && searchtext)
            {
                MessageBox.Show("Text giriniz");
                ControlBoss.FocusControl(txtText); 
                return false;
            }
            if (String.IsNullOrEmpty(ControlBoss.GetControlText(cmbFolder)))
            {
                MessageBox.Show("Klasör seçiniz");
                ControlBoss.FocusControl(cmbFolder); 
                return false;
            }

            if ( ControlBoss.GetCheckBoxChecked(chkStartTime) & String.IsNullOrEmpty(ControlBoss.GetControlText(txtStartTime)))
            {
                MessageBox.Show("Lütfen başlangıç zamanı giriniz");
                ControlBoss.FocusControl(txtStartTime); 
                return false;
            }

            if (ControlBoss.GetCheckBoxChecked(chkEndTime) & String.IsNullOrEmpty(ControlBoss.GetControlText(txtEndTime)))
            {
                MessageBox.Show("Lütfen bitiş zamanı giriniz");
                ControlBoss.FocusControl(txtEndTime); 
                return false;
            }

            return true;

        }

        private void btnFileList_Click_1(object sender, EventArgs e)
        {
            if (!_taskRunning)
            {
                _taskRunning = false;
                _cancellationToken=new CancellationTokenSource();
                if (chkAllSet.Checked)
                {
                    _task = new Task(() => GetFilesFromAllSet(false, btnFileList, _cancellationToken));
                    _task.Start();
                }
                else
                {
                    _task = new Task(() => GetFilesFromFolder(false, btnFileList, _cancellationToken));
                    _task.Start();
                }
            }
            else 
            {
                _cancellationToken.Cancel();
                ControlBoss.EnabledControls(true);
            }
        }

        public static void RestartWindowsService(string machiname, string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName, machiname);
            TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

            try
            {
                if ((service.Status.Equals(ServiceControllerStatus.Stopped)) || (service.Status.Equals(ServiceControllerStatus.StopPending)))
                {
                    service.Start();
                }
                else
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);

                }
                MessageBox.Show("Restart yapıldı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void StopWindowsService(string machiname, string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName, machiname);
            TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

            try
            {
                if (service.Status.Equals(ServiceControllerStatus.Running)) 
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                }
                MessageBox.Show("Servis Durduruldu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static string WindowsServiceState(string machiname, string serviceName)
        {
            ServiceController service = new ServiceController(serviceName, machiname);

            try
            {
                if ((service.Status.Equals(ServiceControllerStatus.Stopped)) || (service.Status.Equals(ServiceControllerStatus.StopPending)))
                {
                    return  serviceName + " service  is Stoped";
                }
                else
                {
                    return serviceName +  " service is Running";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        private void RestartStopAppService(string folder, string SearchPattern, ServiceAction serviceAction)
        {
            string strService = PathBoss.GetService(SearchPattern, folder);
            string strMsg = String.Empty;
             switch (serviceAction)
            {
                case ServiceAction.ReStart:
                        strMsg=folder + " serverında " + strService + " servisini restart etmek istediğinizden emin misiniz?";
                        break;
                case ServiceAction.Stop:
                        strMsg=folder + " serverında " + strService + " servisini durdurmak istediğinizden emin misiniz?";
                    break;
                default:
                    break;
            }
            var dd = MessageBox.Show(strMsg, "", MessageBoxButtons.YesNo);
            if (dd==System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            string strMachine = "";
            switch (folder)
            {
                case "DEV":
                    strMachine = "10.87.8.74";
                    break;
                case "UAT":
                    strMachine = "10.87.21.192";
                    break;
                default:
                    MessageBox.Show("Servis yok");
                    return;
            }

            switch (serviceAction)
            {
                case ServiceAction.ReStart:
                        RestartWindowsService(strMachine, strService, 5000);
                        break;
                case ServiceAction.Stop:
                        StopWindowsService(strMachine, strService, 5000);
                    break;
                default:
                    break;
            } 

        }
        private void txtStartTime_Leave(object sender, EventArgs e)
        {
            try
            {
                int hour, minute, seconds;
                hour = int.Parse(txtStartTime.Text.Substring(0, 2));
                minute = int.Parse(txtStartTime.Text.Substring(3, 2));
                seconds = int.Parse(txtStartTime.Text.Substring(6, 2));
            }
            catch (Exception)
            {
                if (txtStartTime.Text.Length == 0)
                    return;
                MessageBox.Show("Lütfen formatı hh:mm:ss olarka giriniz");
                txtStartTime.Focus();
            }
        }

        private void chkStartTime_CheckedChanged(object sender, EventArgs e)
        {
            txtStartTime.Enabled = chkStartTime.Checked;
            btnStartTimeAdd.Enabled = chkStartTime.Checked;
            btnStartTimeSubstract.Enabled = chkStartTime.Checked;
        }

        private void chkEndTime_CheckedChanged(object sender, EventArgs e)
        {
            txtEndTime.Enabled = chkEndTime.Checked;
            btnEndTimeAdd.Enabled = chkEndTime.Checked;
            btnEndTimeSubstract.Enabled = chkEndTime.Checked;

        }

        private void txtEndTime_Leave(object sender, EventArgs e)
        {
            try
            {
                int hour, minute, seconds;
                hour = int.Parse(txtEndTime.Text.Substring(0, 2));
                minute = int.Parse(txtEndTime.Text.Substring(3, 2));
                seconds = int.Parse(txtEndTime.Text.Substring(6, 2));
            }
            catch (Exception)
            {
                if (txtEndTime.Text.Length == 0)
                    return;
                MessageBox.Show("Lütfen formatı hh:mm:ss olarka giriniz");
                txtEndTime.Focus();
            }
        }

        private void btnStartTimePlus_Click(object sender, EventArgs e)
        {
            changeMinute(txtStartTime, OperatorType.Add);
        }
        enum OperatorType
        {
            Add,
            Substract
        };
        private void changeMinute(TextBox txtBox, OperatorType oprtrType)
        {

            int minute;string newMinute;
            minute = int.Parse(txtBox.Text.Substring(3, 2));
            
            if (oprtrType==OperatorType.Add)
                minute++;
            else
                minute--;
        
            if (minute>59)
                minute = 0;
            if (minute < 0)
                minute = 59;

            newMinute = "0" + minute.ToString();
            newMinute = newMinute.Substring(newMinute.Length - 2, 2);

            txtBox.Text = txtBox.Text.Substring(0, 2) + ":" + newMinute + ":" + txtBox.Text.Substring(6, 2);
        }

        private void btnStartTimeNegative_Click(object sender, EventArgs e)
        {
            changeMinute(txtStartTime, OperatorType.Substract);

        }

        private void btnEndTimeAdd_Click(object sender, EventArgs e)
        {
            changeMinute(txtEndTime, OperatorType.Add);

        }

        private void btnEndTimeSubstract_Click(object sender, EventArgs e)
        {
            changeMinute(txtEndTime, OperatorType.Substract);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RestartStopAppService(cmbFolder.Text, cmbSearchPattern.Text,ServiceAction.ReStart);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestartStopAppService(cmbFolder.Text, cmbSearchPattern.Text, ServiceAction.Stop);
        }

        private void chkAllSet_CheckedChanged(object sender, EventArgs e)
        {
            cmbFolder.Enabled = !chkAllSet.Checked;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!_taskRunning)
            {
                _taskRunning = false;
                _task = new Task(
                    () => GetFilesFromFolder(true, button5, _cancellationToken)
                    , _cancellationToken.Token
                    );
                _task.Start();
            }
            else 
            {
                _cancellationToken.Cancel();
                ControlBoss.EnabledControls(true);
            }
        }
    }
}
