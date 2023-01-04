using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_home_appliance_rental_application
{
    internal class User
    {
        // private propertiese
        private string name;
        private string password;
        private string email;
        private string phoneNumber;

        // accessor method 
        public string Name { get => name; set => name = value; }
        public string Password { get => password;set=> password = value; }


        // constructor
        public User(string n,string p,string e,string pn) 
        {   
            name = n;
            password = p;
            email = e;
            phoneNumber = pn;
        }

        // check pin method
        public bool checkPin(string u, string p)
        {
            // check account number with parameter a 
            // if false
            if (name.ToLower().Equals(u.ToLower()) == false)
            {
                // end function
                return false;
            }

            // else check pin with parameter p
            if (password.ToLower().Equals(p.ToLower()))
            {
                return true;
            }

            // if pin is wrong
            else
            {
                return false;
            }
        }

    }

    class Adminuser : User
    {
        public Adminuser(string n,string p,string e,string ph):base(n, p, e, ph)
        {

        }
    }

    class NormalUser : User
    {
        public NormalUser(string n, string p, string e, string ph) : base(n, p, e, ph)
        {

        }
    }
}
