using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat
{
    public enum EventType
    {
        Party,
        Wedding,
        Birthday,
        Concert,
        Gathering
    }

    public enum Color
    {
        RED, GREEN, BLUE, YELLOW, WHITE, ORANGE, PURPLE, BLACK, BRAWN
    }

    public class eventDTO
    {
        private String _name;
        public String Event { get { return _name; } set { _name = value; } }
    }

    public class Event
    {
        public List<Associate> eventAssociates = new List<Associate>();

        private String _name;
        public Account _organizer;
        private EventType _type;
        private String _budget;
        private String _location;
        private String _theme;
        private String _date;
        private Color _color;
        private int _guestCnt;
        private int _avgAge;
        public Account _client;

        public String Name { get { return _name; } set { _name = value; } }
        public String Organizer { get { return _organizer.Name; } }
        public EventType Type { get { return _type; } set { _type = value; } }
        public String Budget { get { return _budget; } set { _budget = value; } }
        public String Location { get { return _location; } set { _location = value; } }
        public String Theme { get { return _theme; } set { _theme = value; } }
        public String Date { get { return _date; } set { _date = value; } }
        public Color Color { get { return _color; } set { _color = value; } }
        public int GuestCount { get { return _guestCnt; } set { _guestCnt = value; } }
        public int AverageAge { get { return _avgAge; } set { _avgAge = value; } }
        public String Client { get { return _client.Name; } }

        public Event(String _name, Account _organizer, EventType _type, String _budget,
         String _location, String _theme, String _date, Color _color, int _guestCnt,
         int _avgAge, Account _client)
        {
            this._client = _client;
            this._organizer = _organizer;
            this.Name = _name;
            this.Type = _type;
            this.Budget = _budget;
            this.Location = _location;
            this.Theme = _theme;
            this.Date = _date;
            this.Color = _color;
            this.GuestCount = _guestCnt;
            this.AverageAge = _avgAge;
        }

        public String toString()
        {
            String tmp = "";

            for (int i = 0; i < eventAssociates.Count; i++)
            {
                if (i == 0)
                {
                    tmp += eventAssociates[i].Name;
                }
                else
                {
                    tmp += "," + eventAssociates[i].Name;
                }
            }

            return Name + "|" + _organizer.Email + "|" + Type + "|" + Budget + "|" + Location + "|" + Theme + "|" + Date + "|" + Color + "|" + GuestCount + "|" + AverageAge + "|" + _client.Email + "|" + tmp;
        }
    }

    public enum Status
    {
        Pending,
        Denied,
        Accepted
    }

    public class Suggestion
    {
        public String message;
        public String back_message = "";
        public Status status = Status.Pending;

        public String clientEmail;
        public String organizerEmail;
        public String eventName;

        public int index = 0;

        public String Message 
        { 
            get { 
                if(message.Length > 20)
                {
                    return message.Substring(0, 20) + "...";
                }
                return message;
            }
            set { message = value; } 
        }

        public Suggestion(String eventName, String c, String o, String m, String b_m, Status s)
        {
            status = s;
            this.eventName = eventName;
            message = m;
            back_message = b_m;
            clientEmail = c;
            organizerEmail = o;
        }
        public String toString()
        {
            return eventName + "|" + clientEmail + "|" + organizerEmail + "|" + message + "|" + back_message + "|" + status.ToString();
        }
    }

    public class Associate
    {
        private String _type;
        private String _name;
        private String _description;

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Associate(String type, String name, String description)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
        }

        public String toString()
        {
            return Type + "|" + Name + "|" + Description;
        }
    }
}
