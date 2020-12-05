using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TheaterReservation
{
    public partial class CancelReservation : Form
    {
        reservation cancelRes = new reservation();
        public CancelReservation()
        {

            InitializeComponent();
            resFoundPanel.Visible = false;
            cancel_message.Visible = false;
        }

        //button1Click is for starting search
        private void button1_Click(object sender, EventArgs e)
        {
            //clearing text field on another search
            errorMessage.Text = "";
            cancel_message.Visible = false;
            resFoundPanel.Visible = false;
            //testing for ints
            int i;
            if (!int.TryParse(confirmationNumTextbox.Text, out i))
            {
                errorMessage.Text = "Please enter a number";
            }
            else
            {
                int result = Int32.Parse(confirmationNumTextbox.Text);
                cancelRes.setConfirmNum(result);
                //makes call and returns boolean if res exists
                if (cancelRes.checkRes(cancelRes.getConfirmNum()))
                {
                    //checking to make sure they give at least 2 days notice
                    TimeSpan ts = DateTime.Parse(cancelRes.getDate()).Subtract(DateTime.Now);
                    int daysBefore = ts.Days + 1;
                    if (daysBefore < 2)
                    {
                        errorMessage.Text = "Cannot cancel, you must \n give at least 2 days notice \n before canceling reservation";
                        return;

                    }
                    resFoundPanel.Visible = true;
                    dateTextBox.Text = cancelRes.getDate();
                    eventTextbox.Text = cancelRes.getEvent();
                }
                else
                {

                    resFoundPanel.Visible = false;
                    errorMessage.Text = "Reservation not found";
                }
            }
        }
        //will be for confirming the cancel
        private void button2_Click(object sender, EventArgs e)
        {

            cancelRes.deleteRes(cancelRes.getConfirmNum());
            cancel_message.Visible = true;

        }

        public class reservation
        {
            private String the_Event;
            private int confirmNum;
            private String date;
            private int memberID;
            private String seat;
            public reservation()
            {
            }
            public Boolean checkRes(int x)
            {
                String tester = "";
                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try

                {
                    conn.Open();
                    string sql = "SELECT * FROM salyerstheaterreservation WHERE confirmationNum = @x";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@x", x);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        tester = (myReader["date"].ToString());
                        setDate(myReader["date"].ToString());
                        setEvent(myReader["event"].ToString());
                    }
                    myReader.Close();
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
                if (tester.Length == 0)
                {
                    return false;
                }
                return true;

            }

            public void deleteRes(int x)
            {
                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try

                {
                    conn.Open();
                    string sql = "Delete FROM salyerstheaterreservation WHERE confirmationNum = @x";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@x", x);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();

            }

            public void setConfirmNum(int x)
            {
                this.confirmNum = x;
            }
            public void setEvent(String x)
            {
                this.the_Event = x;
            }
            public void setDate(String x)
            {
                this.date = x;
            }
            public void setMemberID(int x)
            {
                this.memberID = x;
            }
            public void setSeat(String x)
            {
                this.seat = x;
            }

            public int getConfirmNum()
            {
                return confirmNum;
            }
            public String getEvent()
            {
                return the_Event;
            }
            public String getDate()
            {
                return date;
            }
            public int getMemberID()
            {
                return memberID;
            }
            public String getSeat()
            {
                return seat;
            }

        }

        
    }
}
