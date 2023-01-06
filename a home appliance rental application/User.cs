using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public virtual bool checkPin(string u, string p)
        {
            if (name == u && password == p)
            {
                return true;
            }

            return false;
            
        }

    }

    class Adminuser : User
    {
        // constructor for adminuser
        public Adminuser(string n,string p,string e,string ph):base(n, p, e, ph)
        {

        }

        // private property

        private int failedCount;
        private Boolean locked;

        // accessor methods
        public int FailedCount {
            get => failedCount;
            set=> failedCount = value;
        }

        public Boolean Locked
        {
            get => locked;
            set => locked = value;
        }

        public override bool checkPin(string u, string p)
        {
            Boolean condi;
            if(locked == true)
            {
                return false;
            }
            condi = base.checkPin(u, p);
            if(condi == false)
            {
                failedCount++;
                
                if(failedCount == 3)
                {
                    locked = true;
                    MessageBox.Show("Your account have been locked.");
                }
                return false;
            }
            else
            {
                failedCount = 0;
                return true;
            }
        }


    }


    class NormalUser : User
    {
        // constructor for normal user
        public NormalUser(string n, string p, string e, string ph) : base(n, p, e, ph)
        {

        }
    }
}
