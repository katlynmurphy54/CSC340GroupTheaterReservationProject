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

        private void button1_Click(object sender, EventArgs e)
        {
        //hello world!
            firstName = textBox1.Text;
            lastName = textBox2.Text;
            address = textBox3.Text;
            email = textBox4.Text;
            cardNumber = textBox5.Text;

            SuccessfulRegister registerSuccess = new SuccessfulRegister();
            registerSuccess.ShowDialog();
        }
    }
}
