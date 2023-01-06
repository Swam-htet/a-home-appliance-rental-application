using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace a_home_appliance_rental_application
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        // form load function 
        private void registration_Load(object sender, EventArgs e)
        {
        }

        // username validation 
        private Boolean userNameValidation(string name)
        {
            // fail username validation 
            if(Regex.IsMatch(name, @"\W") == false)
            {
                // MessageBox.Show("Passed uername validation.");
                return true;
            }

            // pass validation 
            return false;
        }

        
        // email validation 
        private Boolean emailvalidation(string email)
        {
            Regex validateEmailRegex = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
            if(validateEmailRegex.IsMatch(email) == true)
            {
                // MessageBox.Show("Passed email validation.");
                return true;
            }

            // fail email validation 
            return false;
        }

        // phone number validation
        private Boolean phNovalidation(string phNo)
        {
            Regex validatePhoneNumberRegex = new Regex("^\\+?[1-9][0-9]{7,14}$");
            if(validatePhoneNumberRegex.IsMatch(phNo) == true)
            {
                // MessageBox.Show("Passed phone number validation");
                return true;
            }
            // fail validation
            return false;
        }

        // password validation 
        private Boolean passwordValidation(string pw,string confirm)
        {
            if(pw == confirm)
            { 
                Regex check = new Regex(@"\W");

                // pass validation 
                if (pw.Length > 7 && pw.Length < 17 && check.IsMatch(pw) == false)
                {
                    // MessageBox.Show("Passed password validation.");
                    return true;
                }

                // fail password validation 
                return false;
            }
            // need to check the password and confirm password
            return false;
        }


        // create user account button
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // input strings
            string name = inputUsername.Text;
            string email = inputEmail.Text;
            string pw = inputPassword.Text;
            string conFirmPw = inputConfirmPassword.Text;
            string phNo = inputPhNo.Text;


            // username validation 
            if (userNameValidation(name) == true && emailvalidation(email) == true && phNovalidation(phNo) == true && passwordValidation(pw, conFirmPw) == true)
            {
                // create new user object 
                User add = new NormalUser(name, pw, email, phNo);

                // add the use to the database
            }
            else
            {
                // faile validation
                MessageBox.Show("Need to check you input details.");
            }
            
        }

        // back to the login page button 
        private void btnBack_Click(object sender, EventArgs e)
        {
            // hide registraion page and open login page 
            this.Hide();
            new login().Show();
        }

    }
}
