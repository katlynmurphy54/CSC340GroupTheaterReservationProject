using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheaterReservation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.firstName;
            textBox2.Text = Form2.lastName;
            textBox3.Text = Form2.address;
            textBox4.Text = Form2.email;
            textBox5.Text = Form2.cardNumber;
        }
    }
}
