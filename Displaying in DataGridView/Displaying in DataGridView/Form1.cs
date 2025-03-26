using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Add this sql client otherwise nothing (SQL-wise) will work
using System.Data.SqlClient;

namespace Displaying_in_DataGridView
{
    public partial class Form1 : Form
    {
        //Connecting to the database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Displaying in DataGridView\SomeData.mdf;Integrated Security=True");
        SqlCommand comm;

        SqlDataAdapter adapter;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGridview_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Something";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "Something");

                

                comm = new SqlCommand(sql,conn);

                conn.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            
            }
        }
    }
}
