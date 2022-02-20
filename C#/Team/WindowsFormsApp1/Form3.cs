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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_TS_Click(object sender, EventArgs e)
        {
            string url = "http://data.ex.co.kr/openapi/safeDriving/forecast?key=5486435297&type=xml";

            XElement Element = XElement.Load(url);

            dataGridView1.Columns.Add("Direction", "방향");
            dataGridView1.Columns.Add("Time", "소요시간");

            foreach (var item in Element.Elements("list"))
            {
                string cdjsu = item.Element("cdjsu").Value;
                string cdgsu = item.Element("cdgsu").Value;
                string cussu = item.Element("cussu").Value;
                string cbssu = item.Element("cbssu").Value;
                string cgjsu = item.Element("cgjsu").Value;
                string cmpsu = item.Element("cmpsu").Value;
                string ckrsu = item.Element("ckrsu").Value;
                dataGridView1.Rows.Add("대전->서울", cdjsu);
                dataGridView1.Rows.Add("대구->서울", cdgsu);
                dataGridView1.Rows.Add("울산->서울", cussu);
                dataGridView1.Rows.Add("부산->서울", cbssu);
                dataGridView1.Rows.Add("광주->서울", cgjsu);
                dataGridView1.Rows.Add("목포->서울", cmpsu);
                dataGridView1.Rows.Add("강릉->서울", ckrsu);
            }
        }

        private void btn_TSB_Click(object sender, EventArgs e)
        {
            string url = "http://data.ex.co.kr/openapi/safeDriving/forecast?key=5486435297&type=xml";

            XElement Element = XElement.Load(url);

            dataGridView2.Columns.Add("Direction", "방향");
            dataGridView2.Columns.Add("Time", "소요시간");

            foreach (var item in Element.Elements("list"))
            {
                string cdjsu_bus = item.Element("cdjsu_bus").Value;
                string cdgsu_bus = item.Element("cdgsu_bus").Value;
                string cussu_bus = item.Element("cussu_bus").Value;
                string cbssu_bus = item.Element("cbssu_bus").Value;
                string cgjsu_bus = item.Element("cgjsu_bus").Value;
                string cmpsu_bus = item.Element("cmpsu_bus").Value;
                string ckrsu_bus = item.Element("ckrsu_bus").Value;
                dataGridView2.Rows.Add("대전->서울", cdjsu_bus);
                dataGridView2.Rows.Add("대구->서울", cdgsu_bus);
                dataGridView2.Rows.Add("울산->서울", cussu_bus);
                dataGridView2.Rows.Add("부산->서울", cbssu_bus);
                dataGridView2.Rows.Add("광주->서울", cgjsu_bus);
                dataGridView2.Rows.Add("목포->서울", cmpsu_bus);
                dataGridView2.Rows.Add("강릉->서울", ckrsu_bus);
            }
        }
    }
}
