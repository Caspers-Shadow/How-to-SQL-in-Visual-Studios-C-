using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MDIs_and_Search
{
    public partial class frmList : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FastFood.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapter;
        DataSet ds;

        public frmList()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet(); 

                string sql = "SELECT * FROM Companies";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds,"Companies");

                dbView.DataSource = ds;
                dbView.DataMember = "Companies";

                MessageBox.Show("Success!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We can just start singing mamma mia at this point: "+ex);
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Companies WHERE Slogan LIKE '%@slogan%'";

                using (comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@slogan", txtPhrase.Text);
                    comm.ExecuteNonQuery();

                    adapter.SelectCommand = comm;
                    adapter.Fill(ds, "Companies");
                }                

                dbView.DataSource = ds;
                dbView.DataMember = "Companies";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We can just start singing mamma mia at this point: " + ex);
                return;
            }

        }
    }
}
