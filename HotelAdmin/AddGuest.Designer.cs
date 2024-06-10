namespace HotelAdmin
{
    partial class AddGuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGuest));
            AddGuestButton = new Button();
            RoomsGuestsLabel = new Label();
            PassNumBox = new TextBox();
            label2 = new Label();
            RNOKPPBox = new TextBox();
            GuestNameBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            StartTimePicker = new DateTimePicker();
            EndTimePicker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            NationalBox = new TextBox();
            NumBox = new ComboBox();
            SuspendLayout();
            // 
            // AddGuestButton
            // 
            AddGuestButton.BackColor = SystemColors.Highlight;
            AddGuestButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddGuestButton.ForeColor = SystemColors.Info;
            AddGuestButton.Location = new Point(255, 411);
            AddGuestButton.Margin = new Padding(3, 2, 3, 2);
            AddGuestButton.Name = "AddGuestButton";
            AddGuestButton.Size = new Size(167, 76);
            AddGuestButton.TabIndex = 4;
            AddGuestButton.Text = "Apply";
            AddGuestButton.UseVisualStyleBackColor = false;
            AddGuestButton.Click += AddGuestButton_Click;
            // 
            // RoomsGuestsLabel
            // 
            RoomsGuestsLabel.AutoSize = true;
            RoomsGuestsLabel.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RoomsGuestsLabel.ForeColor = Color.DarkGoldenrod;
            RoomsGuestsLabel.Location = new Point(417, 206);
            RoomsGuestsLabel.Name = "RoomsGuestsLabel";
            RoomsGuestsLabel.Size = new Size(80, 21);
            RoomsGuestsLabel.TabIndex = 7;
            RoomsGuestsLabel.Text = "Passport";
            // 
            // PassNumBox
            // 
            PassNumBox.Location = new Point(419, 242);
            PassNumBox.Margin = new Padding(3, 2, 3, 2);
            PassNumBox.Name = "PassNumBox";
            PassNumBox.Size = new Size(228, 23);
            PassNumBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(221, 37);
            label2.Name = "label2";
            label2.Size = new Size(56, 21);
            label2.TabIndex = 12;
            label2.Text = "Room";
            // 
            // RNOKPPBox
            // 
            RNOKPPBox.Location = new Point(419, 159);
            RNOKPPBox.Margin = new Padding(3, 2, 3, 2);
            RNOKPPBox.Name = "RNOKPPBox";
            RNOKPPBox.Size = new Size(228, 23);
            RNOKPPBox.TabIndex = 13;
            // 
            // GuestNameBox
            // 
            GuestNameBox.Location = new Point(47, 159);
            GuestNameBox.Margin = new Padding(3, 2, 3, 2);
            GuestNameBox.Name = "GuestNameBox";
            GuestNameBox.Size = new Size(228, 23);
            GuestNameBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.DarkGoldenrod;
            label4.Location = new Point(419, 116);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 17;
            label4.Text = "RNOKPP";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.DarkGoldenrod;
            label5.Location = new Point(45, 122);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 18;
            label5.Text = "Name";
            // 
            // StartTimePicker
            // 
            StartTimePicker.Location = new Point(47, 242);
            StartTimePicker.Margin = new Padding(3, 2, 3, 2);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.Size = new Size(219, 23);
            StartTimePicker.TabIndex = 19;
            // 
            // EndTimePicker
            // 
            EndTimePicker.Location = new Point(47, 335);
            EndTimePicker.Margin = new Padding(3, 2, 3, 2);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.Size = new Size(219, 23);
            EndTimePicker.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.DarkGoldenrod;
            label6.Location = new Point(41, 206);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 21;
            label6.Text = "Move in at";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.DarkGoldenrod;
            label7.Location = new Point(47, 295);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 22;
            label7.Text = "Move out at";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.ForeColor = Color.DarkGoldenrod;
            label8.Location = new Point(419, 295);
            label8.Name = "label8";
            label8.Size = new Size(101, 21);
            label8.TabIndex = 26;
            label8.Text = "Nationality";
            // 
            // NationalBox
            // 
            NationalBox.Location = new Point(419, 335);
            NationalBox.Margin = new Padding(3, 2, 3, 2);
            NationalBox.Name = "NationalBox";
            NationalBox.Size = new Size(228, 23);
            NationalBox.TabIndex = 25;
            // 
            // NumBox
            // 
            NumBox.FormattingEnabled = true;
            NumBox.Location = new Point(221, 61);
            NumBox.Name = "NumBox";
            NumBox.Size = new Size(201, 23);
            NumBox.TabIndex = 27;
            // 
            // AddGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(700, 510);
            Controls.Add(NumBox);
            Controls.Add(label8);
            Controls.Add(NationalBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(EndTimePicker);
            Controls.Add(StartTimePicker);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(GuestNameBox);
            Controls.Add(RNOKPPBox);
            Controls.Add(label2);
            Controls.Add(PassNumBox);
            Controls.Add(RoomsGuestsLabel);
            Controls.Add(AddGuestButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddGuest";
            Text = "Add/Edit guest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddGuestButton;
        private Label RoomsGuestsLabel;
        private TextBox PassNumBox;
        private Label label2;
        private TextBox RNOKPPBox;
        private TextBox GuestNameBox;
        private Label label4;
        private Label label5;
        private DateTimePicker StartTimePicker;
        private DateTimePicker EndTimePicker;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox NationalBox;
        private ComboBox NumBox;
    }
}