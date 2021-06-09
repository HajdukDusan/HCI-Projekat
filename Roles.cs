using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat
{
    public enum Role
    {
        CLIENT, ORGANIZER, ADMIN
    }

    public class Account
    {
        private Role _role;
        private String _name;
        private String _email;
        private String _phone;
        private String _password;

        public Role Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public String Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Account(Role role, String name, String email, String phone, String password)
        {
            this.Role = role;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Password = password;
        }

        public String toString()
        {
            return Role.ToString() + "|" + Name + "|" + Email + "|" + Phone + "|" + Password;
        }
    }
}
