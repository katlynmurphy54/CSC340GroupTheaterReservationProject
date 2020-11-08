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
    public partial class ReserveSeats : Form
    {
        public ReserveSeats()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Payment makePayment = new Payment();
            makePayment.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
