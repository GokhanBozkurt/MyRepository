using System;
using System.Configuration;
using System.Windows.Forms;

namespace Safiye.Boss
{
    internal  class ConfigBoss
    {
        private static ConfigBoss _instance;
        private static readonly object Lockobject=new object();
        public IniFileBoss IniFile =new IniFileBoss(Application.StartupPath + "\\Safiye.ini");
        public string DbUser;
        public string DbPass;

        private ConfigBoss()
        {
            
        }

        public void Initiliaze()
        {
            DbUser = this["DbUser"];
            DbPass = this["DbPass"];            
        }
        public static ConfigBoss Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (Lockobject)
                    {
                        _instance = new ConfigBoss();
                    }
                }
                return _instance;
            }
            
        }

        private void CheckIni()
        {
            
        }

        public string GetConnString(ConnType connType)
        {
            switch (connType)
            {
                case ConnType.Dev:
                return "Data Source=SRV_SAFIR_OLDEV ;User Id=SFRADM;Password=sfrAdev3;";
                case ConnType.Int:
                    return "Data Source=SRV_SAFIR_OLINT ;User Id=SFRADM;Password=sfrAint3;";
                case ConnType.Uat:
                    return "Data Source=SRV_SAFIR_OLUAT;User Id=SFRRW;Password=sfrWuat1;";
                case ConnType.Prod:
                    return String.Format("Data Source=SAFIR_114;User Id={0};Password={1};", DbUser, DbPass);
                default:
                    throw new ArgumentOutOfRangeException(nameof(connType), connType, null);
            }
        }

        public string this[string key] => ConfigurationManager.AppSettings[key];
    }

    internal enum ConnType
    {
        Dev,
        Int,
        Uat,
        Prod
    }
}
