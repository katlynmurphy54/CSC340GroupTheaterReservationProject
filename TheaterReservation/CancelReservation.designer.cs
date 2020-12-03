namespace TheaterReservation
{
    partial class CancelReservation
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
            this.cancelResPanel = new System.Windows.Forms.Panel();
            this.errorMessage = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.confirmationNumTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resFoundPanel = new System.Windows.Forms.Panel();
            this.cancel_message = new System.Windows.Forms.Label();
            this.confirmCancelBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.eventTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelResPanel.SuspendLayout();
            this.resFoundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cancel Reservation";
            // 
            // cancelResPanel
            // 
            this.cancelResPanel.Controls.Add(this.errorMessage);
            this.cancelResPanel.Controls.Add(this.searchBtn);
            this.cancelResPanel.Controls.Add(this.confirmationNumTextbox);
            this.cancelResPanel.Controls.Add(this.label2);
            this.cancelResPanel.Controls.Add(this.label1);
            this.cancelResPanel.Location = new System.Drawing.Point(23, 173);
            this.cancelResPanel.Name = "cancelResPanel";
            this.cancelResPanel.Size = new System.Drawing.Size(401, 164);
            this.cancelResPanel.TabIndex = 1;
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(172, 95);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(0, 17);
            this.errorMessage.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(154, 115);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmationNumTextbox
            // 
            this.confirmationNumTextbox.Location = new System.Drawing.Point(175, 57);
            this.confirmationNumTextbox.Name = "confirmationNumTextbox";
            this.confirmationNumTextbox.Size = new System.Drawing.Size(127, 22);
            this.confirmationNumTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirmation Number:";
            // 
            // resFoundPanel
            // 
            this.resFoundPanel.Controls.Add(this.cancel_message);
            this.resFoundPanel.Controls.Add(this.confirmCancelBtn);
            this.resFoundPanel.Controls.Add(this.label6);
            this.resFoundPanel.Controls.Add(this.dateTextBox);
            this.resFoundPanel.Controls.Add(this.eventTextbox);
            this.resFoundPanel.Controls.Add(this.label5);
            this.resFoundPanel.Controls.Add(this.label4);
            this.resFoundPanel.Location = new System.Drawing.Point(461, 31);
            this.resFoundPanel.Name = "resFoundPanel";
            this.resFoundPanel.Size = new System.Drawing.Size(263, 306);
            this.resFoundPanel.TabIndex = 2;
            // 
            // cancel_message
            // 
            this.cancel_message.AutoSize = true;
            this.cancel_message.Location = new System.Drawing.Point(61, 271);
            this.cancel_message.Name = "cancel_message";
            this.cancel_message.Size = new System.Drawing.Size(153, 17);
            this.cancel_message.TabIndex = 8;
            this.cancel_message.Text = "Cancellation Confirmed";
            // 
            // confirmCancelBtn
            // 
            this.confirmCancelBtn.Location = new System.Drawing.Point(76, 205);
            this.confirmCancelBtn.Name = "confirmCancelBtn";
            this.confirmCancelBtn.Size = new System.Drawing.Size(116, 49);
            this.confirmCancelBtn.TabIndex = 5;
            this.confirmCancelBtn.Text = "Confirm Cancellation";
            this.confirmCancelBtn.UseVisualStyleBackColor = true;
            this.confirmCancelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(88, 142);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(124, 22);
            this.dateTextBox.TabIndex = 3;
            // 
            // eventTextbox
            // 
            this.eventTextbox.Location = new System.Drawing.Point(89, 81);
            this.eventTextbox.Name = "eventTextbox";
            this.eventTextbox.Size = new System.Drawing.Size(124, 22);
            this.eventTextbox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Event:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reservation Found";
            // 
            // CancelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 524);
            this.Controls.Add(this.resFoundPanel);
            this.Controls.Add(this.cancelResPanel);
            this.Name = "CancelReservation";
            this.Text = "Lexington Theatre ";
            this.cancelResPanel.ResumeLayout(false);
            this.cancelResPanel.PerformLayout();
            this.resFoundPanel.ResumeLayout(false);
            this.resFoundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel cancelResPanel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox confirmationNumTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel resFoundPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button confirmCancelBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox eventTextbox;
        private System.Windows.Forms.Label cancel_message;
        private System.Windows.Forms.Label errorMessage;
    }
}

