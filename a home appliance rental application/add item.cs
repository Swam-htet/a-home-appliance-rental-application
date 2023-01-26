using System;
using System.Collections;
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
    public partial class add_item : Form
    {
        // oledb with microsoft access database 
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;

        

        public add_item()
        {
            InitializeComponent();
        }

        // add new item 
        private void btnAdd_Click(object sender, EventArgs e)
        {

            // input strings
            string name = inputName.Text;
            string power = inputPower.Text;
            string typical = inputTypical.Text;
            int cost = int.Parse(inputCost.Text);
            string type = inputType.Text;
            string description = inputDescription.Text;

            // checking appliance duplication 
            // check user from the database
            string check_item_query = String.Format("select `name` from `appliance` where `name` = '" + name + "' and  `type` = '"+type+"'");

            cmd = new OleDbCommand(check_item_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);

            // no duplicate item
            if (dt.Rows.Count == 0)
            {
                // query string 
                string add_query = String.Format("insert into `appliance` (`name`,`powerUsage`,`typicalUsage`,`runningCost`,`type`,`description`) values('{0}','{1}','{2}','{3}','{4}','{5}');", name, power, typical, cost,type,description);

                // create new item to the database
                cmd = new OleDbCommand(add_query, connect);
                ad = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                ad.Fill(dt);
                ad.Update(dt);
                MessageBox.Show("Adding new appliance Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("This appliance is already existed in the list.");
            }

            
        }
    }
}
