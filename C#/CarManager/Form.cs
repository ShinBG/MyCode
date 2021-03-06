using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            try
            {
                textBox_parkingSpot.Text = DataManager.Cars[0].ParkingSpot.ToString();
                textBox_carNumber.Text = DataManager.Cars[0].CarNumber.ToString();
                textBox_driverName.Text = DataManager.Cars[0].DriverName.ToString();
                textBox_phoneNumber.Text = DataManager.Cars[0].PhoneNumber.ToString();
            }
            catch (Exception ex) //메모장에만 로그가 남음.
            {
                DataManager.PrintLog("초창기 데이터가 없습니다.");
                DataManager.PrintLog(ex.Message);
                DataManager.PrintLog(ex.StackTrace);
            }
            //프로그램시작하자마자 데이터소스 바꿈
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }


        private void button_parkingAdd_Click(object sender, EventArgs e)
        {

            if(textBox_parkingSpot.Text.Trim()=="") //주차하려고 하면서 주차공간번호를 적지 않은 경우
                MessageBox.Show("주차공간을 입력하세요.");
            else if(textBox_carNumber.Text.Trim()=="") //주차하려고 하면서 자동차 번호를 적지 않은 경우
                MessageBox.Show("차량 번호 입력해주세요.");
            else //주차공간번호랑 차량번호를 다 적은 경우
            {
                try
                {
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    if(car.CarNumber.Trim() !="")
                    {
                        MessageBox.Show("해당 공간에 이미 차가 있습니다.");
                    }
                    else
                    {
                        car.CarNumber = textBox_carNumber.Text;
                        car.DriverName = textBox_driverName.Text;
                        car.PhoneNumber = textBox_phoneNumber.Text;
                        car.ParkingTime = DateTime.Now;

                        //새로 고침
                        dataGridView_parkingManager.DataSource = null;
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save(textBox_parkingSpot.Text, textBox_carNumber.Text, textBox_driverName.Text, textBox_phoneNumber.Text);

                        string contents = $"주차공간 {textBox_parkingSpot.Text}에 {textBox_carNumber.Text}차를 주차했습니다.";

                        WriteLog(contents);
                    }

                }
                catch (Exception ex) //존재하지 않는 주차공간으로 접근한 경우
                {
                    string contents = $"주차공간 {textBox_parkingSpot.Text}은(는) 없습니다.";
                    MessageBox.Show(contents);
                }
            }
        }

        private void WriteLog(string contents)
        {
            string logContents = $"[{DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss.fff")}]{contents}";
            DataManager.PrintLog(logContents);
            MessageBox.Show(contents);
            listBox_logPrint.Items.Insert(0, logContents);
        }

        private void button_parkingRemove_Click(object sender, EventArgs e)
        {
            if (textBox_parkingSpot.Text.Trim() == "") //주차공간번호를 적지 않은 경우
                MessageBox.Show("주차공간을 입력하세요.");
            else //주차공간번호랑 차량번호를 다 적은 경우
            {
                try
                {                  
                    ParkingCar car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_parkingSpot.Text);
                    if (car.CarNumber.Trim() == "")
                    {
                        MessageBox.Show("해당 공간에 아직 차가 없습니다.");
                    }
                    else
                    {
                        string oldCar = car.CarNumber;//기존에 있던 차
                        car.CarNumber = "";
                        car.DriverName = "";
                        car.PhoneNumber = "";
                        car.ParkingTime = new DateTime();
                        //new DateTime(); 의 의미 =null
                        //새로 고침
                        dataGridView_parkingManager.DataSource = null;
                        //car바뀌면 Cars안에 있는것도 같이 바뀜
                        dataGridView_parkingManager.DataSource = DataManager.Cars;

                        DataManager.Save(textBox_parkingSpot.Text, "", "", "",true);//테이블에서 업데이트
                        string contents = $"주차공간 {textBox_parkingSpot.Text}에서 {oldCar}차가 출차했습니다.";

                        WriteLog(contents);
                    }

                }
                catch (Exception ex) //존재하지 않는 주차공간으로 접근한 경우
                {
                    string contents = $"주차공간 {textBox_parkingSpot.Text}은(는) 없습니다.";
                    MessageBox.Show(contents);
                }
            }
        }

        private void dataGridView_parkingManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ParkingCar car = dataGridView_parkingManager.CurrentRow.DataBoundItem as ParkingCar;
                textBox_parkingSpot.Text = car.ParkingSpot.ToString();
                textBox_carNumber.Text = car.CarNumber;
                textBox_driverName.Text = car.DriverName;
                textBox_phoneNumber.Text = car.PhoneNumber;
            }
            catch (Exception)
            {             
            }
        }

        private void timer_DisplayNow_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Now.Text =
                "현재시간 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //내가 추가할 주차공간 번호를 적는다.
            int.TryParse(textBox_parkingSpot_lookUp.Text, out int parkingSpot);

            if (parkingSpot <=0)
            {
                WriteLog("주차공간번호는 0 이상의 숫자여야 합니다.");//손님이 잘못한 걸 감지할 수 있다.
                return;//함수 종료됨
            }

            DBHelper.selectQuery(parkingSpot); //해당하는 주차공간을 찾는다.

            //해당 공간이 없는거
            if(DBHelper.dt.Rows.Count<1)//1미만이라 하면 하나도 없단 소리
            {
                DBHelper.insertQuery(parkingSpot);
                string contents = $"주차공간 {parkingSpot}이/가 추가되었습니다.";
                WriteLog(contents);

                button_AllLookUp.PerformClick();//전체조회버튼을 강제로 눌러서 다시 select*from~ 을 호출.
            }
            else
            {
                string contents = "해당 주차 공간 이미 존재";
                WriteLog(contents);
            }

     
        }

        private void button_AllLookUp_Click(object sender, EventArgs e)
        {
            DataManager.Load();
            dataGridView_parkingManager.DataSource = null;
            dataGridView_parkingManager.DataSource = DataManager.Cars;
        }

        private void button_SelectedLookUp_Click(object sender, EventArgs e)
        {
            try
            {

                int parkingSpot = int.Parse(textBox_parkingSpot_lookUp.Text);
                string ParkedCar = lookUpParkingSpot(parkingSpot);//해당공간에 주차된 차 찾는 함수
                if(ParkedCar !="")
                {
                    string contents = $"주차공간 {parkingSpot}에 주차되어 있는 차는 {ParkedCar} 입니다.";
                    WriteLog(contents);
                }
                else
                {
                    string contents = $"주차공간 {parkingSpot}에 주차되어 있는 차는 없습니다.";
                    WriteLog(contents);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string lookUpParkingSpot(int parkingSpot)
        {
            try
            {
                string parkedCarNum = "";
                foreach(var item in DataManager.Cars)
                {
                    if (item.ParkingSpot == parkingSpot)
                        parkedCarNum = item.CarNumber;
                }
                return parkedCarNum;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
