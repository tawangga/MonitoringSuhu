using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//namespace untuk class serial
using System.IO.Ports;
//namespace untuk melihat setting global komputer
using System.Globalization;
//Namespace untuk databse MSSQL
using System.Data.SqlClient;

namespace Monitor_Suhu__Record_
{
    class Monitor_Suhu
    {
        static void record(string[] args)
        {
            SerialPort arduino = new SerialPort("COM8", 9600);
            arduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            arduino.Open();
            int pilih = Console.Read();
            if (pilih == 1)
            {
                Console.WriteLine("Press any key to continue...");
                Console.WriteLine();
                Console.ReadKey();
                arduino.Close();
            }
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SqlConnection cs = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Rudi Tawangga\Documents\Visual Studio 2012\Projects\Monitor Suhu\Monitor Suhu\DB_SUHU.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter();
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            // decimal.Round(indata, 2, MidpointRounding.AwayFromZero);
            Console.Write("Data Diterima : ");
            Console.WriteLine(indata);
            Console.Write("Pada : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine();

            try
            {
                cs.Open();
                //Buat query untuk insert catatan
                da.InsertCommand = new SqlCommand("INSERT INTO tbl_suhu (suhu, waktu) VALUES ('" + indata + "', '" + DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + "')", cs);
                // da.InsertCommand.Parameters.AddWithValue("@SUHU", SqlDbType.Float).Value = dataSuhu;
                // da.InsertCommand.Parameters.AddWithValue("@WAKTU", SqlDbType.DateTime).Value = DateTime.Now.ToString();

                //buka koneksi ke database

                //eksekusi query insert
                da.InsertCommand.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                cs.Close();
            }

        }
    }
}
