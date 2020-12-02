using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace TheaterReservation
{
    public partial class ReserveSeats : Form
    {
        public ReserveSeats()
        {
            InitializeComponent();
        }

        public static string eventName = "";

        private void button3_Click(object sender, EventArgs e)
        {
            Payment makePayment = new Payment();
            makePayment.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public ArrayList getTakenSeats()
        {
            ArrayList seatList = new ArrayList();  //a list to save the events
                                                    //prepare an SQL query to retrieve all the events on the same, specified date
            DataTable myTable = new DataTable();
            string connStr = " server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT seats FROM salyerstheaterreservation WHERE event = @event";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@event", "eventName");
                MySqlDataAdapter myAdapter = new MySqlDataAdapter(cmd);
                myAdapter.Fill(myTable);
                Console.WriteLine("Table is ready.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            //convert the retrieved data to events and save them to the list

            string temp = "";

            foreach (DataRow row in myTable.Rows)
            {
                temp = row.ToString();

                string seat = "";

                foreach (char c in temp){
                    if (c != ',' && c != ' ')
                    {
                        seat += c;
                    }else if (c == ',')
                    {
                        seatList.Add(seat);

                        seat = "";
                    }
                }
            }
            return seatList;  //return the event list
        }

        private void ReserveSeats_Load(object sender, EventArgs e)
        {

            ArrayList takenSeats = getTakenSeats();

            for (int i = 1; i <= 105; i++){
                if (takenSeats.Contains(i.ToString()))
                {
                    continue;
                }
                else
                {
                    comboBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
