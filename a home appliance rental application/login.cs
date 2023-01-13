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
using System.Data.OleDb;

namespace a_home_appliance_rental_application
{
    public partial class login : Form
    {
        User admin;

        // oledb with microsoft access database 
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;


        public login()
        {
            InitializeComponent();
        }

        // form load 
        private void login_Load(object sender, EventArgs e)
        {
            admin = new Adminuser("Swam Htet", "rocket100", "swamhtet129@gmail.com", "+959900400200", "Shwebo, Sagaing");

        }

      
        // click login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string u = inputUsername.Text;
            string p = inputPassword.Text;

            // check box for admin login 
            if (adminCheck.Checked == true)
            {

                // checking the admin from object
                if (admin.checkPin(u,p) == true)
                {
                    // login successful
                    // MessageBox.Show("Admin Login Successful.");
                    this.Hide();
                    new admin_page().Show();
                }
                /*
                // check admin from the database
                string check_admin_query = String.Format("select `name`,`password` from `administrator` where `name` = '" + inputUsername.Text + "' and `password` = '" + inputPassword.Text + "'");

                cmd = new OleDbCommand(check_admin_query, connect);
                ad = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                ad.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // login successful
                    // MessageBox.Show("Admin Login Successful.");
                    this.Hide();
                    new admin_page().Show();
                }
                */
                else
                {
                    MessageBox.Show("Admin input fail.");
                }
            }

            // no checkobox for normal user login
            else
            {
                // check user from the database
                string check_user_query = String.Format("select `name`,`password` from `user` where `name` = '" + inputUsername.Text + "' and `password` = '" + inputPassword.Text + "'");

                cmd = new OleDbCommand(check_user_query, connect);
                ad = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                ad.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    // login successful
                    // MessageBox.Show("User Login Successful.");
                    this.Hide();
                    new user_page().Show();
                }
                else
                {
                    // fail login 
                    MessageBox.Show("There is no match account in the list.");
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
