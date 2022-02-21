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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double c1, c2, c3, c4, c5, c6;
                c1 = Convert.ToDouble(textBox1.Text);  //몸무게
                c2 = Convert.ToDouble(textBox2.Text);  //키
                c3 = (c2 - 100) * 0.9;  //표준 몸무게 결과
                c4 = (c2 - 100) * 0.85;
                c5 = -(c1 - c3);
                c6 = -(c1 - c4);
                

                if (radioButton1.Checked == true)
                {
                    textBox3.Text = Convert.ToString(c3);
                    textBox4.Text = Convert.ToString(c5);
                }

                if (radioButton2.Checked == true)
                {
                    textBox3.Text = Convert.ToString(c4);
                    textBox4.Text = Convert.ToString(c6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("입력이 바르지 않습니다. 제대로 입력해주세요.");
                // MessageBox.Show(ex.ToString());
            }
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
