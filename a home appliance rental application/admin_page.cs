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
            displayItem();

            displayUser();
        }


        // display item function
         private void displayItem()
        {
            string display_string = String.Format("select * from `appliance` order by `id`;");
            cmd = new OleDbCommand(display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            displayItemList.DataSource = dt;
        }


        // display user function 
        private void displayUser()
        {
            string display_user = String.Format("select * from `user` order by `id`;");
            cmd = new OleDbCommand(display_user, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            displayUserList.DataSource = dt;
        }

        // logout button 
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new login().Show();
        }


        // add, edit and delete item button 

        // add item button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new add_item().Show();
        }

        // edit item button
        private void btnEdit_Click(object sender, EventArgs e)
        {            
            // query string 
            string update_query =String.Format("update `appliance` set `powerUsage` = '{0}',`typicalUsage` = '{1}',`runningCost` = '{2}',`type` = '{3}',`description` = '{4}' where `name` = '{5}'",inputPower.Text,inputUsage.Text,Int32.Parse(inputCost.Text),inputType.Text,inputDescription.Text,inputName.Text);

            // delete from the database
            cmd = new OleDbCommand(update_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            ad.Update(dt);
            MessageBox.Show("Updating appliance Successful");
            displayItem();
        }

        // delete item button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string search = inputName.Text;
            // query string 
            string delete_query = "delete from `appliance` where `name` = '" + search + "'";

            // delete from the database
            cmd = new OleDbCommand(delete_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            ad.Update(dt);
            MessageBox.Show("Deleting appliance Successful");

            displayItem();
        }

        
        // cell enter
        private void displayItemList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            inputID.Text = displayItemList.CurrentRow.Cells[0].Value.ToString();
            inputName.Text = displayItemList.CurrentRow.Cells[1].Value.ToString();

            inputPower.Text = displayItemList.CurrentRow.Cells[2].Value.ToString();
            inputUsage.Text = displayItemList.CurrentRow.Cells[3].Value.ToString();
            inputCost.Text = displayItemList.CurrentRow.Cells[4].Value.ToString();
            inputType.Text = displayItemList.CurrentRow.Cells[5].Value.ToString();
            inputDescription.Text = displayItemList.CurrentRow.Cells[6].Value.ToString();
        }

        // display refresh button
        private void btnRrefresh_Click(object sender, EventArgs e)
        {
            displayItem();
            displayUser();
        }
    }
}
