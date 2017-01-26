using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace untuk class serial
using System.IO.Ports;
using System.Globalization;
using System.Data.SqlClient;
using ZedGraph;
using System.Data;

namespace Monitor_Suhu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SerialPort arduino = new SerialPort("COM8", 9600);
                arduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                arduino.Open();
                    Console.WriteLine("Press any key to continue...");
                    Console.WriteLine();
                    Console.ReadKey();
                    arduino.Close();
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Arduino Belum Dicolok gan!!");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\rudi tawangga\documents\visual studio 2012\Projects\Monitor Suhu\Monitor Suhu\DB_SUHU.mdf;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter();
            SerialPort sp = (SerialPort)sender;
            float indata = float.Parse(sp.ReadLine() ,CultureInfo.InvariantCulture.NumberFormat);
           // indata = System.Math.Round(indata, 2);
            Console.Write("Suhu Saai Ini : ");
            Console.WriteLine(indata);
            Console.Write("Pada : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine();
            
            try {
                cs.Open();
                //Buat query untuk insert catatan
                da.InsertCommand = new SqlCommand("INSERT INTO tbl_suhu (suhu, waktu) VALUES (round(@SUHU,2), '" + DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + "')", cs);
                da.InsertCommand.Parameters.AddWithValue("@SUHU", SqlDbType.Float).Value = indata;
                // da.InsertCommand.Parameters.AddWithValue("@WAKTU", SqlDbType.DateTime).Value = DateTime.Now.ToString();

                da.InsertCommand.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                cs.Close();
            }
            
        }
    }
}
