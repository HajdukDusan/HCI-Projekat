using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCI_Projekat
{
    enum Role
    {
        CLIENT, ORGANIZER, ADMIN
    }

    class Account
    {
        public Role role;

        public String name;
        public String email;
        public String phone;
        public String password;

        public Account(Role role, String name, String email, String phone, String password)
        {
            this.role = role;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.password = password;
        }


    }
}
