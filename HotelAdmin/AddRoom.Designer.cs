namespace HotelAdmin
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            label1 = new Label();
            RoomClassComboBox = new ComboBox();
            label2 = new Label();
            NumBox = new TextBox();
            AddRoomButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.DarkGoldenrod;
            label1.Location = new Point(90, 110);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 28;
            label1.Text = "Room type";
            // 
            // RoomClassComboBox
            // 
            RoomClassComboBox.FormattingEnabled = true;
            RoomClassComboBox.Items.AddRange(new object[] { "Econom", "Standart", "President" });
            RoomClassComboBox.Location = new Point(88, 149);
            RoomClassComboBox.Margin = new Padding(3, 2, 3, 2);
            RoomClassComboBox.Name = "RoomClassComboBox";
            RoomClassComboBox.Size = new Size(228, 23);
            RoomClassComboBox.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(90, 21);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 30;
            label2.Text = "Capacity";
            // 
            // NumBox
            // 
            NumBox.Location = new Point(88, 58);
            NumBox.Margin = new Padding(3, 2, 3, 2);
            NumBox.Name = "NumBox";
            NumBox.Size = new Size(228, 23);
            NumBox.TabIndex = 29;
            // 
            // AddRoomButton
            // 
            AddRoomButton.BackColor = SystemColors.Highlight;
            AddRoomButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddRoomButton.ForeColor = SystemColors.Info;
            AddRoomButton.Location = new Point(111, 232);
            AddRoomButton.Margin = new Padding(3, 2, 3, 2);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Size = new Size(167, 76);
            AddRoomButton.TabIndex = 33;
            AddRoomButton.Text = "Apply";
            AddRoomButton.UseVisualStyleBackColor = false;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(404, 338);
            Controls.Add(AddRoomButton);
            Controls.Add(RoomClassComboBox);
            Controls.Add(label2);
            Controls.Add(NumBox);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddRoom";
            Text = "Add/Edit room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox RoomClassComboBox;
        private Label label2;
        private TextBox NumBox;
        private Button AddRoomButton;
    }
}