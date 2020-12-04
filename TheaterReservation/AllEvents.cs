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
    public partial class AllEvents : Form
    {
        public AllEvents()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //hamilton
            EventInfo moreInformation = new EventInfo();
            EventInfo.eventType = "Hamilton";
            moreInformation.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //wizard of oz
            EventInfo moreInformation = new EventInfo();
            EventInfo.eventType = "Wizard of Oz";
            moreInformation.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //romeo and juliet
            EventInfo moreInformation = new EventInfo();
            EventInfo.eventType = "Romeo and Juliet";
            moreInformation.ShowDialog();
        }
    }
}
