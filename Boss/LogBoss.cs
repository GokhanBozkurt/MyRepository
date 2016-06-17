using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Safiye.Boss
{
    public class ReturnDoubleValue<T,TX>
    {
        public bool Success { get; set; }
        public T Value { get; set; }
    }

    public class ReturnThirdValue<T, TX, TY>
    {
        public bool Success { get; set; }
        public T Value { get; set; }
        public TX Value1 { get; set; }
        public TY Value2 { get; set; }
    }

    public static class LogBoss
    {
        private static StringBuilder _fileArayList = new StringBuilder();
        private static int _firsFoundLine;
        private static int _totalLine;

        public static string GetDetail(string searchText, string filepath,ListBox listBox)
        {
            var threadId = GetThreadId(listBox);
            var trnxDetail=new StringBuilder();
            var reader = new StreamReader(filepath);
            int rowNumber = 0;
            try
            {
                do
                {
                    string line = reader.ReadLine();
                    if (line != null && line.StartsWith(threadId))
                    {
                        trnxDetail.AppendLine(line);
                    }
                }
                while (!reader.EndOfStream);
            }
           
            finally
            {
                reader.Close();
                reader.Dispose();
            }

            return trnxDetail.ToString();
        }

        public static void Find()
        {
            string tempthreadId=String.Empty;
            string threadId="";
            var ss = _fileArayList[_firsFoundLine];
            int i;
            for (i = _firsFoundLine; i >0; i--)
            {
                threadId = _fileArayList[i].ToString().Substring(0, 8);
                if (String.IsNullOrEmpty(tempthreadId))
                {
                    tempthreadId = _fileArayList[i].ToString().Substring(0, 8);
                }
                if (threadId!=tempthreadId)
                {
                    break;
                }
                
            }

            for (int j = i; j < _totalLine; j++)
            {
                
            }
        }
        public static ReturnDoubleValue<ArrayList, Boolean> SearchTextFile(string sSearchText, string fileName)
        {

            var findedLines = new ArrayList();
            int line = 0;
            bool success=false;
            _firsFoundLine = 0;
            _fileArayList.Clear();
            sSearchText = sSearchText.Replace(" ", "");
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader sr = new StreamReader(fs, Encoding.Default))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    line++;
                    _fileArayList.AppendLine(s);
                    if (s.Contains(sSearchText))
                    {
                        if (_firsFoundLine==0)
                        {
                            _firsFoundLine = line;
                        }
                        findedLines.Add(">>>>>" + s);
                        success = true;
                    }
                }
            }
            _totalLine = line;
            return new ReturnDoubleValue<ArrayList, bool>() {Success = success, Value = findedLines };
        }

        private static string GetThreadId(ListBox listBox)
        {
            foreach (var items in listBox.Items)
            {
                if (items.ToString().Contains("RRN GENERATED"))
                {
                    var ss = items.ToString().Replace(">>>>>","");
                    return ss.Substring(0, 8);
                }
            }

            return "";
        }

    }
}
