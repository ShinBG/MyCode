using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double c1, c2, c3, c4, c5;
                c1 = Convert.ToDouble(textBox1.Text);  //몸무게
                c2 = Convert.ToDouble(textBox2.Text);  //키
                c3 = Convert.ToDouble(textBox3.Text);  //나이
                c4 = 88.4 + (13.4 * c1) + (4.8 * c2) - (5.68 * c3);
                c5 = 447.6 + (9.25 * c1) + (3.10 * c2) - (4.33 * c3);

                if (radioButton1.Checked == true)
                {
                    textBox4.Text = Convert.ToString(c4);
                }

                if (radioButton2.Checked == true)
                {
                    textBox4.Text = Convert.ToString(c5);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("입력이 바르지 않습니다. 제대로 입력해주세요.");
                // MessageBox.Show(ex.ToString());
            }
        }
        private void claer()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            claer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 s2 = new Form2();
            s2.ShowDialog();
        }
    }
}
