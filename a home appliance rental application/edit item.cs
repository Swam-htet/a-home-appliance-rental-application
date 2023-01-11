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


    public partial class edit_item : Form
    {

        // oledb with microsoft access database 
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;

        public edit_item()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // input string
            string searchID = inputSearch.Text;
            string change = inputChange.Text;
            string choose = inputChoose.Text;

            // query string 
            string edit_query = String.Format("update `appliance` set `{0}` = `{1}` where `id` = `{2}` ;",choose,change,searchID);

            // lack of search item





            cmd = new OleDbCommand(edit_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();

            ad.Fill(dt);
            ad.Update(dt);
            MessageBox.Show("Editing the appliance Successful");
        }
    }
}
