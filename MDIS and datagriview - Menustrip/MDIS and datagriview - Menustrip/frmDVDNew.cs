using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Dont forget to add this
using System.Data.SqlClient;

namespace MDIS_and_datagriview___Menustrip
{
    public partial class frmDVDNew : Form
    {
        //|DataDirectory| ensures that the database can work on multiple computers and not tied to one directory
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapter;
        DataSet ds;

        public frmDVDNew()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                //Uses LIKE to get the value where the movies are action movies
                string sql = "SELECT * FROM DVDs WHERE Type LIKE '%ACT%'";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "DVDs");

                dbView.DataMember = "DVDs";
                dbView.DataSource = ds;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Captain we are going down x2: " + ex);
                return;
            }

        }

        private void frmDVDNew_Load(object sender, EventArgs e)
        {
            try
            {
                //Establishes connection
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM DVDs ";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "DVDs");

                dbView.DataMember = "DVDs";
                dbView.DataSource = ds;

                MessageBox.Show("Database loaded!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Captain we are going down: " + ex);
                return;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                //Gives the scrollbare attributes 
                scbAge.Minimum = 0;
                scbAge.Maximum = 18;
                scbAge.LargeChange = 0;
                scbAge.SmallChange = 0;


                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                //Dynamically updatesthe label and database
                string sql = "SELECT * FROM DVDs WHERE Age <= '" + scbAge.Value + "' ORDER BY Age DESC";
                lblAge.Text = scbAge.Value.ToString();

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "DVDs");

                dbView.DataMember = "DVDs";
                dbView.DataSource = ds;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Captain we are going down x2: " + ex);
                return;
            }
        }
    }
}
