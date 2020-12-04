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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            string validemail = "";
            string validmemberID = "";

            string constr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
            MySqlConnection con = new MySqlConnection(constr);

            try
            {
                Console.WriteLine("Connecting to MySQL...");
                con.Open();

                string str = "SELECT * FROM salyerstheatermember WHERE email = @email AND memberID = @memberID";
                MySqlCommand cmd = new MySqlCommand(str, con);
                
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@memberID", textBox2.Text);
                
                MySqlDataReader da = cmd.ExecuteReader();

                if (da.Read())
                {
                    validemail = da["email"].ToString();
                    validmemberID = da["memberID"].ToString();
                }

                da.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            con.Close();



            if (textBox1.Text == validemail && textBox2.Text == validmemberID)
            {
                UpdateAccount.memberID = Convert.ToInt32(validmemberID);

                UpdateAccount changeInformation = new UpdateAccount();
                changeInformation.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful! Please try again.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
