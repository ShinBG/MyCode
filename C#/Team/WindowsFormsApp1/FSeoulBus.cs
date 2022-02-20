using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class FSeoulBus
    {
        public string csudj_bus { get; set; }
        public string csudg_bus { get; set; }
        public string csuus_bus { get; set; }
        public string csubs_bus { get; set; }
        public string csugj_bus { get; set; }
        public string csump_bus { get; set; }
        public string csukr_bus { get; set; }

        public FSeoulBus(string csudj_bus, string csudg_bus, 
            string csuus_bus, string csubs_bus, 
            string csugj_bus, string csump_bus, string csukr_bus)
        {
            this.csudj_bus = csudj_bus;
            this.csudg_bus = csudg_bus;
            this.csuus_bus = csuus_bus;
            this.csubs_bus = csubs_bus;
            this.csugj_bus = csugj_bus;
            this.csump_bus = csump_bus;
            this.csukr_bus = csukr_bus;
        }
    }
}
