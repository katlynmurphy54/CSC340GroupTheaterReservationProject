using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TheaterReservation
{
    public partial class AccountRegister : Form
    {
        public AccountRegister()
        {
            InitializeComponent();
        }

        public static string firstName = "";
        public static string lastName = "";
        public static string address = "";
        public static string email = "";
        public static string cardNumber = "";
        public static int memberID = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            string name = firstName + " " + lastName;
            address = textBox3.Text;
            email = textBox4.Text;
            cardNumber = textBox5.Text;

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql1 = "SELECT * FROM salyerstheatermember WHERE email = @email";
                MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand(sql1, conn);

                cmd1.Parameters.AddWithValue("@email", email);
                int exists = Convert.ToInt32(cmd1.ExecuteScalar());

                if (exists != 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                    label7.Visible = true;
                }
                else
                {
                    string sql2 = "INSERT INTO salyerstheatermember (name, address, email) VALUES (@name, @address, @email)";
                    MySql.Data.MySqlClient.MySqlCommand cmd2 = new MySql.Data.MySqlClient.MySqlCommand(sql2, conn);
                    cmd2.Parameters.AddWithValue("@name", name);
                    cmd2.Parameters.AddWithValue("@address", address);
                    cmd2.Parameters.AddWithValue("@email", email);
                    cmd2.ExecuteNonQuery();

                    string sql3 = "SELECT * FROM salyerstheatermember ORDER BY memberID DESC LIMIT 1";
                    MySql.Data.MySqlClient.MySqlCommand cmd3 = new MySql.Data.MySqlClient.MySqlCommand(sql3, conn);

                    MySqlDataReader myReader = cmd3.ExecuteReader();

                    if (myReader.Read())
                    {
                        memberID = Convert.ToInt32(myReader["memberID"]);
                    }
                    else
                    {
                        memberID = 1;
                    }
                    myReader.Close();

                    SuccessfulRegister registerSuccess = new SuccessfulRegister();
                    registerSuccess.ShowDialog();

                    this.Close();
                }
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
