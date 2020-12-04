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

        public String eventName = "";
        public String eventDate = "";
        public int amt = 0;
        public String seat_loc = "";
        public int count = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;

            this.TopMost = false;

            Payment makePayment = new Payment(seat_loc, amt, eventName, eventDate);
            makePayment.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            if (selectedItem == null)
            {
                return;
            }
            //checkes if VIP seating or not
            if (Int32.Parse(selectedItem.ToString()) > 32)
            {
                amt += 35;
            }
            else
            {
                amt += 50;
            }
            label3.Text = ("Total : $" + amt);

            seatsLabel.Text += selectedItem.ToString() + " ";
            seat_loc += selectedItem.ToString() + " ";

            comboBox1.Items.RemoveAt(selectedIndex);

            count++;
            if (count == 4)
            {
                comboBox1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void ReserveSeats_Load(object sender, EventArgs e)
        {

            ArrayList Seats = new ArrayList();

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "SELECT seats FROM salyerstheaterreservation WHERE event = @event";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@event", eventName);
                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    Seats.Add(myReader.GetString(0));
                }
                myReader.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            ArrayList takenSeats = new ArrayList();

            foreach (string s in Seats)
            {
                string seat = "";
                int count = 1;

                foreach (char c in s)
                {
                    if (c != ' ')
                    {
                        seat += c;
                    }
                    else if (c == ' ' || count == s.Length)
                    {
                        takenSeats.Add(seat);

                        seat = "";
                    }
                    count++;
                }
            }

            for (int i = 1; i <= 104; i++)
            {
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            amt = 0;
            seat_loc = "";
            seatsLabel.Text = "Seats Selected: ";
            label3.Text = "Total : $" + amt;
            count = 0;

            ReserveSeats reset = new ReserveSeats();

            this.Close();
            reset.TopMost = true;
            reset.Show();
            reset.eventName = EventInfo.eventType;
        }
    }
}
