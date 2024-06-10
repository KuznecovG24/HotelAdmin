using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAdmin
{
    public partial class AddGuest : Form
    {
        public Guest guest;
        public long room;
        public AddGuest(MainForm mf,Guest guest = null)
        {
            InitializeComponent();
            foreach(var r in mf.hotel.rooms)
            {
                NumBox.Items.Add(r);
            }
            if (guest != null)
            {
                NumBox.Enabled = false;
                PassNumBox.Text = guest.PassportNumber.ToString();
                GuestNameBox.Text = guest.Name;
                NationalBox.Text = guest.Nationality;
                StartTimePicker.Value = guest.MoveIn;
                EndTimePicker.Value = guest.MoveOut;
                RNOKPPBox.Text = guest.RNOKPP.ToString();
            }
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            room = -1;
                long rnokpp, passport_number;
                if (long.TryParse(RNOKPPBox.Text, out rnokpp) &&
                    long.TryParse(PassNumBox.Text, out passport_number) &&
                    !string.IsNullOrEmpty(GuestNameBox.Text) &&
                    !string.IsNullOrEmpty(NationalBox.Text) &&
                    !(StartTimePicker.Value >= EndTimePicker.Value))
                {
                    guest = new Guest(GuestNameBox.Text,
                        StartTimePicker.Value, EndTimePicker.Value, rnokpp, passport_number, NationalBox.Text);
                    if(NumBox.SelectedItem != null)
                    {
                        this.room = (NumBox.SelectedItem as Room).ID;
                    }
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect input.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }

}
