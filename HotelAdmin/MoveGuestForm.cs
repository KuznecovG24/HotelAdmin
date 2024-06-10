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
    public partial class MoveGuestForm : Form
    {
        MainForm mf;
        public MoveGuestForm(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
            foreach(var r in mf.hotel.rooms)
            { comboBox2.Items.Add(r); }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem != null)
            {
                var guest = mf.BusyRoomsListBox.SelectedItem as Guest;
                var ok = true;

                mf.hotel.RemoveGuest(guest);

                try
                {
                    mf.hotel.AddGuest(guest, (comboBox2.SelectedItem as Room).ID);
                }
                catch { ok = false; }

                if (!ok) { 
                    mf.hotel.AddGuest(guest);
                }
                

                mf.UpdateListBox();
                this.Close();
            }
        }
    }
}
