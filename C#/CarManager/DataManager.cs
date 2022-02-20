using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager
{
    public class DataManager
    {
        public static List<ParkingCar> Cars = new List<ParkingCar>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {
                DBHelper.selectQuery();
                Cars.Clear();
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    ParkingCar car = new ParkingCar();
                    car.ParkingSpot = int.Parse(item["ParkingSpot"].ToString());
                    car.CarNumber = item["CarNumber"].ToString();
                    car.DriverName = item["DriverName"].ToString();
                    car.PhoneNumber = item["PhoneNumber"].ToString();
                    car.ParkingTime = item["ParkingTime"].ToString() == "" ? new DateTime() : DateTime.Parse(item["ParkingTime"].ToString());
                    Cars.Add(car);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message+Environment.NewLine+ex.StackTrace);
            }
        }

        
        public static void Save(string parkingSpotText, string carNumberText, string driverNameText, string phoneNumber, bool isRemove = false)
        {
            try
            {
                DBHelper.updateQuery(parkingSpotText, carNumberText, driverNameText, phoneNumber, isRemove);
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message + Environment.NewLine + exception.StackTrace);
            }
        }

        public static void PrintLog(string contents)
        {
            DirectoryInfo di = new DirectoryInfo("ParkingHistory"); //폴더 경로
            if(!di.Exists) //bin폴더 안에, Debug나 Release 안에 실행파일이 있을 텐데, 같은 경로안에 ParkingHistory 폴더 없을 때
            {
                di.Create(); //ParkingHistory 폴더 만듦
            }
            using (StreamWriter writer = new StreamWriter("ParkingHistory" + "\\" + "ParkingHistory" + ".txt", true))
            {
                writer.WriteLine(contents);
            }

        }

    }
}
