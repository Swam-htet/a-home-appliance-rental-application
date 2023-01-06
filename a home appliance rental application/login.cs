using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_home_appliance_rental_application
{
    public partial class login : Form
    {
        // list to store account 
        List<User> userList;

        // admin user
        User admin;

        public login()
        {
            InitializeComponent();
        }

        // form load 
        private void login_Load(object sender, EventArgs e)
        {
            userList = new List<User>();

            // admin account 
            admin = new Adminuser("Swam Htet", "222222", "swamhtet129@gmail.com", "09951538463");
            

            // add normal user to the list
            addNormalUserToList("alphar", "111111", "soesoe234@gmail.com", "09123456789");

        }

        // add normal user to the list
        public void addNormalUserToList(string u,string p,string e,string ph)
        {
            // create normal user account from function arguments
            User something = new NormalUser(u, p, e, ph);

            // add normal user to the list
            userList.Add(something);
        }

        // find normal user account form the list
        private User findAccount(String name, String pin)
        {
            User check;

            for (int i = 0; i < userList.Count; i++)
            {
                check = userList[i];

                if (check.checkPin(name, pin) == true)
                {
                    return check;
                }
            }
            return null;
        }


        // click login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = inputUsername.Text;
            string p = inputPassword.Text;

            // check box for admin login 
            if (adminCheck.Checked == true)
            {
                
                if (admin.checkPin(u,p) == true)
                {
                    // MessageBox.Show("Admin login successful.");
                    this.Hide();
                    new admin_page().Show();
                }
                else
                {
                    MessageBox.Show("Admin input fail.");
                }
            }

            // no checkobox for normal user login
            else
            {          
                // find user account from the list
                User check = findAccount(u, p);

                // login in successful
                if (check != null)
                {
                     // MessageBox.Show("Normal user login successful");
                     this.Hide();
                     new user_page().Show();
                }

                // no account in the list
                else
                {
                  MessageBox.Show("There is no account in the normal user list.");
                }
            }

            
        }

        
        // click register button to open registration page 
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new registration().Show();

        }
    
    }
}
