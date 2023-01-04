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


        public login()
        {
            InitializeComponent();
        }

        // form load 
        private void login_Load(object sender, EventArgs e)
        {
            userList = new List<User>();

            // admin account 
            User admin = new Adminuser("Swam Htet", "222222", "swamhtet129@gmail.com", "09951538463");
            
            // add the admin user to the list
            userList.Add(admin);

            // add normal user to the list
            addNormalUserToList("Soe Soe", "111111", "soesoe234@gmail.com", "09123456789");

        }

        // add normal user to the list
        public void addNormalUserToList(string u,string p,string e,string ph)
        {
            // create normal user account from function arguments
            User something;
            something = new NormalUser(u, p, e, ph);

            // add normal user to the list
            userList.Add(something);
        }

        // find normal user account form the list
        private User findAccount(String num, String pin)
        {
            User check;

            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].checkPin(num, pin) == true)
                {
                    check = userList[i];
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

            if (adminCheck.Checked == true)
            {
                
                if (userList[0].Name == u && userList[0].Password == p)
                {
                    MessageBox.Show("Admin login successful.");
                    this.Hide();
                    new admin_page().Show();
                }
                else
                {
                    MessageBox.Show("Wrong error.");
                }
            }
            else
            {
                User check = findAccount(u, p);
                if(check != null)
                {
                    MessageBox.Show("Normal user login successful");
                    this.Hide();
                    new user_page().Show();
                }
                else
                {
                    MessageBox.Show("There is no account in the list.");
                }

            }
        }

        
        // click register button 
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            new registration().Show();

        }
    }
}
