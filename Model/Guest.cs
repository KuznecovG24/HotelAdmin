using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{

    public class Guest
    {
        private long id;
        private string name;
        private DateTime move_in;
        private DateTime move_out;
        private long rnokpp;
        private long passport_number;
        private string nationality;
        public long ID { get {
                if(id == default) 
                    id = DateTime.Now.Ticks;
                return id;
            } private set { id = value; } }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public DateTime MoveIn
        {
            get { return move_in; }
            set { move_in = value; }
        }
        public DateTime MoveOut
        {
            get { return move_out; }
            set
            {
                if (value <= move_in)
                {
                    return;
                }
                move_out = value;
            }
        }
        public long RNOKPP
        {
            get { return rnokpp; }
            set { rnokpp = value; }
        }
        public long PassportNumber
        {
            get { return passport_number; }
            set { passport_number = value; }
        }
        public string Nationality
        {
            get { return nationality; }
            set { 
                if (value.ToLower() == "russian")
                    nationality = "ORK";  
                else
                    nationality = value; }
        }
        public Guest(string name,DateTime move_in,DateTime move_out,long rnokpp,long passport_number,string nationality) {
            this.Name = name;
            this.MoveIn = move_in;
            this.MoveOut = move_out;
            this.RNOKPP = rnokpp;
            this.PassportNumber = passport_number;
            this.Nationality = nationality;
            
        }
        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine("  " + Name + ": ");
            res.AppendLine("Moved in at " + move_in.ToString("d"));
            res.AppendLine(", Moved out at " + move_out.ToString("d"));
            res.AppendLine(", RNOKPP " + rnokpp.ToString());
            res.AppendLine(", Passport " +  passport_number.ToString());
            res.AppendLine(", Nationality " + nationality);
            return res.ToString();
        }
    }
    

}
