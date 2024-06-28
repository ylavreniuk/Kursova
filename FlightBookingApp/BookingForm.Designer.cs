namespace FlightBookingApp
{
    partial class BookingForm
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
            this.flightInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passengerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ticketCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.confirmButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ticketCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flightInfoLabel
            // 
            this.flightInfoLabel.AutoSize = true;
            this.flightInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.flightInfoLabel.Name = "flightInfoLabel";
            this.flightInfoLabel.Size = new System.Drawing.Size(35, 13);
            this.flightInfoLabel.TabIndex = 0;
            this.flightInfoLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ПІБ";
            // 
            // passengerNameTextBox
            // 
            this.passengerNameTextBox.Location = new System.Drawing.Point(12, 50);
            this.passengerNameTextBox.Name = "passengerNameTextBox";
            this.passengerNameTextBox.Size = new System.Drawing.Size(216, 20);
            this.passengerNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер паспорту";
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Location = new System.Drawing.Point(246, 50);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(153, 20);
            this.passportNumberTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "К-ть квитків";
            // 
            // ticketCountNumericUpDown
            // 
            this.ticketCountNumericUpDown.Location = new System.Drawing.Point(419, 50);
            this.ticketCountNumericUpDown.Name = "ticketCountNumericUpDown";
            this.ticketCountNumericUpDown.Size = new System.Drawing.Size(86, 20);
            this.ticketCountNumericUpDown.TabIndex = 3;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(527, 48);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 4;
            this.confirmButton.Text = "Ок";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(608, 48);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 104);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.ticketCountNumericUpDown);
            this.Controls.Add(this.passportNumberTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passengerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightInfoLabel);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронювання квитка";
            ((System.ComponentModel.ISupportInitialize)(this.ticketCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flightInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passengerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passportNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ticketCountNumericUpDown;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button exitButton;
    }
}