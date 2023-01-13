using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_home_appliance_rental_application
{
    public partial class user_page : Form
    {

        // oledb with microsoft access database 
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;

        public user_page()
        {
            InitializeComponent();
        }


        // log out button 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        // form load
        private void user_page_Load(object sender, EventArgs e)
        {
            string display_string = String.Format("select * from `appliance`;");
            cmd = new OleDbCommand(display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            userDisplay.DataSource = dt;
        }

        // display item button 
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string display_string = String.Format("select * from `appliance`;");
            cmd = new OleDbCommand(display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            userDisplay.DataSource = dt;
        }

        // sort item with energy consumption 
        private void btnSort_Click(object sender, EventArgs e)
        {
            string sort_display_string = String.Format("select * from `appliance` order by `powerUsage`;");
            cmd = new OleDbCommand(sort_display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            userDisplay.DataSource = dt;
        }


        // search item with type 
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        // add to the shopping cart button
        private void btnCart_Click(object sender, EventArgs e)
        {

        }

        // calculate total price 
        private void btn_calculate_Click(object sender, EventArgs e)
        {

        }
    }
}
