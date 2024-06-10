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
    public partial class AddRoom : Form
    {
        public Room Room { get; set; }
        public AddRoom(Room room = null)
        {
            InitializeComponent();
            if(room != null) { 
                this.NumBox.Text = room.Capacity.ToString();
                switch(room.Type) {
                    case RoomType.Econom:
                        this.RoomClassComboBox.SelectedItem = this.RoomClassComboBox.Items[0];
                        break;
                    case RoomType.Standart:
                        this.RoomClassComboBox.SelectedItem = this.RoomClassComboBox.Items[1];
                        break;
                    case RoomType.Presindent:
                        this.RoomClassComboBox.SelectedItem = this.RoomClassComboBox.Items[2];
                        break;
                }
            }
            

        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        { var type = RoomType.Standart;
            var capacity = 0;
            if (!int.TryParse(NumBox.Text, out capacity)) { 
                MessageBox.Show("Not a number as capacity");
                return; }
            switch (RoomClassComboBox.SelectedItem)
            {
                case "Econom":
                    type = RoomType.Econom;
                    break;
                case "Standart":
                    type = RoomType.Standart;
                    break;
                case "President":
                    type = RoomType.Presindent;
                    break;
            }
            Room = new Room(capacity,type);
            this.Close();
        }
    }
}
