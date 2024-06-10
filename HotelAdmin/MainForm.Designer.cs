namespace HotelAdmin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            BusyRoomsListBox = new ListBox();
            AddRoomButton = new Button();
            AddGuestButton = new Button();
            RemoveButton = new Button();
            TraceferButton = new Button();
            RoomsGuestsLabel = new Label();
            EditButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // BusyRoomsListBox
            // 
            BusyRoomsListBox.FormattingEnabled = true;
            BusyRoomsListBox.ItemHeight = 15;
            BusyRoomsListBox.Location = new Point(49, 58);
            BusyRoomsListBox.Margin = new Padding(3, 2, 3, 2);
            BusyRoomsListBox.Name = "BusyRoomsListBox";
            BusyRoomsListBox.Size = new Size(768, 454);
            BusyRoomsListBox.TabIndex = 0;
            // 
            // AddRoomButton
            // 
            AddRoomButton.BackColor = SystemColors.Highlight;
            AddRoomButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddRoomButton.Location = new Point(823, 60);
            AddRoomButton.Margin = new Padding(3, 2, 3, 2);
            AddRoomButton.Name = "AddRoomButton";
            AddRoomButton.Size = new Size(167, 76);
            AddRoomButton.TabIndex = 2;
            AddRoomButton.Text = "Add room";
            AddRoomButton.UseVisualStyleBackColor = false;
            AddRoomButton.Click += AddRoomButton_Click;
            // 
            // AddGuestButton
            // 
            AddGuestButton.BackColor = SystemColors.Highlight;
            AddGuestButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddGuestButton.Location = new Point(823, 153);
            AddGuestButton.Margin = new Padding(3, 2, 3, 2);
            AddGuestButton.Name = "AddGuestButton";
            AddGuestButton.Size = new Size(167, 76);
            AddGuestButton.TabIndex = 3;
            AddGuestButton.Text = "Add guest";
            AddGuestButton.UseVisualStyleBackColor = false;
            AddGuestButton.Click += AddGuestButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.IndianRed;
            RemoveButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(823, 436);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(167, 76);
            RemoveButton.TabIndex = 4;
            RemoveButton.Text = "Delete";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // TraceferButton
            // 
            TraceferButton.BackColor = Color.FromArgb(0, 192, 192);
            TraceferButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TraceferButton.Location = new Point(823, 243);
            TraceferButton.Margin = new Padding(3, 2, 3, 2);
            TraceferButton.Name = "TraceferButton";
            TraceferButton.Size = new Size(167, 76);
            TraceferButton.TabIndex = 5;
            TraceferButton.Text = "Transfer guest";
            TraceferButton.UseVisualStyleBackColor = false;
            TraceferButton.Click += TraceferButton_Click;
            // 
            // RoomsGuestsLabel
            // 
            RoomsGuestsLabel.AutoSize = true;
            RoomsGuestsLabel.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RoomsGuestsLabel.ForeColor = Color.DarkGoldenrod;
            RoomsGuestsLabel.Location = new Point(49, 26);
            RoomsGuestsLabel.Name = "RoomsGuestsLabel";
            RoomsGuestsLabel.Size = new Size(157, 21);
            RoomsGuestsLabel.TabIndex = 6;
            RoomsGuestsLabel.Text = "Rooms and Guests";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.FromArgb(0, 192, 192);
            EditButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            EditButton.Location = new Point(823, 336);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(167, 76);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1002, 568);
            Controls.Add(EditButton);
            Controls.Add(RoomsGuestsLabel);
            Controls.Add(TraceferButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddGuestButton);
            Controls.Add(AddRoomButton);
            Controls.Add(BusyRoomsListBox);
            ForeColor = Color.Cornsilk;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "HotelAdmin";
            Load += MainForm_Load;
            KeyDown += MainForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ListBox BusyRoomsListBox;
        private Button AddRoomButton;
        private Button AddGuestButton;
        private Button RemoveButton;
        private Button TraceferButton;
        private Label RoomsGuestsLabel;
        private Button EditButton;
        private System.Windows.Forms.Timer timer1;
    }
}
