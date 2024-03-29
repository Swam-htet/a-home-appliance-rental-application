﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace a_home_appliance_rental_application
{
    public partial class registration : Form
    {
        // data base declaration 

        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;

        public registration()
        {
            InitializeComponent();
        }

        // registration page load
        private void registration_Load(object sender, EventArgs e)
        {
        }

        // username validation 
        private Boolean userNameValidation(string name)
        {
            // fail username validation 
            if(Regex.IsMatch(name, @"^[A-z][A-z|\.|\s]+$") == true)
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
            string address = inputAddress.Text;

            // passed validation 
            if (userNameValidation(name) == true && emailvalidation(email) == true && phNovalidation(phNo) == true && passwordValidation(pw, conFirmPw) == true && address != "")
            {
                // add the use to the database
                string create_user_query = String.Format("insert into `user` (`name`,`Password`,`address`,`email`,`phoneNumber`) values ('{0}','{1}','{2}','{3}','{4}');",name,pw,address,email,phNo);


                // checking duplicated user from the database
                string check_user_query = String.Format("select `name`,`email` from `user` where `name` = '" + name + "' and `email` = '" + email + "'");

                cmd = new OleDbCommand(check_user_query, connect);
                ad = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    // creating new user account to the database
                    cmd = new OleDbCommand(create_user_query, connect);
                    ad = new OleDbDataAdapter(cmd);
                    dt = new DataTable();
                    ad.Fill(dt);
                    ad.Update(dt);

                    MessageBox.Show("Registeration Successful.");

                    // open user page
                    this.Hide();
                    new user_page().Show();
                }
                else
                { 
                    MessageBox.Show("User account is already existed.");
                }

            }
            
            // fail validation
            else
            {
                MessageBox.Show("Please check user input details.");
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
