using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace TheaterReservation
{

    public partial class Payment : Form
    {
        reservation makePayment = new reservation();

        public Payment(String seats, int price, String eventName, String eventDate)
        {
            InitializeComponent();
            //making labels not seen and setting price/seats
            nonMemConfirm.Visible = false;
            nonMemOrderNum.Visible = false;
            memberConfirm.Visible = false; ;
            memberConfirmNumber.Visible = false;
            nonMemPrice.Visible = false;
            nonMemSeat.Visible = false;
            memSeats.Visible = false;
            memPrice.Visible = false;
            makePayment.setSeat(seats + " ");
            makePayment.setPrice(price);
            makePayment.setPlay(eventName);
            makePayment.setDate(eventDate);
        }
        //member payment
        private void button2_Click(object sender, EventArgs e)
        {
            memberConfirmNumber.Text = "";
            int i;
            if (!int.TryParse(memIdTextbox.Text, out i) || memIdTextbox.Text.Length == 0)
            {
                memberConfirmNumber.Visible = true;
                memberConfirmNumber.Text = "Please enter a number";
            }
            else
            {
                int result = Int32.Parse(memIdTextbox.Text);
                memberConfirmNumber.Visible = true;
                if (makePayment.checkMembership(result))
                {
                    memberConfirmNumber.Text = "Found";
                    makePayment.setMemberID(result);
                    makePayment.confirmOrderMember(makePayment.getPlay());
                    memberConfirm.Visible = true;
                    memberConfirmNumber.Text = "Your Confirmation Number Is: " + makePayment.getConfirmNum();

                    nonMemPanel.Visible = false;
                    usedSavePayBtn.Visible = false;
                    memSeats.Visible = true;
                    memPrice.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    memPrice.Text = "Total: $" + (makePayment.gettPrice() - (makePayment.gettPrice() * .10));
                    memSeats.Text = ("Your Seats Are: " + makePayment.getSeat());
                    label8.Text = (makePayment.gettPrice() * .10).ToString();
                }
                else
                {
                    memberConfirmNumber.Text = "Account not found";
                }
            }
        }
        //non-member payment
        private void button1_Click(object sender, EventArgs e)
        {
            label14.Text = "";
            //checking card number
            int i;
            long j;
            if (!long.TryParse(cardNumberTextBox.Text, out j))
            {
                label14.Text = "Please enter a number";
                return;
            }
            if (cardNumberTextBox.Text.Length != 16)
            {
                label14.Text = "Please enter a 16 digit number for card";
                return;
            }
            //checking exp date
            if (!int.TryParse(expDateBox.Text, out i))
            {
                label14.Text = "Please enter a number ";
                return;
            }
            //checking security code
            if (!int.TryParse(secCodeTextbox.Text, out i))
            {
                label14.Text = "Please enter a number";
                return;
            }
            if (secCodeTextbox.Text.Length != 3)
            {
                label14.Text = "Please enter a 3 digit number for Security Code";
                return;
            }

            memPanel.Visible = false;
            nonMemConfirmButton.Visible = false;
            nonMemConfirm.Visible = true;
            nonMemOrderNum.Visible = true;
            nonMemPrice.Visible = true;
            nonMemSeat.Visible = true;
            nonMemPrice.Text = "Total: $" + (makePayment.gettPrice());
            nonMemSeat.Text = ("Your Seats Are: " + makePayment.getSeat());
            makePayment.confirmOrder(makePayment.getPlay());
            nonMemOrderNum.Text = ("Your Confirmation Number Is: " + makePayment.getConfirmNum());

        }


        public class reservation
        {
            private String the_Event;
            private int confirmNum;
            private String date;
            private int memberID;
            private String seat;
            private double price;
            private String play;
            public reservation()
            {

            }
            public Boolean checkMembership(int x)
            {
                String tester = "";
                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try

                {
                    conn.Open();
                    string sql = "SELECT * FROM salyerstheatermember WHERE memberID = @x";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@x", x);
                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        tester = (myReader["memberID"].ToString());

                    }
                    myReader.Close();
                }


                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();

                //testing if if anything came back
                if (tester.Length == 0)
                {
                    return false;
                }
                //getting the confirmation number
                try
                {
                    String converter = "";

                    conn.Open();
                    string sql = "SELECT * FROM salyerstheaterreservation ORDER BY confirmationNum DESC ";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        converter = myReader["confirmationNum"].ToString();
                        setConfirmNum(Int32.Parse(converter));

                    }
                    myReader.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();


                return true;

            }
            public void confirmOrderMember(String play)
            {
                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try

                {
                    conn.Open();
                    string sql = "INSERT INTO salyerstheaterreservation (event, date, memberID, seats)" +
                        " VALUES (@event, @date, @memberID, @seats)";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@event", play);
                    cmd.Parameters.AddWithValue("@date", getDate());
                    cmd.Parameters.AddWithValue("@memberID", getMemberID());
                    cmd.Parameters.AddWithValue("@seats", getSeat());
                    cmd.ExecuteNonQuery();

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
                try

                {
                    String converter = "";

                    conn.Open();
                    string sql = "SELECT * FROM salyerstheaterreservation ORDER BY confirmationNum DESC ";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        converter = myReader["confirmationNum"].ToString();
                        setConfirmNum(Int32.Parse(converter));

                    }
                    myReader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
            }
            public void confirmOrder(String play)
            {
                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try

                {
                    conn.Open();
                    string sql = "INSERT INTO salyerstheaterreservation (event, date, seats)" +
                        " VALUES (@event, @date, @seats)";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@event", play);
                    cmd.Parameters.AddWithValue("@date", getDate());
                    cmd.Parameters.AddWithValue("@seats", getSeat());
                    cmd.ExecuteNonQuery();

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();
                try
                {
                    String converter = "";

                    conn.Open();
                    string sql = "SELECT * FROM salyerstheaterreservation ORDER BY confirmationNum DESC ";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if (myReader.Read())
                    {
                        converter = myReader["confirmationNum"].ToString();
                        setConfirmNum(Int32.Parse(converter));

                    }
                    myReader.Close();
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
            public void setPrice(int x)
            {
                this.price = x;
            }
            public void setPlay(String x)
            {
                this.play = x;
            }
            public String getPlay()
            {
                return play; 
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
            public double gettPrice()
            {
                return price;
            }

        }

    }
}


