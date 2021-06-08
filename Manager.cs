using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat
{

    static class AppManager
    {

        public static List<Account> Accounts;

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
                    case "Admin":
                        accounts.Add(new Account(Role.ADMIN, tmp[1], tmp[2], tmp[3], tmp[4]));
                        break;
                    case "Organizer":
                        accounts.Add(new Account(Role.ORGANIZER, tmp[1], tmp[2], tmp[3], tmp[4]));
                        break;
                    case "Client":
                        accounts.Add(new Account(Role.CLIENT, tmp[1], tmp[2], tmp[3], tmp[4]));
                        break;
                }
            }
            file.Close();
            Accounts = accounts;
        }

        static public bool saveAccount(Account account)
        {
            return false;
        }

        static public Account findAccount(String email)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                if(Accounts[i].email == email)
                {
                    return Accounts[i];
                }
            }
            return null;
        }
    }
}
