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
    public partial class EventInfo : Form
    {

        public static String eventType = "";


        public EventInfo()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (eventType == "Hamilton")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources._091019_Hamilton_JoanMarcus_02;
                label10.Text = "December 4th";
                label8.Text = "Featuring Daveed Diggs and Jonathan Groff, this musical is coming" +
                    "\nto Lexington for 1 night only from December 4th through December 6th!" +
                    "\nGeneral Pricing: $59.99 per ticket " +
                    "\nVIP Pricing: $49.99 per ticket " +
                    "\nMax: 4 tickets per person";
            }
            else if (eventType == "Wizard of Oz")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources.a0d0217a_79bd_47b4_b894_531f31e504e1;
                label10.Text = "December 18th";
                label8.Text = "Featuring Lucy Durack and Samantha Dodemaide, this musical is coming" +
                    "\nto Lexington for 1 night only from December 18th through December 20th!" +
                    "\nGeneral Pricing: $39.99 per ticket " +
                    "\nVIP Pricing: $29.99 per ticket " +
                    "\nMax: 4 tickets per person";
            }
            else if (eventType == "Romeo and Juliet")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources._0727_romeojuliet;
                label10.Text = "December 25th";
                label8.Text = "Featuring Orlando Bloom and Condola Rashad, this musical is coming" +
                    "\nto Lexington for 1 night only from December 25th through December 27th!" +
                    "\nGeneral Pricing: $49.99 per ticket " +
                    "\nVIP Pricing: $39.99 per ticket " +
                    "\nMax: 4 tickets per person";
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (eventType == "Hamilton")
            {
                ReserveSeats addseats = new ReserveSeats();
                addseats.eventName = eventType;
                addseats.eventDate = "December 4th";
                addseats.ShowDialog();
            }
            else if (eventType == "Wizard of Oz")
            {
                ReserveSeats addseats = new ReserveSeats();
                addseats.eventName = eventType;
                addseats.eventDate = "December 18th";
                addseats.ShowDialog();
            }
            else if (eventType == "Romeo and Juliet")
            {
                ReserveSeats addseats = new ReserveSeats();
                addseats.eventName = eventType;
                addseats.eventDate = "December 25th";
                addseats.ShowDialog();
            }
        }
    }
}
