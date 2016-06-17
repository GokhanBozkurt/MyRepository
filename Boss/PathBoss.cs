using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using Safiye.Properties;

namespace Safiye.Boss
{
    public  static  class PathBoss
    {
        public static DateTime Date;
        public static string Time;
        public static string SetNumber;
        public static String LogType;
        public static string GetPath()
        {
            string pathh = null;
            if (Directory.Exists(GetProdLogArchivePath() + Date.ToString("yyyyMMdd") + "\\" + GetHour()))
                pathh = GetProdLogArchivePath() + Date.ToString("yyyyMMdd") + "\\" + GetHour();
            else if (Directory.Exists(GetProdLogPath() + Date.ToString("yyyyMMdd") + "\\" + GetHour()))
                pathh = GetProdLogPath() + Date.ToString("yyyyMMdd") + "\\" + GetHour();
            else
                pathh = GetProdLogPath();

            return pathh;
        }

        private static string GetProdLogArchivePath()
        {
            return "\\\\kwpublog01\\Mil_Logs\\KWSFRAPP0" + (int.Parse(SetNumber) + 1).ToString() + "\\Safir\\Loglar\\"+LogType+ "\\";

        }

        private static string GetHour()
        {
            if (Time.Length < 5)
                return "00";
            else if (Time.Length == 5)
                return "0" + Time.Substring(0, 1);
            else
                return Time.Substring(0, 2); ;
        }

        private static string GetProdLogPath()
        {
            switch (SetNumber)
            {
                case "1":
                    return "\\\\10.37.51.23\\Loglar\\"+LogType+"\\";
                case "2":
                    return "\\\\10.37.51.27\\Loglar\\" + LogType + "\\";
                case "3":
                    return "\\\\10.37.51.26\\Loglar\\" + LogType + "\\";
                case "4":
                    return "\\\\10.37.51.24\\Loglar\\" + LogType + "\\";
                default:
                    return "";
            }

        }

        public static string GetAppInfo(string folder, string searchPattern)
        {

            try
            {
                string strAppInfo = PathBoss.GetAppPath(folder, searchPattern);

                var fileLastWriteTime = File.GetLastWriteTime(strAppInfo);

                return strAppInfo + " >> " + fileLastWriteTime.ToString(CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {

                return "";
            }

        }

        private static string GetAppPath(string folder, string searchPattern)
        {
            string strProgram = GetProgram(searchPattern);

            switch (folder)
            {
                case "DEV":
                    return @"\\10.87.8.74\c$\Safir\Programs\" + strProgram;
                case "UAT":
                    return @"\\10.87.21.192\Programs\" + strProgram;
                case "INT":
                    return @"\\10.87.16.204\Safir\Programs\" + strProgram;
                case "SET1":
                    return @"\\10.37.51.23\Programs\" + strProgram;
                case "SET2":
                    return @"\\10.37.51.27\Programs\" + strProgram;
                case "SET3":
                    return @"\\10.37.51.26\Programs\" + strProgram;
                case "SET4":
                    return @"\\10.37.51.24\Programs\" + strProgram;
                case "LOCAL":
                    return @"C:\Safir\Programs\" + strProgram;
                default:
                    return "";
            }

        }
        private static string GetProgram(string SearchPattern)
        {
            switch (SearchPattern)
            {
                case "*SOB*":
                    return "SOBE\\SOBE.exe";
                case "*IEN*":
                    return "Safir.Online.Router.IEN\\Safir.Online.Router.Service.exe";
                case "*VER*":
                    return "Safir.Online.Router.Vera\\Safir.Online.Router.Service.exe";
                case "*AKIL*":
                    return "Safir.Online.Router.Akil\\Safir.Online.Router.Service.exe";
                case "*HST*":
                    return "HOST\\hc_gw.exe";
                case "*MCR*":
                    return "Safir.Online.Router.MasterCard\\Safir.Online.Router.Service.exe";
                case "*DOM*":
                    return "Safir.Online.Router.Domestic\\Safir.Online.Router.Service.exe";
                case "*ECO*":
                    return "Safir.Online.Router.ECommerce\\Safir.Online.Router.Service.exe";
                case "*SRI*":
                    return "SRI\\SRI.exe";
                case "*STIP*":
                    return "Stipper\\Safir.Online.Stiper.exe";
                default:
                    return "";
            }
        }

        public static string GetService(string searchPattern,string folder)
        {
            switch (searchPattern)
            {
                case "*SOB*":
                    return "Safir SOBE Server";
                case "*IEN*":
                    return "Safir Router IEN";
                case "*VER*":
                    return "Safir Router for Vera";
                case "*AKIL*":
                    if (folder == Resources.SearchText_UAT)
                        return "Safir.Online.Router.Akil";
                    else
                        return "Safir Router for Akil";
                case "*HST*":
                    return "Safir Host Connector";
                case "*MCR*":
                    return "Safir Router MasterCard";
                case "*DOM*":
                    return "Safir Router for Domestic";
                case "*ECO*":
                    return "Safir Router for ECommerce";
                case "*SRI*":
                    return "SRI\\SRI.exe";
                case "*STIP*":
                    return "Safir Stipper";
                default:
                    return "";
            }
        }

        public static string ExtractPath()
        {
            string sPath = Application.StartupPath + "\\SafiyeExtractPath\\";

            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }

            return sPath;
        }

        public static string CopyFile(FileInfo file)
        {
            string newFileName = PathBoss.ExtractPath() + file.Name + "_" + DateTime.Now.ToString("hhmmssfff") + "." + file.Extension;
            if (!File.Exists(newFileName))
                file.CopyTo(newFileName, true);
            return newFileName;
        }

        public static void DeleteFile()
        {
            foreach (var item in Directory.GetFiles(PathBoss.ExtractPath()))
            {
                try
                {
                    File.Delete(item);
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        public static string Decompress(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.Name;
                string newFileName = PathBoss.ExtractPath() + (currentFileName.Remove(currentFileName.Length - fileToDecompress.Extension.Length));
                if (File.Exists(newFileName))
                {
                    File.Delete(newFileName);
                }
                ZipFile.ExtractToDirectory(fileToDecompress.FullName, PathBoss.ExtractPath());
                var returnfile= CopyFile(new FileInfo(newFileName));
                File.Delete(newFileName);
                return returnfile;
            }
        }

        public static void DecompressFolder(FileInfo fileToDecompress)
        {
            using (FileStream originalFileStream = fileToDecompress.OpenRead())
            {
                string currentFileName = fileToDecompress.Name;
                ZipFile.ExtractToDirectory(fileToDecompress.FullName, PathBoss.ExtractPath());
            }
        }


        public static string CheckFile(FileInfo file, bool searchtext)
        {
            string fileName;
            if (!searchtext)
            {
                return fileName = file.FullName;
            }
            else if (file.Extension.ToUpper() == ".ZİP")
            {
                fileName = Decompress(file);
            }
            else
            {
                fileName = CopyFile(file);
            }

            return fileName;
        }
    }
}
