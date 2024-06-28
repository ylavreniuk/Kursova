namespace FlightBookingApp
{
    partial class FlightForm
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
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.airlineTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.departureComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalComboBox = new System.Windows.Forms.ComboBox();
            this.flightDaysCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.departureTimeComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalTimeComboBox = new System.Windows.Forms.ComboBox();
            this.availableSeatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ticketPriceTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.stopoversTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.airlineComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.availableSeatsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер рейсу";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.Location = new System.Drawing.Point(125, 45);
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(119, 20);
            this.flightNumberTextBox.TabIndex = 1;
            this.flightNumberTextBox.TextChanged += new System.EventHandler(this.flightNumberTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Назва авіакомпаніі";
            // 
            // airlineTextBox
            // 
            this.airlineTextBox.Location = new System.Drawing.Point(125, 75);
            this.airlineTextBox.Name = "airlineTextBox";
            this.airlineTextBox.Size = new System.Drawing.Size(119, 20);
            this.airlineTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Відправлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Прибуття";
            // 
            // departureComboBox
            // 
            this.departureComboBox.FormattingEnabled = true;
            this.departureComboBox.Location = new System.Drawing.Point(125, 104);
            this.departureComboBox.Name = "departureComboBox";
            this.departureComboBox.Size = new System.Drawing.Size(121, 21);
            this.departureComboBox.TabIndex = 2;
            // 
            // arrivalComboBox
            // 
            this.arrivalComboBox.FormattingEnabled = true;
            this.arrivalComboBox.Location = new System.Drawing.Point(124, 136);
            this.arrivalComboBox.Name = "arrivalComboBox";
            this.arrivalComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalComboBox.TabIndex = 2;
            // 
            // flightDaysCheckedListBox
            // 
            this.flightDaysCheckedListBox.FormattingEnabled = true;
            this.flightDaysCheckedListBox.Location = new System.Drawing.Point(125, 198);
            this.flightDaysCheckedListBox.Name = "flightDaysCheckedListBox";
            this.flightDaysCheckedListBox.Size = new System.Drawing.Size(120, 94);
            this.flightDaysCheckedListBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дні відправлення";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Час відправлення";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Час прибуття";
            // 
            // departureTimeComboBox
            // 
            this.departureTimeComboBox.FormattingEnabled = true;
            this.departureTimeComboBox.Location = new System.Drawing.Point(124, 304);
            this.departureTimeComboBox.Name = "departureTimeComboBox";
            this.departureTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.departureTimeComboBox.TabIndex = 2;
            // 
            // arrivalTimeComboBox
            // 
            this.arrivalTimeComboBox.FormattingEnabled = true;
            this.arrivalTimeComboBox.Location = new System.Drawing.Point(124, 331);
            this.arrivalTimeComboBox.Name = "arrivalTimeComboBox";
            this.arrivalTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalTimeComboBox.TabIndex = 2;
            // 
            // availableSeatsNumericUpDown
            // 
            this.availableSeatsNumericUpDown.Location = new System.Drawing.Point(124, 363);
            this.availableSeatsNumericUpDown.Name = "availableSeatsNumericUpDown";
            this.availableSeatsNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.availableSeatsNumericUpDown.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Кількість місць";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Ціна квитка";
            // 
            // ticketPriceTextBox
            // 
            this.ticketPriceTextBox.Location = new System.Drawing.Point(124, 389);
            this.ticketPriceTextBox.Name = "ticketPriceTextBox";
            this.ticketPriceTextBox.Size = new System.Drawing.Size(120, 20);
            this.ticketPriceTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 34);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Збереження";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(147, 427);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Зупинка";
            // 
            // stopoversTextBox
            // 
            this.stopoversTextBox.Location = new System.Drawing.Point(124, 163);
            this.stopoversTextBox.Name = "stopoversTextBox";
            this.stopoversTextBox.Size = new System.Drawing.Size(119, 20);
            this.stopoversTextBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Літак";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // airlineComboBox
            // 
            this.airlineComboBox.FormattingEnabled = true;
            this.airlineComboBox.Location = new System.Drawing.Point(124, 18);
            this.airlineComboBox.Name = "airlineComboBox";
            this.airlineComboBox.Size = new System.Drawing.Size(120, 21);
            this.airlineComboBox.TabIndex = 6;
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 483);
            this.Controls.Add(this.airlineComboBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.availableSeatsNumericUpDown);
            this.Controls.Add(this.flightDaysCheckedListBox);
            this.Controls.Add(this.arrivalTimeComboBox);
            this.Controls.Add(this.departureTimeComboBox);
            this.Controls.Add(this.arrivalComboBox);
            this.Controls.Add(this.departureComboBox);
            this.Controls.Add(this.stopoversTextBox);
            this.Controls.Add(this.airlineTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketPriceTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.flightNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання рейсу";
            ((System.ComponentModel.ISupportInitialize)(this.availableSeatsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox flightNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox airlineTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox departureComboBox;
        private System.Windows.Forms.ComboBox arrivalComboBox;
        private System.Windows.Forms.CheckedListBox flightDaysCheckedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox departureTimeComboBox;
        private System.Windows.Forms.ComboBox arrivalTimeComboBox;
        private System.Windows.Forms.NumericUpDown availableSeatsNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ticketPriceTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox stopoversTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox airlineComboBox;
    }
}