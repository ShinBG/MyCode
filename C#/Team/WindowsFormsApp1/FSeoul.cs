using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FSeoul
    {
        public string csudj { get; set; }
        public string csudg { get; set; }
        public string csuus { get; set; }
        public string csubs { get; set; }
        public string csugj { get; set; }
        public string csump { get; set; }
        public string csukr { get; set; }

        public FSeoul(string csudj, string csudg, 
            string csuus, string csubs, string csugj, 
            string csump, string csukr)
        {
            this.csudj = csudj;
            this.csudg = csudg;
            this.csuus = csuus;
            this.csubs = csubs;
            this.csugj = csugj;
            this.csump = csump;
            this.csukr = csukr;
        }
    }
}
