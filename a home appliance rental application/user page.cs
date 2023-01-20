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
using System.Xml.Linq;


namespace a_home_appliance_rental_application
{
    public partial class user_page : Form
    {
        // total charge
        int total_charge = 0;

        // variable for add cart button
        string cart_price,cart_name;
        

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
            clearCart();
            this.Hide();
            new login().Show();
        }

        // form load
        private void user_page_Load(object sender, EventArgs e)
        {
            displayItem();

            displayCart();


        }

        // display cart
        private void displayCart()
        {
            string display_string = String.Format("select * from `cart`;");
            cmd = new OleDbCommand(display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            cart_table.DataSource = dt;
        }

        //display item function
        private void displayItem()
        {
            string display_string = String.Format("select * from `appliance` order by `ID`;");
            cmd = new OleDbCommand(display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            userDisplay.DataSource = dt;
        }

        // display item button 
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            displayItem();
        }

       
        // sort item with energy consumption 
        private void btnSort_Click(object sender, EventArgs e)
        {
            string sort_display_string = String.Format("select * from `appliance` order by `powerUsage` desc;");
            cmd = new OleDbCommand(sort_display_string, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            userDisplay.DataSource = dt;
        }


        // search item with type 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search_item_type = inputSearch.Text;
            string search_item_query = String.Format("select * from `appliance` where `type` = '{0}';",search_item_type);
            cmd = new OleDbCommand(search_item_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            userDisplay.DataSource = dt;


        }


        private void clearCart()
        {
            // query string 
            string add_query = String.Format("Delete from `cart`");

            // create new item to the database
            cmd = new OleDbCommand(add_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            ad.Update(dt);

        }


        // add to the shopping cart button
        private void btnCart_Click(object sender, EventArgs e)
        {
            // from user input
            int cart_quantity = Int32.Parse(inputCartQuantity.Text);
            int cart_duration = Int32.Parse(inputCartDuration.Text);

            int cart_total = Int32.Parse(cart_price) * cart_quantity * cart_duration;
            total_charge += cart_total;

            // query string 
            string add_query = String.Format("insert into `cart` (`id`,`name`,`quantity`,`month`,`price`,`total`) values('{0}','{1}','{2}','{3}','{4}','{5}');", inputCartID.Text, cart_name, cart_quantity, cart_duration, cart_price, cart_total);

            // create new item to the database
            cmd = new OleDbCommand(add_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            ad.Update(dt);

            displayCart();
        }

        // calculate total price 
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total charge : " + total_charge);
        }

        // cell enter 
        private void userDisplay_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // from table click
            inputCartID.Text = userDisplay.CurrentRow.Cells[0].Value.ToString();
            cart_name = userDisplay.CurrentRow.Cells[1].Value.ToString();
            cart_price = userDisplay.CurrentRow.Cells[4].Value.ToString();
            InputCartPrice.Text = cart_price;

        }
    }
}
