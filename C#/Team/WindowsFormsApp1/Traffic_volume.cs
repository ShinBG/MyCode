using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Traffic_volume
    {
        public string Sdate { get; set; }
        public string Stime { get; set; }
        public string Cjunkook { get; set; }
        public string Cjbangdir { get; set; }
        public string Cseouldir { get; set; }

        public Traffic_volume(string sdate, string stime, string cjunkook,
            string cjbangdir, string cseouldir)
        {
            Sdate = sdate;
            Stime = stime;
            Cjunkook = cjunkook;
            Cjbangdir = cjbangdir;
            Cseouldir = cseouldir;
        }
    }
}
