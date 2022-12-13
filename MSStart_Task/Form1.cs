using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace MSStart_Task
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_Load(object sender, EventArgs e)
        {
            dtgrd.DataSource = Getdtgrd(); //mathod called to show the sql, the creation of the function is bellow
        }
        private DataTable Getdtgrd() //method to bind data and show it in the controller
        {
            DataTable dtgrd = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (sqlConnection con = new sqlConnection(connString)) 
            {
                using (sqlCommand cmd = new sqlCommand("Select * from MStart_DB", con))
                {
                    con.open(); 
                }
            }


            return dtgrd;
        }
    }
}
