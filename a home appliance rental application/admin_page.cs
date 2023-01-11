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
    public partial class admin_page : Form
    {
        // oledb with microsoft access database 
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;

        public admin_page()
        {
            InitializeComponent();
        }

        // admin page form load
        private void admin_page_Load(object sender, EventArgs e)
        {
            string display_string = String.Format("select * from `appliance`;");
            cmd = new OleDbCommand(display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            displayAdmin.DataSource = dt;
        }

        // display item button 
        private void btnDisplayItem_Click(object sender, EventArgs e)
        {
            string display_string = String.Format("select * from `appliance`;");
            cmd = new OleDbCommand(display_string,connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            displayAdmin.DataSource= dt;

        }

        // display user button
        private void btnDisplayUser_Click(object sender, EventArgs e)
        {
            string display_user = String.Format("select * from `user`;");
            cmd = new OleDbCommand(display_user, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            displayAdmin.DataSource = dt;
        }

        // logout button 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }

        // add, edit and delete item button 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new add_item().Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new edit_item().Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new delete_item().Show();   
        }

        
    }
}
