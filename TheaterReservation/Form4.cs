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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 makeReservation = new Form5();
            makeReservation.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 allEvents = new Form8();
            allEvents.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 registerAccount = new Form2();
            registerAccount.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 cancelReservation = new Form7();
            cancelReservation.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 manageAccount = new Form11();
            manageAccount.ShowDialog();
        }
    }
}
