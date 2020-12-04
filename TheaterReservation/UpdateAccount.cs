using System;
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

namespace TheaterReservation
{
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }

        public static int memberID = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            string firstName = textBox3.Text;
            string lastName = textBox4.Text;
            string name = firstName + " " + lastName;
            string address = textBox6.Text;
            string email = textBox5.Text;
            string cardNum = textBox7.Text;
            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE salyerstheatermember SET name = @name, address = @address, email = @email WHERE memberID = @memberID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@memberID", memberID);

                cmd.ExecuteNonQuery();

                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
