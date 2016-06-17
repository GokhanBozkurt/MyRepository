using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safiye
{
    public static class Cost
    {
        private static DateTime _now;
        private static TimeSpan _timeSpan;
        public static void Start()
        {
            _now=DateTime.Now;
        }

        public static string CostBySeconds
        {
            get
            {
                _timeSpan = DateTime.Now - _now;
                return _timeSpan.TotalSeconds.ToString("N") + " second";
            }
        }

        public static string CostByMiliSeconds
        {
            get
            {
                _timeSpan = DateTime.Now - _now;
                return _timeSpan.TotalMilliseconds.ToString("N");
            }
        }
    }
}
