using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using ZedGraph;
namespace Monitor_Suhu__Record_
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Rudi Tawangga\Documents\Visual Studio 2012\Projects\Monitor Suhu\Monitor Suhu\DB_SUHU.mdf;Integrated Security=True;Connect Timeout=30");
        SerialPort arduino = new SerialPort("COM8", 9600);

        public Form1()
        {
            InitializeComponent();
        }
        static string[] hari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
        string now = hari[(int) DateTime.Now.DayOfWeek] + " ," + DateTime.Now.ToLongDateString();
        string jam = DateTime.Now.ToShortTimeString() + " WIB";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SUHUDataSet.tbl_suhu' table. You can move, or remove it, as needed.
            //dateTimePicker1.Text = DateTime.Now.ToString() ;
            lblTgl.Text = now;
            lblJam.Text = jam;
            showDataNow();
            timer1.Enabled = true;
            timer1.Start();
            rataratalive();
            rataratanow();

            myPane = graphSuhuNow.GraphPane;
            myPane.Title.Text = "Grafik Suhu";
            myPane.XAxis.Title.Text = "Waktu";
            myPane.YAxis.Title.Text = "Suhu";
            suhu = myPane.AddCurve("Suhu", listSuhu, Color.Red, SymbolType.None);
            //    GrafSuhuNow();

            GrafSuhuRecordNow();
            myPane2 = graphSuhuRecord.GraphPane;
            myPane2.Title.Text = "Grafik Suhu";
            myPane2.XAxis.Title.Text = "Waktu";
            myPane2.YAxis.Title.Text = "Suhu";
            suhu = myPane2.AddCurve("Suhu", listSuhuRecord, Color.Red, SymbolType.None);

            GrafSuhuRecordNow();
        }

        void ratarata()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select round(AVG(suhu),2) from tbl_suhu where waktu >= '" + Convert.ToDateTime(dateData.Text).ToString("MM/dd/yyyy") + "' and waktu < '" + Convert.ToDateTime(dateData.Value.AddDays(1).ToString()).ToString("MM/dd/yyyy") + "' ";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                reader.Read();
                lblRataRata.Text = reader[0].ToString() + " °C";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void rataratanow()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select round(AVG(suhu),2) from tbl_suhu where waktu >= '" + DateTime.Now.ToString("MM/dd/yyyy") + "' and waktu < '" + DateTime.Now.AddDays(1).ToString("MM/dd/yyyy") + "' ";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                lblRataRata.Text = reader[0].ToString() + " °C";
                //lblrata.Text = reader[0].ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void rataratalive()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select round(AVG(suhu),2) from tbl_suhu where waktu >= '" + DateTime.Now.ToString("MM/dd/yyyy") + "' and waktu < '" + DateTime.Now.AddDays(1).ToString("MM/dd/yyyy") + "' ";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                //lblRataRata.Text = reader[0].ToString();
                lblrata.Text = reader[0].ToString() + " °C";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              string[] hari = { "Minggu", "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu" };
             string now = hari[(int) DateTime.Now.DayOfWeek] + " ," + DateTime.Now.ToLongDateString();
             string jam = DateTime.Now.ToShortTimeString() + " WIB";
            lblTgl.Text = now;
            lblJam.Text = jam;
            showTemp();
            rataratalive();
            GrafSuhuNow();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            showData();
            ratarata();
        }
        void showDataNow()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from tbl_suhu where waktu >= '" + DateTime.Now.ToString("MM/dd/yyyy") + "' and waktu <  '" + DateTime.Now.AddDays(1).ToString("MM/dd/yyyy") + "' ORDER BY id DESC ";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "tbl_suhu");
                dataGridSuhu.DataSource = ds1;
                dataGridSuhu.DataMember = "tbl_suhu";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        void showData()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select * from tbl_suhu where waktu >= '" + Convert.ToDateTime(dateData.Text).ToString("MM/dd/yyyy") + "' and waktu< '" + Convert.ToDateTime(dateData.Value.AddDays(1).ToString()).ToString("MM/dd/yyyy") + "' ORDER BY id DESC ";
                DataSet ds1 = new DataSet();
                SqlDataAdapter da1 = new SqlDataAdapter(command);
                da1.Fill(ds1, "tbl_suhu");
                dataGridSuhu.DataSource = ds1;
                dataGridSuhu.DataMember = "tbl_suhu";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        void showTemp()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "select suhu from tbl_suhu order by id desc";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                reader.Read();
                //   while (reader.Read())
                // {
                lblTemp.Text = reader[0].ToString() + " °C";
                // }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void lblTemp_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showData();
            ratarata();
        }

        GraphPane myPane = new GraphPane();
        GraphPane myPane2 = new GraphPane();
        PointPairList listSuhu = new PointPairList();
        PointPairList listSuhuRecord = new PointPairList();
        LineItem suhu;


        void GrafSuhuNow()
        {

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Select * from tbl_suhu where waktu >= '" + DateTime.Now.ToString("MM/dd/yyyy") + "' and waktu <  '" + DateTime.Now.AddDays(1).ToString("MM/dd/yyyy") + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                int a = 0;
                listSuhu.Clear();
                while (reader.Read())
                {
                    listSuhu.Add(a, Convert.ToDouble(reader["suhu"]));
                    a++;
                }
                a = 0;
                graphSuhuNow.AxisChange();
                graphSuhuNow.Invalidate();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void GrafSuhuRecordNow()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Select * from tbl_suhu where waktu >= '" + DateTime.Now.ToString("MM/dd/yyyy") + "' and waktu <  '" + DateTime.Now.AddDays(1).ToString("MM/dd/yyyy") + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                int a = 0;
                listSuhuRecord.Clear();
                while (reader.Read())
                {
                    listSuhuRecord.Add(a, Convert.ToDouble(reader["suhu"]));
                    a++;
                }
                a = 0;
                graphSuhuRecord.AxisChange();
                graphSuhuRecord.Invalidate();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GrafSuhuRecord()
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                string query = "Select * from tbl_suhu where waktu >= '" + Convert.ToDateTime(dateGraph.Text).ToString("MM/dd/yyyy") + "' and waktu< '" + Convert.ToDateTime(dateGraph.Value.AddDays(1).ToString()).ToString("MM/dd/yyyy") + "'";
                command.CommandText = query;
                SqlDataReader reader = command.ExecuteReader(); ;
                int a = 0;
                listSuhuRecord.Clear();
                while (reader.Read())
                {
                    listSuhuRecord.Add(a, Convert.ToDouble(reader["suhu"]));
                    a++;
                }
                a = 0;
                graphSuhuRecord.AxisChange();
                graphSuhuRecord.Invalidate();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateGraph_ValueChanged(object sender, EventArgs e)
        {
            GrafSuhuRecord();
        }
    }
}
