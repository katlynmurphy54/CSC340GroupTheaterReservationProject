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
        public static String eventDate = "";


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
                label10.Text = "December 4th, 2020";
                label8.Text = "Featuring Daveed Diggs and Jonathan Groff, this musical is coming" +
                    "\nto Lexington for 1 night only on December 4th!" +
                    "\nGeneral Pricing: $50.00 per ticket " +
                    "\nVIP Pricing: $35.00 per ticket " +
                    "\nMax: 4 tickets per person";
                eventDate = "2020-12-04";
            }
            else if (eventType == "Wizard of Oz")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources.a0d0217a_79bd_47b4_b894_531f31e504e1;
                label10.Text = "December 18th, 2020";
                label8.Text = "Featuring Lucy Durack and Samantha Dodemaide, this musical is coming" +
                    "\nto Lexington for 1 night only on December 18th!" +
                    "\nGeneral Pricing: $50.00 per ticket " +
                    "\nVIP Pricing: $35.00 per ticket " +
                    "\nMax: 4 tickets per person";
                eventDate = "2020-12-18";
            }
            else if (eventType == "Romeo and Juliet")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources._0727_romeojuliet;
                label10.Text = "December 25th, 2020";
                label8.Text = "Featuring Orlando Bloom and Condola Rashad, this musical is coming" +
                    "\nto Lexington for 1 night only on December 25th!" +
                    "\nGeneral Pricing: $50.00 per ticket " +
                    "\nVIP Pricing: $35.00 per ticket " +
                    "\nMax: 4 tickets per person";
                eventDate = "2020-12-25";
            }
            else if (eventType == "Peter Pan")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources.peterpan__1_;
                label10.Text = "October 2nd, 2020";
                label8.Text = "Featuring Cathy Rigby and Ryan Francis, this musical is coming" +
                    "\nto Lexington for 1 night only on October 2nd!" +
                    "\nGeneral Pricing: $50.00 per ticket " +
                    "\nVIP Pricing: $35.00 per ticket " +
                    "\nMax: 4 tickets per person";
                eventDate = "2020-10-02";
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
                addseats.eventDate = eventDate;
                addseats.ShowDialog();
            }
            else if (eventType == "Wizard of Oz")
            {
                ReserveSeats addseats = new ReserveSeats();
                addseats.eventName = eventType;
                addseats.eventDate = eventDate;
                addseats.ShowDialog();
            }
            else if (eventType == "Romeo and Juliet")
            {
                ReserveSeats addseats = new ReserveSeats();
                addseats.eventName = eventType;
                addseats.eventDate = eventDate;
                addseats.ShowDialog();
            }
            else if (eventType == "Peter Pan")
            {
                ReserveSeats addseats = new ReserveSeats();
                addseats.eventName = eventType;
                addseats.eventDate = eventDate;
                addseats.ShowDialog();
            }
        }
    }
}
