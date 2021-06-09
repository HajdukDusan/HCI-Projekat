using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat
{

    static class AppManager
    {

        public static List<Account> Accounts = new List<Account>();
        public static List<Event> Events = new List<Event>();

        public static List<Associate> Associates = new List<Associate>();
        public static List<String> AssociateTypes = new List<String>();
        public static List<Suggestion> Suggestions = new List<Suggestion>();

        public static Account SelectedAccount = null;

        public static Event SelectedEvent = null;

        public static bool confirm = false;

        static public void LoadData()
        {
            loadAccounts();
            loadAssociates();
            loadEvents();
            loadSuggestions();
        }

        static public List<Associate> GetAssociatesNotInSelectedEvent()
        {
            List<Associate> tmp = new List<Associate>();
            foreach (Associate s in Associates)
            {
                bool t = true;
                for (int i = 0; i < SelectedEvent.eventAssociates.Count; i++)
                {
                    if(s.Name == SelectedEvent.eventAssociates[i].Name)
                    {
                        t = false;
                        break;
                    }
                }
                if (t)
                {
                    tmp.Add(s);
                }
            }
            return tmp;
        }

        static public void saveSuggestion(Suggestion sug)
        {
            Suggestions[sug.index] = sug;

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//suggestions.txt");

            foreach (Suggestion s in Suggestions)
            {
                file.WriteLineAsync(s.toString());
            }
            file.Close();

        }

        static public void addSuggestion(Suggestion sug)
        {
            Suggestions.Add(sug);

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//suggestions.txt", append: true);
            file.WriteLineAsync(sug.toString());
            file.Close();

        }

        static public Account getAccountFromEmail(String email)
        {
            foreach (Account item in Accounts)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        static public void loadSuggestions()
        {
            List<Suggestion> suggestions = new List<Suggestion>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("..//suggestions.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] tmp = line.Split('|');
                if (tmp[0] != "")
                    suggestions.Add(new Suggestion(tmp[0], tmp[1], tmp[2], tmp[3], tmp[4], (Status)Enum.Parse(typeof(Status), tmp[5], true)));
            }
            file.Close();
            Suggestions = suggestions;
        }

        static public void loadEvents()
        {
            List<Event> events = new List<Event>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("..//events.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] tmp = line.Split('|');

                Account organizer = null, client = null;

                foreach (Account a in Accounts)
                {
                    if(a.Email == tmp[1])
                    {
                        organizer = a;
                    }
                    if (a.Email == tmp[10])
                    {
                        client = a;
                    }
                }

                Event e = new Event(tmp[0], organizer, (EventType)Enum.Parse(typeof(EventType), tmp[2], true),
                                    tmp[3], tmp[4], tmp[5], tmp[6], (Color)Enum.Parse(typeof(Color), tmp[7], true), Int32.Parse(tmp[8]), Int32.Parse(tmp[9]), client);

                String[] asc = tmp[11].Split(',');

                foreach (String item in asc)
                {
                    if (item != "")
                    {
                        e.eventAssociates.Add(GetAssociateByName(item));
                    }
                }
                events.Add(e);
            }
            file.Close();
            Events = events;
        }

        static public Associate GetAssociateByName(String name)
        {
            for (int i = 0; i < Associates.Count; i++)
            {
                if(Associates[i].Name == name)
                {
                    return Associates[i];
                }
            }
            return null;
        }

        static public List<Event> getEvents()
        {
            return new List<Event>(Events);
        }

        static public List<Suggestion> getEventSuggestionsPending(String name)
        {
            List<Suggestion> tmp = new List<Suggestion>();
            int i = 0;
            foreach (Suggestion item in Suggestions)
            {
                if(item.eventName == name && item.status == Status.Pending)
                {
                    item.index = i;
                    tmp.Add(item);
                }
                i++;
            }
            return tmp;
        }

        static public List<Suggestion> getEventSuggestions(String name)
        {
            List<Suggestion> tmp = new List<Suggestion>();
            int i = 0;
            foreach (Suggestion item in Suggestions)
            {
                if (item.eventName == name)
                {
                    item.index = i;
                    tmp.Add(item);
                }
                i++;
            }
            return tmp;
        }

        static public Event getEventByName(String name)
        {
            foreach (Event item in Events)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        static public void loadAccounts()
        {
            List<Account> accounts = new List<Account>();

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("..//users.txt");
            while ((line = file.ReadLine()) != null)
            {
                String[] tmp = line.Split('|');

                switch (tmp[0])
                {
                    case "ADMIN":
                        accounts.Add(new Account(Role.ADMIN, tmp[1], tmp[2], tmp[3], tmp[4]));
                        break;
                    case "ORGANIZER":
                        accounts.Add(new Account(Role.ORGANIZER, tmp[1], tmp[2], tmp[3], tmp[4]));
                        break;
                    case "CLIENT":
                        accounts.Add(new Account(Role.CLIENT, tmp[1], tmp[2], tmp[3], tmp[4]));
                        break;
                }
            }
            file.Close();
            Accounts = accounts;
        }

        static public void loadAssociates()
        {
            List<Associate> associates = new List<Associate>();

            string line;
            bool firstLine = true;
            System.IO.StreamReader file = new System.IO.StreamReader("..//associates.txt");
            while ((line = file.ReadLine()) != null)
            {
                if (firstLine)
                {
                    AssociateTypes = new List<string>();
                    String[] types = line.Split('|');
                    for (int i = 0; i < types.Length; i++)
                    {
                        AssociateTypes.Add(types[i]);
                    }
                    firstLine = false;
                }
                else
                {
                    String[] tmp = line.Split('|');
                    associates.Add(new Associate(tmp[0], tmp[1], tmp[2]));
                }
            }
            file.Close();
            Associates = associates;
        }

        static public List<Event> getEventOfClient(String email)
        {
            List<Event> events = new List<Event>();
            for (int i = 0; i < Events.Count; i++)
            {
                if(email == Events[i]._client.Email)
                {
                    events.Add(Events[i]);
                }
            }
            return events;
        }


        static public List<Event> getEventOfOrganizer(String email)
        {
            List<Event> events = new List<Event>();
            for (int i = 0; i < Events.Count; i++)
            {
                if (email == Events[i]._organizer.Email)
                {
                    events.Add(Events[i]);
                }
            }
            return events;
        }

        static public List<Associate> getAssociates()
        {
           return new List<Associate>(Associates);
        }

        static public List<Account> getClients()
        {
            List<Account> clients = new List<Account>();
            for (int i = 0; i < Accounts.Count; i++)
            {
                if(Accounts[i].Role == Role.CLIENT)
                {
                    clients.Add(Accounts[i]);
                }
            }
            return clients;
        }
        static public List<Account> getOrganizers()
        {
            List<Account> clients = new List<Account>();
            for (int i = 0; i < Accounts.Count; i++)
            {
                if (Accounts[i].Role == Role.ORGANIZER)
                {
                    clients.Add(Accounts[i]);
                }
            }
            return clients;
        }
        
        static public Account findAccount(String email)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if(Accounts[i].Email == email)
                {
                    return Accounts[i];
                }
            }
            return null;
        }

        static public void addEvent(Event e)
        {
            Events.Add(e);

            // append text
            System.IO.StreamWriter file = new System.IO.StreamWriter("..//events.txt", append: true);
            file.WriteLineAsync(e.toString());
            file.Close();
        }

        static public void addAccount(Account account)
        {
            Accounts.Add(account);

            // append text
            System.IO.StreamWriter file = new System.IO.StreamWriter("..//users.txt", append: true);
            file.WriteLineAsync(account.toString());
            file.Close();
        }

        static public void addAssociate(Associate associate)
        {
            Associates.Add(associate);

            for (int i = 0; i < AssociateTypes.Count; i++)
            {
                if(AssociateTypes[i] == associate.Type)
                {
                    // append text
                    System.IO.StreamWriter file = new System.IO.StreamWriter("..//associates.txt", append: true);
                    file.WriteLineAsync(associate.toString());
                    file.Close();
                    return;
                }
            }
            AssociateTypes.Add(associate.Type);
            updateAssociates();
        }

        static public void updateAssociates()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("..//associates.txt");

            String s = "";
            for (int i = 0; i < AssociateTypes.Count; i++)
            {
                if(i != 0)
                {
                    s += "|" + AssociateTypes[i];
                }
                else
                {
                    s += AssociateTypes[i];
                }
            }
            file.WriteLineAsync(s);

            foreach (Associate associate in Associates)
            {
                file.WriteLineAsync(associate.toString());
            }
            file.Close();
        }
        static public void editAssociate(Associate associate, int index)
        {
            Associates[index] = associate;

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//associates.txt");

            String s = "";
            for (int i = 0; i < AssociateTypes.Count; i++)
            {
                if (i != 0)
                {
                    s += "|" + AssociateTypes[i];
                }
                else
                {
                    s += AssociateTypes[i];
                }
            }
            file.WriteLineAsync(s);

            foreach (Associate a in Associates)
            {
                file.WriteLineAsync(a.toString());
            }
            file.Close();
        }

        static public void deleteAssociate(int index)
        {

            for (int j = 0; j < AssociateTypes.Count; j++)
            { 
                if(AssociateTypes[j] == Associates[index].Type)
                {
                    bool isMore = false;
                    for (int i = 0; i < Associates.Count; i++)
                    {
                        if(AssociateTypes[j] == Associates[i].Type && i != index)
                        {
                            isMore = true;
                            break;
                        }
                    }
                    if (!isMore)
                    {
                        AssociateTypes.RemoveAt(j);
                    }
                    break;
                }
            }

            Associates.RemoveAt(index);

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//associates.txt");

            String s = "";
            for (int i = 0; i < AssociateTypes.Count; i++)
            {
                if (i != 0)
                {
                    s += "|" + AssociateTypes[i];
                }
                else
                {
                    s += AssociateTypes[i];
                }
            }
            file.WriteLineAsync(s);

            foreach (Associate a in Associates)
            {
                file.WriteLineAsync(a.toString());
            }
            file.Close();
        }

        static public void deleteAccount(String email)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if(Accounts[i].Email == email)
                {
                    Accounts.RemoveAt(i);
                    break;
                }
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//users.txt");

            foreach (Account a in Accounts)
            {
                file.WriteLineAsync(a.toString());
            }
            file.Close();
        }

        static public void deleteEvent(String name)
        {
            for (int i = 0; i < Events.Count; i++)
            {
                if (Events[i].Name == name)
                {
                    Events.RemoveAt(i);
                    break;
                }
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//events.txt");

            foreach (Event a in Events)
            {
                file.WriteLineAsync(a.toString());
            }
            file.Close();
        }

        static public void editAccount(Account acc)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if(acc.Email == Accounts[i].Email)
                {
                    Accounts[i] = acc;
                }
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//users.txt");

            foreach (Account a in Accounts)
            {
                file.WriteLineAsync(a.toString());
            }
            file.Close();
        }

        static public void editEvent(Event e, int index)
        {
            Events[index] = e;

            System.IO.StreamWriter file = new System.IO.StreamWriter("..//events.txt");

            foreach (Event a in Events)
            {
                file.WriteLineAsync(a.toString());
            }
            file.Close();
        }
    }
}
