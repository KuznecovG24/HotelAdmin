using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum RoomType
    {
        Econom,
        Standart,
        Presindent,
    }
    public class Room
    {
        private long id;
        private RoomType type;
        private int capacity;

        public List<Guest> guests;
        public int Capacity { get { return capacity; } set { if(value>=guests.Count){ capacity = value; } } }

        public RoomType Type { get { return type; } set { if (guests.Count == 0) { type = value; } } }
        public long ID { get { return id; } private set { id = value; } }
        public bool Busy { get; set; }
        public bool Full { get { return guests.Count >= capacity; } }
        public Room(int capacity,RoomType type,long id = 0) { 
            this.capacity = capacity;
            this.type = type;
            this.id = id;
            guests = new List<Guest>();
        }
        public void Add(Guest guest) {
            if (capacity == guests.Count)
                return;
            guests.Add(guest);
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine($"{id}.  Capacity: {capacity},  Type: {type}");
            return res.ToString();
        }
    }
}
