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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReserveSeats makeReservation = new ReserveSeats();
            //from main menu reservation set to peter pan
            makeReservation.eventName = "Peter Pan";
            makeReservation.eventDate = "2020-10-02";
            //if they reset the seats from main menu reservation set back to peter pan
            EventInfo.eventType = "Peter Pan";
            EventInfo.eventDate = "2020-10-02";
            makeReservation.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllEvents allEvents = new AllEvents();
            allEvents.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountRegister registerAccount = new AccountRegister();
            registerAccount.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CancelReservation cancelReservation = new CancelReservation();
            cancelReservation.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login loginInfo = new Login();
            loginInfo.ShowDialog();
        }
    }
}
