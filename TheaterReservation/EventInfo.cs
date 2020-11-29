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

        public String eventType = "";


        public EventInfo()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            label2.Visible = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (eventType == "Hamilton")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources._091019_Hamilton_JoanMarcus_02;
                label10.Text = "December 4-6";
                label8.Text = "Featuring Daveed Diggs and Jonathan Groff, this musical is coming" +
                    "\nto Lexington for 3 nights only from December 4th through December 6th!" +
                    "\nGeneral Pricing: $59.99 per ticket " +
                    "\nVIP Pricing: $49.99 per ticket " +
                    "\nMax: 4 tickets per person";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("December 4th, 2020");
                comboBox1.Items.Add("December 5th, 2020");
                comboBox1.Items.Add("December 6th, 2020");
            }
            else if (eventType == "Wizard of Oz")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources.a0d0217a_79bd_47b4_b894_531f31e504e1;
                label10.Text = "December 18-20";
                label8.Text = "Featuring Lucy Durack and Samantha Dodemaide, this musical is coming" +
                    "\nto Lexington for 3 nights only from December 18th through December 20th!" +
                    "\nGeneral Pricing: $39.99 per ticket " +
                    "\nVIP Pricing: $29.99 per ticket " +
                    "\nMax: 4 tickets per person";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("December 18th, 2020");
                comboBox1.Items.Add("December 19th, 2020");
                comboBox1.Items.Add("December 20th, 2020");
            }
            else if (eventType == "Romeo and Juliet")
            {
                label1.Text = eventType;
                pictureBox4.Image = TheaterReservation.Properties.Resources._0727_romeojuliet;
                label10.Text = "December 25-27";
                label8.Text = "Featuring Orlando Bloom and Condola Rashad, this musical is coming" +
                    "\nto Lexington for 3 nights only from December 25th through December 27th!" +
                    "\nGeneral Pricing: $49.99 per ticket " +
                    "\nVIP Pricing: $39.99 per ticket " +
                    "\nMax: 4 tickets per person";
                comboBox1.Items.Clear();
                comboBox1.Items.Add("December 25th, 2020");
                comboBox1.Items.Add("December 26th, 2020");
                comboBox1.Items.Add("December 27th, 2020");
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedDate = comboBox1.SelectedItem;

            if (eventType == "Hamilton")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
            }
            else if (eventType == "Wizard of Oz")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
            }
            else if (eventType == "Romeo and Juliet")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label2.Text = "Seating Availability for " + selectedDate.ToString() + ":";
                    label2.Visible = true;
                    pictureBox1.Visible = true;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
