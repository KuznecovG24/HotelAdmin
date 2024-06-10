using Model;
using System.Diagnostics.Metrics;
namespace HotelAdmin
{
    public partial class MainForm : Form
    {
        public Hotel hotel;
        public MainForm()
        {
            InitializeComponent();
            timer1.Start();
            hotel = new Hotel();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            hotel.Load(Directory.GetCurrentDirectory() + "\\data.json");
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddRoomButton_Click(object sender, EventArgs e)
        {
            var add_room = new AddRoom();
            add_room.ShowDialog();
            if (add_room.Room != null)
            {
                hotel.AddRoom(add_room.Room.Capacity, add_room.Room.Type);
                UpdateListBox();
            }

        }

        private void AddGuestButton_Click(object sender, EventArgs e)
        {
            var add_guest = new AddGuest(this);
            add_guest.ShowDialog();
            if (add_guest.room != null && add_guest.guest != null)
            {
                var ok = true;
                try
                { hotel.AddGuest(add_guest.guest, add_guest.room); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ok = false;
                }
                if (ok)
                {
                    string receipt = $"Receipt:\n" +
                        $"Name: {add_guest.guest.Name}\n" +
                        $"Move in: {add_guest.guest.MoveIn.ToString("d")}\n" +
                        $"Move out: {add_guest.guest.MoveOut.ToString("d")}\n" +
                        $"RNOKPP: {add_guest.guest.RNOKPP}\n" +
                        $"Passport: {add_guest.guest.PassportNumber}\n" +
                        $"Nationality: {add_guest.guest.Nationality}";

                    MessageBox.Show(receipt);
                }


                UpdateListBox();
            }
        }

        private void TraceferButton_Click(object sender, EventArgs e)
        {
            if (BusyRoomsListBox.SelectedItem is Guest guest)
            {
                MoveGuestForm moveGuestForm = new MoveGuestForm(this);
                moveGuestForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("First choose something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateListBox()
        {
            BusyRoomsListBox.Items.Clear();
            foreach (var room in hotel.rooms)
            {
                BusyRoomsListBox.Items.Add(room);
                BusyRoomsListBox.Items.Add("  -");
                foreach (var guest in room.guests)
                {
                    BusyRoomsListBox.Items.Add(guest);
                }
            }
            hotel.Save(Directory.GetCurrentDirectory() + "\\data.json");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (BusyRoomsListBox.SelectedItem != null)
            {
                if (BusyRoomsListBox.SelectedItem is Room room)
                    if (room.guests.Count == 0)
                        hotel.RemoveRoom(room.ID);
                    else
                        MessageBox.Show("Room is not empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (BusyRoomsListBox.SelectedItem is Guest guest)
                    hotel.RemoveGuest(guest);
                if (BusyRoomsListBox.SelectedItem is string all)
                {
                    hotel.FreeRoom((BusyRoomsListBox.Items[BusyRoomsListBox.SelectedIndex - 1] as Room).ID);
                }
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("First choose something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BusyRoomsListBox.SelectedItem != null)
            {
                if (BusyRoomsListBox.SelectedItem is Room room)
                {
                    var add_room = new AddRoom(room);
                    add_room.ShowDialog();
                    if (add_room.Room != null)
                    {
                        room.Capacity = add_room.Room.Capacity;
                        room.Type = add_room.Room.Type;
                        UpdateListBox();
                    }
                }
                if (BusyRoomsListBox.SelectedItem is Guest guest)
                {
                    var add_guest = new AddGuest(this, guest);
                    add_guest.ShowDialog();
                    if (add_guest.room != null && add_guest.guest != null)
                    {
                        guest.Name = add_guest.guest.Name;
                        guest.MoveIn = add_guest.guest.MoveIn;
                        guest.MoveOut = add_guest.guest.MoveOut;
                        guest.RNOKPP = add_guest.guest.RNOKPP;
                        guest.PassportNumber = add_guest.guest.PassportNumber;
                        guest.Nationality = add_guest.guest.Nationality;
                        UpdateListBox();
                    }
                }
                if (BusyRoomsListBox.SelectedItem is string all)
                {
                    hotel.FreeRoom((BusyRoomsListBox.Items[BusyRoomsListBox.SelectedIndex - 1] as Room).ID);
                }
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("First choose something", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 112:
                    AddRoomButton_Click(null, null);
                    break;
                case 113:
                    AddGuestButton_Click(null, null);
                    break;
                case 114:
                    TraceferButton_Click(null, null);
                    break;
                case 115:
                    EditButton_Click(null, null);
                    break;
                case 116:
                    RemoveButton_Click(null, null);
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0;i < hotel.rooms.Count; i++)
            {
                for(int j = 0;j < hotel.rooms[i].guests.Count; j++)
                {
                    if (hotel.rooms[i].guests[j].MoveOut <= DateTime.Now)
                    {
                        var name = hotel.rooms[i].guests[j].Name;
                        hotel.RemoveGuest(hotel.rooms[i].guests[j]);
                        MessageBox.Show($"{name} - Moved out");
                        UpdateListBox();
                    }
                }
            }
        }
    }
}
