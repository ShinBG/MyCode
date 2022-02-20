using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_FS_Click(object sender, EventArgs e)
        {
            

            string url = "http://data.ex.co.kr/openapi/safeDriving/forecast?key=5486435297&type=xml";

            XElement Element = XElement.Load(url);

            dataGridView1.Columns.Add("Direction", "방향");
            dataGridView1.Columns.Add("Time", "소요시간");
        
            foreach (var item in Element.Elements("list"))
            {
                string csudj = item.Element("csudj").Value;
                string csudg = item.Element("csudg").Value;
                string csuus = item.Element("csuus").Value;
                string csubs = item.Element("csubs").Value;
                string csugj = item.Element("csugj").Value;
                string csump = item.Element("csump").Value;
                string csukr = item.Element("csukr").Value;
                dataGridView1.Rows.Add("서울->대전", csudj);
                dataGridView1.Rows.Add("서울->대구", csudg);
                dataGridView1.Rows.Add("서울->울산", csuus);
                dataGridView1.Rows.Add("서울->부산", csubs);
                dataGridView1.Rows.Add("서울->광주", csugj);
                dataGridView1.Rows.Add("서울->목포", csump);
                dataGridView1.Rows.Add("서울->강릉", csukr);
            }




        }

        private void btn_FSB_Click(object sender, EventArgs e)
        {
            string url = "http://data.ex.co.kr/openapi/safeDriving/forecast?key=5486435297&type=xml";

            XElement Element = XElement.Load(url);

            dataGridView2.Columns.Add("Direction", "방향");
            dataGridView2.Columns.Add("Time", "소요시간");

            foreach (var item in Element.Elements("list"))
            {
                string csudj_bus = item.Element("csudj_bus").Value;
                string csudg_bus = item.Element("csudg_bus").Value;
                string csuus_bus = item.Element("csuus_bus").Value;
                string csubs_bus = item.Element("csubs_bus").Value;
                string csugj_bus = item.Element("csugj_bus").Value;
                string csump_bus = item.Element("csump_bus").Value;
                string csukr_bus = item.Element("csukr_bus").Value;
                dataGridView2.Rows.Add("서울->대전", csudj_bus);
                dataGridView2.Rows.Add("서울->대구", csudg_bus);
                dataGridView2.Rows.Add("서울->울산", csuus_bus);
                dataGridView2.Rows.Add("서울->부산", csubs_bus);
                dataGridView2.Rows.Add("서울->광주", csugj_bus);
                dataGridView2.Rows.Add("서울->목포", csump_bus);
                dataGridView2.Rows.Add("서울->강릉", csukr_bus);
            }
        }
    }
}
