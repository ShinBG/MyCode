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
    public partial class Form1 : Form
    {
        bool On;

        Point Pos;
        public Form1()
        {
            InitializeComponent();
            MouseDown += (o, e) => { if (e.Button == MouseButtons.Left) { On = true; Pos = e.Location; } };
            MouseMove += (o, e) => { if (On) Location = new Point(Location.X + (e.X - Pos.X), Location.Y + (e.Y - Pos.Y)); };
            MouseUp += (o, e) => { if (e.Button == MouseButtons.Left) { On = false; Pos = e.Location; } };
        }

        private void btn_ToForm2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btn_ToForm3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void btn_Tvolume_Click(object sender, EventArgs e)
        {
            string url = "http://data.ex.co.kr/openapi/safeDriving/forecast?key=5486435297&type=xml";

            XElement Element = XElement.Load(url);
            List<Traffic_volume> volumes = new List<Traffic_volume>();
            foreach (var item in Element.Elements("list"))
            {
                string sdate = item.Element("sdate").Value;
                string stime = item.Element("stime").Value;
                string cjunkook = item.Element("cjunkook").Value;
                string cjbangdir = item.Element("cjibangDir").Value;
                string cseouldir = item.Element("cseoulDir").Value;
                volumes.Add(new Traffic_volume(sdate, stime, cjunkook, cjbangdir, cseouldir));
            }
            dataGridView1.DataSource = null;
            if (volumes.Count > 0)
                dataGridView1.DataSource = volumes;

            chart1.Series["Series1"].LegendText = "교통량";
            chart1.Series["Series1"].Points.Clear();


            foreach (var item in Element.Elements("list"))
            {

                chart1.Series["Series1"].Points.AddXY("전국교통량", item.Element("cjunkook").Value);
                chart1.Series["Series1"].Points.AddXY("지방방향교통량", item.Element("cjibangDir").Value);
                chart1.Series["Series1"].Points.AddXY("서울방향교통량", item.Element("cseoulDir").Value);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
