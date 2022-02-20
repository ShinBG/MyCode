using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ToSeoulBus
    {
        public string cdjsu_bus { get; set; }
        public string cdgsu_bus { get; set; }
        public string cussu_bus { get; set; }
        public string cbssu_bus { get; set; }
        public string cgjsu_bus { get; set; }
        public string cmpsu_bus { get; set; }
        public string ckrsu_bus { get; set; }

        public ToSeoulBus(string cdjsu_bus, string cdgsu_bus, 
            string cussu_bus, string cbssu_bus, string cgjsu_bus, 
            string cmpsu_bus, string ckrsu_bus)
        {
            this.cdjsu_bus = cdjsu_bus;
            this.cdgsu_bus = cdgsu_bus;
            this.cussu_bus = cussu_bus;
            this.cbssu_bus = cbssu_bus;
            this.cgjsu_bus = cgjsu_bus;
            this.cmpsu_bus = cmpsu_bus;
            this.ckrsu_bus = ckrsu_bus;
        }
    }
}
