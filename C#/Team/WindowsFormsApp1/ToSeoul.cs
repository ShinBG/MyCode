using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ToSeoul
    {
        public string cdjsu { get; set; }
        public string cdgsu { get; set; }
        public string cussu { get; set; }
        public string cbssu { get; set; }
        public string cgjsu { get; set; }
        public string cmpsu { get; set; }
        public string ckrsu { get; set; }

        public ToSeoul(string cdjsu, string cdgsu, 
            string cussu, string cbssu, string cgjsu, 
            string cmpsu, string ckrsu)
        {
            this.cdjsu = cdjsu;
            this.cdgsu = cdgsu;
            this.cussu = cussu;
            this.cbssu = cbssu;
            this.cgjsu = cgjsu;
            this.cmpsu = cmpsu;
            this.ckrsu = ckrsu;
        }
    }
}
