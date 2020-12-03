namespace TheaterReservation
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nonMemPanel = new System.Windows.Forms.Panel();
            this.nonMemSeat = new System.Windows.Forms.Label();
            this.nonMemPrice = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nonMemOrderNum = new System.Windows.Forms.Label();
            this.nonMemConfirm = new System.Windows.Forms.Label();
            this.nonMemConfirmButton = new System.Windows.Forms.Button();
            this.secCodeTextbox = new System.Windows.Forms.TextBox();
            this.expDateBox = new System.Windows.Forms.TextBox();
            this.cardNumberTextBox = new System.Windows.Forms.TextBox();
            this.lNameTextbox = new System.Windows.Forms.TextBox();
            this.fNameTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usedSavePayBtn = new System.Windows.Forms.Button();
            this.memPanel = new System.Windows.Forms.Panel();
            this.memSeats = new System.Windows.Forms.Label();
            this.memPrice = new System.Windows.Forms.Label();
            this.memberConfirmNumber = new System.Windows.Forms.Label();
            this.memberConfirm = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.memIdTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nonMemPanel.SuspendLayout();
            this.memPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Details";
            // 
            // nonMemPanel
            // 
            this.nonMemPanel.Controls.Add(this.nonMemSeat);
            this.nonMemPanel.Controls.Add(this.nonMemPrice);
            this.nonMemPanel.Controls.Add(this.label14);
            this.nonMemPanel.Controls.Add(this.nonMemOrderNum);
            this.nonMemPanel.Controls.Add(this.nonMemConfirm);
            this.nonMemPanel.Controls.Add(this.nonMemConfirmButton);
            this.nonMemPanel.Controls.Add(this.secCodeTextbox);
            this.nonMemPanel.Controls.Add(this.expDateBox);
            this.nonMemPanel.Controls.Add(this.cardNumberTextBox);
            this.nonMemPanel.Controls.Add(this.lNameTextbox);
            this.nonMemPanel.Controls.Add(this.fNameTextbox);
            this.nonMemPanel.Controls.Add(this.label6);
            this.nonMemPanel.Controls.Add(this.label5);
            this.nonMemPanel.Controls.Add(this.label4);
            this.nonMemPanel.Controls.Add(this.label3);
            this.nonMemPanel.Controls.Add(this.label2);
            this.nonMemPanel.Controls.Add(this.label1);
            this.nonMemPanel.Location = new System.Drawing.Point(69, 43);
            this.nonMemPanel.Name = "nonMemPanel";
            this.nonMemPanel.Size = new System.Drawing.Size(468, 522);
            this.nonMemPanel.TabIndex = 1;
            // 
            // nonMemSeat
            // 
            this.nonMemSeat.AutoSize = true;
            this.nonMemSeat.Location = new System.Drawing.Point(192, 399);
            this.nonMemSeat.Name = "nonMemSeat";
            this.nonMemSeat.Size = new System.Drawing.Size(44, 17);
            this.nonMemSeat.TabIndex = 18;
            this.nonMemSeat.Text = "Seats";
            // 
            // nonMemPrice
            // 
            this.nonMemPrice.AutoSize = true;
            this.nonMemPrice.Location = new System.Drawing.Point(192, 373);
            this.nonMemPrice.Name = "nonMemPrice";
            this.nonMemPrice.Size = new System.Drawing.Size(44, 17);
            this.nonMemPrice.TabIndex = 17;
            this.nonMemPrice.Text = "Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 17);
            this.label14.TabIndex = 16;
            // 
            // nonMemOrderNum
            // 
            this.nonMemOrderNum.AutoSize = true;
            this.nonMemOrderNum.Location = new System.Drawing.Point(192, 345);
            this.nonMemOrderNum.Name = "nonMemOrderNum";
            this.nonMemOrderNum.Size = new System.Drawing.Size(131, 17);
            this.nonMemOrderNum.TabIndex = 15;
            this.nonMemOrderNum.Text = "Order Number: 321";
            // 
            // nonMemConfirm
            // 
            this.nonMemConfirm.AutoSize = true;
            this.nonMemConfirm.Location = new System.Drawing.Point(192, 317);
            this.nonMemConfirm.Name = "nonMemConfirm";
            this.nonMemConfirm.Size = new System.Drawing.Size(116, 17);
            this.nonMemConfirm.TabIndex = 14;
            this.nonMemConfirm.Text = "Order Confirmed!";
            // 
            // nonMemConfirmButton
            // 
            this.nonMemConfirmButton.Location = new System.Drawing.Point(205, 443);
            this.nonMemConfirmButton.Name = "nonMemConfirmButton";
            this.nonMemConfirmButton.Size = new System.Drawing.Size(101, 79);
            this.nonMemConfirmButton.TabIndex = 12;
            this.nonMemConfirmButton.Text = "Confirm Order";
            this.nonMemConfirmButton.UseVisualStyleBackColor = true;
            this.nonMemConfirmButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // secCodeTextbox
            // 
            this.secCodeTextbox.Location = new System.Drawing.Point(205, 257);
            this.secCodeTextbox.Name = "secCodeTextbox";
            this.secCodeTextbox.Size = new System.Drawing.Size(157, 22);
            this.secCodeTextbox.TabIndex = 9;
            // 
            // expDateBox
            // 
            this.expDateBox.Location = new System.Drawing.Point(205, 213);
            this.expDateBox.Name = "expDateBox";
            this.expDateBox.Size = new System.Drawing.Size(157, 22);
            this.expDateBox.TabIndex = 8;
            // 
            // cardNumberTextBox
            // 
            this.cardNumberTextBox.Location = new System.Drawing.Point(205, 174);
            this.cardNumberTextBox.Name = "cardNumberTextBox";
            this.cardNumberTextBox.Size = new System.Drawing.Size(157, 22);
            this.cardNumberTextBox.TabIndex = 7;
            // 
            // lNameTextbox
            // 
            this.lNameTextbox.Location = new System.Drawing.Point(205, 134);
            this.lNameTextbox.Name = "lNameTextbox";
            this.lNameTextbox.Size = new System.Drawing.Size(157, 22);
            this.lNameTextbox.TabIndex = 6;
            // 
            // fNameTextbox
            // 
            this.fNameTextbox.Location = new System.Drawing.Point(205, 93);
            this.fNameTextbox.Name = "fNameTextbox";
            this.fNameTextbox.Size = new System.Drawing.Size(157, 22);
            this.fNameTextbox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Security Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Expiration Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // usedSavePayBtn
            // 
            this.usedSavePayBtn.Location = new System.Drawing.Point(128, 254);
            this.usedSavePayBtn.Name = "usedSavePayBtn";
            this.usedSavePayBtn.Size = new System.Drawing.Size(101, 79);
            this.usedSavePayBtn.TabIndex = 13;
            this.usedSavePayBtn.Text = "Use Saved Payment";
            this.usedSavePayBtn.UseVisualStyleBackColor = true;
            this.usedSavePayBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // memPanel
            // 
            this.memPanel.Controls.Add(this.memSeats);
            this.memPanel.Controls.Add(this.memPrice);
            this.memPanel.Controls.Add(this.memberConfirmNumber);
            this.memPanel.Controls.Add(this.memberConfirm);
            this.memPanel.Controls.Add(this.label13);
            this.memPanel.Controls.Add(this.label12);
            this.memPanel.Controls.Add(this.usedSavePayBtn);
            this.memPanel.Controls.Add(this.label11);
            this.memPanel.Controls.Add(this.memIdTextbox);
            this.memPanel.Controls.Add(this.label10);
            this.memPanel.Location = new System.Drawing.Point(557, 44);
            this.memPanel.Name = "memPanel";
            this.memPanel.Size = new System.Drawing.Size(329, 344);
            this.memPanel.TabIndex = 2;
            // 
            // memSeats
            // 
            this.memSeats.AutoSize = true;
            this.memSeats.Location = new System.Drawing.Point(14, 202);
            this.memSeats.Name = "memSeats";
            this.memSeats.Size = new System.Drawing.Size(44, 17);
            this.memSeats.TabIndex = 21;
            this.memSeats.Text = "Seats";
            // 
            // memPrice
            // 
            this.memPrice.AutoSize = true;
            this.memPrice.Location = new System.Drawing.Point(14, 173);
            this.memPrice.Name = "memPrice";
            this.memPrice.Size = new System.Drawing.Size(44, 17);
            this.memPrice.TabIndex = 20;
            this.memPrice.Text = "Price:";
            // 
            // memberConfirmNumber
            // 
            this.memberConfirmNumber.AutoSize = true;
            this.memberConfirmNumber.Location = new System.Drawing.Point(14, 147);
            this.memberConfirmNumber.Name = "memberConfirmNumber";
            this.memberConfirmNumber.Size = new System.Drawing.Size(120, 17);
            this.memberConfirmNumber.TabIndex = 19;
            this.memberConfirmNumber.Text = "Confimration Num";
            // 
            // memberConfirm
            // 
            this.memberConfirm.AutoSize = true;
            this.memberConfirm.Location = new System.Drawing.Point(89, 120);
            this.memberConfirm.Name = "memberConfirm";
            this.memberConfirm.Size = new System.Drawing.Size(116, 17);
            this.memberConfirm.TabIndex = 17;
            this.memberConfirm.Text = "Order Confirmed!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(263, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Just Enter Your ID For Speedy Checkout";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Already A Member?  ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 17);
            this.label11.TabIndex = 14;
            // 
            // memIdTextbox
            // 
            this.memIdTextbox.Location = new System.Drawing.Point(156, 95);
            this.memIdTextbox.Name = "memIdTextbox";
            this.memIdTextbox.Size = new System.Drawing.Size(157, 22);
            this.memIdTextbox.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Member ID:";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 652);
            this.Controls.Add(this.memPanel);
            this.Controls.Add(this.nonMemPanel);
            this.Name = "Payment";
            this.Text = "Payment Details";
            this.nonMemPanel.ResumeLayout(false);
            this.nonMemPanel.PerformLayout();
            this.memPanel.ResumeLayout(false);
            this.memPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel nonMemPanel;
        private System.Windows.Forms.TextBox expDateBox;
        private System.Windows.Forms.TextBox cardNumberTextBox;
        private System.Windows.Forms.TextBox lNameTextbox;
        private System.Windows.Forms.TextBox fNameTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button usedSavePayBtn;
        private System.Windows.Forms.Button nonMemConfirmButton;
        private System.Windows.Forms.TextBox secCodeTextbox;
        private System.Windows.Forms.Label nonMemOrderNum;
        private System.Windows.Forms.Label nonMemConfirm;
        private System.Windows.Forms.Panel memPanel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox memIdTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label memberConfirm;
        private System.Windows.Forms.Label memberConfirmNumber;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label nonMemSeat;
        private System.Windows.Forms.Label nonMemPrice;
        private System.Windows.Forms.Label memSeats;
        private System.Windows.Forms.Label memPrice;
    }
}
