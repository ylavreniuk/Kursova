namespace FlightBookingApp
{
    partial class BoardingPassForm
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
            this.boardingPassLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boardingPassLabel
            // 
            this.boardingPassLabel.AutoSize = true;
            this.boardingPassLabel.Location = new System.Drawing.Point(12, 9);
            this.boardingPassLabel.Name = "boardingPassLabel";
            this.boardingPassLabel.Size = new System.Drawing.Size(35, 13);
            this.boardingPassLabel.TabIndex = 0;
            this.boardingPassLabel.Text = "label1";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(352, 252);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BoardingPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 283);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.boardingPassLabel);
            this.Name = "BoardingPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посадкова відомість";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boardingPassLabel;
        private System.Windows.Forms.Button exitButton;
    }
}