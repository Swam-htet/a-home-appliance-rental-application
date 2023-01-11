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
    public partial class delete_item : Form
    {
        // oledb with microsoft access database 
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alpharJustACode\Documents\a home appliance rental application.accdb");
        DataTable dt;
        OleDbCommand cmd;
        OleDbDataAdapter ad;

        public delete_item()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string search = inputSearch.Text;
            string type = comboChoose.Text;

            // query string 
            string delete_query = String.Format("delete from `appliance` where `{0}` like \"%`{1}`%\";",type,search);


            // lack of delete search item



            cmd = new OleDbCommand(delete_query, connect);
            ad = new OleDbDataAdapter(cmd);
            dt = new DataTable();
            ad.Fill(dt);
            ad.Update(dt);
            MessageBox.Show("Deleting appliance Successful");
        }
    }
}
