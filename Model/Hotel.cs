using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hotel
    {
        public List<Room> rooms;

        public Hotel() { 
            rooms = new List<Room>();
        }
        public void AddRoom(int capacity,RoomType type) {
            var id = 0;
            while(rooms.FirstOrDefault(r => r.ID == id) != default)
                id++;
            rooms.Add(new Room(capacity,type,id));
        }
        public void RemoveRoom(long room) { 
            rooms.Remove(rooms.FirstOrDefault(r => r.ID == room));
        }
        public void AddGuest(Guest guest,long Room = -1)
        {
            if(Room == -1)
            {
                foreach(Room room in rooms)
                {
                    if (room.guests.Count == 0 || (room.Type == RoomType.Econom && !room.Full))
                    {
                        room.guests.Add(guest);
                        return;
                    }
                    throw new Exception("no free room");
                }
            }
            else
            {
                if(rooms.FirstOrDefault(r => r.ID == Room) == default)
                    throw new Exception("room not exist");
                if(rooms.FirstOrDefault(r => r.ID == Room).Busy)
                    throw new Exception("room is busy");
                if (rooms.FirstOrDefault(r => r.ID == Room).Full)
                    throw new Exception("room is full");
                rooms.FirstOrDefault(r => r.ID == Room).Add(guest);
            }
        }
        public void RemoveGuest(Guest guest)
        {
            foreach(var r in rooms)
            {
                try
                {
                    r.guests.Remove(guest);
                }catch{ }
            }
        }
        public void FreeRoom(long Room) {
            rooms.FirstOrDefault(r => r.ID == Room).guests.Clear();
        }
        public void Save(string file)
        {
            if (!File.Exists(file))
                File.Create(file);
            File.WriteAllText(file,JsonConvert.SerializeObject(rooms,Formatting.Indented));
        }
        public void Load(string file)
        {
            if (File.Exists(file))
                rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText(file));
        }
    }
}
