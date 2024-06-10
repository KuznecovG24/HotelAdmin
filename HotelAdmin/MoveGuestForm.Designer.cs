namespace HotelAdmin
{
    partial class MoveGuestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveGuestForm));
            comboBox2 = new ComboBox();
            label2 = new Label();
            AddGuestButton = new Button();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(15, 53);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 23);
            comboBox2.TabIndex = 1;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.DarkGoldenrod;
            label2.Location = new Point(96, 18);
            label2.Name = "label2";
            label2.Size = new Size(84, 21);
            label2.TabIndex = 3;
            label2.Text = "Кімната ";
            // 
            // AddGuestButton
            // 
            AddGuestButton.BackColor = SystemColors.Highlight;
            AddGuestButton.Font = new Font("Sitka Small", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AddGuestButton.ForeColor = SystemColors.Info;
            AddGuestButton.Location = new Point(58, 96);
            AddGuestButton.Margin = new Padding(3, 2, 3, 2);
            AddGuestButton.Name = "AddGuestButton";
            AddGuestButton.Size = new Size(167, 76);
            AddGuestButton.TabIndex = 5;
            AddGuestButton.Text = "Перемістити гостя";
            AddGuestButton.UseVisualStyleBackColor = false;
            AddGuestButton.Click += AddGuestButton_Click;
            // 
            // MoveGuestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(272, 200);
            Controls.Add(AddGuestButton);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MoveGuestForm";
            Text = "Перемістити гостя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private Label label2;
        private Button AddGuestButton;
    }
}