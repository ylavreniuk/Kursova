namespace FlightBookingApp
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.departureComboBox = new System.Windows.Forms.ComboBox();
            this.arrivalComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Дата = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.flightsDataGridView = new System.Windows.Forms.DataGridView();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.bookTicketButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.editFlightButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.viewBoardingPassButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відправлення";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Прибуття";
            // 
            // departureComboBox
            // 
            this.departureComboBox.FormattingEnabled = true;
            this.departureComboBox.Location = new System.Drawing.Point(12, 29);
            this.departureComboBox.Name = "departureComboBox";
            this.departureComboBox.Size = new System.Drawing.Size(121, 21);
            this.departureComboBox.TabIndex = 1;
            // 
            // arrivalComboBox
            // 
            this.arrivalComboBox.FormattingEnabled = true;
            this.arrivalComboBox.Location = new System.Drawing.Point(148, 29);
            this.arrivalComboBox.Name = "arrivalComboBox";
            this.arrivalComboBox.Size = new System.Drawing.Size(121, 21);
            this.arrivalComboBox.TabIndex = 1;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(287, 30);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 2;
            // 
            // Дата
            // 
            this.Дата.AutoSize = true;
            this.Дата.Location = new System.Drawing.Point(367, 9);
            this.Дата.Name = "Дата";
            this.Дата.Size = new System.Drawing.Size(33, 13);
            this.Дата.TabIndex = 0;
            this.Дата.Text = "Дата";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(506, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(121, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Пошук рейсів";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // flightsDataGridView
            // 
            this.flightsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightsDataGridView.Location = new System.Drawing.Point(12, 56);
            this.flightsDataGridView.Name = "flightsDataGridView";
            this.flightsDataGridView.Size = new System.Drawing.Size(1144, 558);
            this.flightsDataGridView.TabIndex = 4;
            // 
            // addFlightButton
            // 
            this.addFlightButton.Location = new System.Drawing.Point(1178, 140);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(177, 23);
            this.addFlightButton.TabIndex = 3;
            this.addFlightButton.Text = "Додавання рейсу";
            this.addFlightButton.UseVisualStyleBackColor = true;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click_1);
            // 
            // bookTicketButton
            // 
            this.bookTicketButton.Location = new System.Drawing.Point(1178, 56);
            this.bookTicketButton.Name = "bookTicketButton";
            this.bookTicketButton.Size = new System.Drawing.Size(177, 23);
            this.bookTicketButton.TabIndex = 3;
            this.bookTicketButton.Text = "Бронювання квитків";
            this.bookTicketButton.UseVisualStyleBackColor = true;
            this.bookTicketButton.Click += new System.EventHandler(this.bookTicketButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1178, 591);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Вихід з програми";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // editFlightButton
            // 
            this.editFlightButton.Location = new System.Drawing.Point(1178, 169);
            this.editFlightButton.Name = "editFlightButton";
            this.editFlightButton.Size = new System.Drawing.Size(177, 23);
            this.editFlightButton.TabIndex = 3;
            this.editFlightButton.Text = "Редагування рейсу";
            this.editFlightButton.UseVisualStyleBackColor = true;
            this.editFlightButton.Click += new System.EventHandler(this.editFlightButton_Click_1);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.Location = new System.Drawing.Point(1178, 198);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(177, 23);
            this.deleteFlightButton.TabIndex = 3;
            this.deleteFlightButton.Text = "Видалення рейсу";
            this.deleteFlightButton.UseVisualStyleBackColor = true;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click_1);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(1178, 288);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(177, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Завантаження рейсів";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1178, 259);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(177, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Збереження рейсів";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click_1);
            // 
            // viewBoardingPassButton
            // 
            this.viewBoardingPassButton.Location = new System.Drawing.Point(1178, 85);
            this.viewBoardingPassButton.Name = "viewBoardingPassButton";
            this.viewBoardingPassButton.Size = new System.Drawing.Size(177, 23);
            this.viewBoardingPassButton.TabIndex = 3;
            this.viewBoardingPassButton.Text = "Посадкова відомость";
            this.viewBoardingPassButton.UseVisualStyleBackColor = true;
            this.viewBoardingPassButton.Click += new System.EventHandler(this.viewBoardingPassButton_Click_1);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(633, 29);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(138, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Сброс пошуку";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 640);
            this.Controls.Add(this.flightsDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.viewBoardingPassButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.bookTicketButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.editFlightButton);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.arrivalComboBox);
            this.Controls.Add(this.departureComboBox);
            this.Controls.Add(this.Дата);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каса аеропорту";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox departureComboBox;
        private System.Windows.Forms.ComboBox arrivalComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label Дата;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView flightsDataGridView;
        private System.Windows.Forms.Button addFlightButton;
        private System.Windows.Forms.Button bookTicketButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editFlightButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button viewBoardingPassButton;
        private System.Windows.Forms.Button resetButton;
    }
}

