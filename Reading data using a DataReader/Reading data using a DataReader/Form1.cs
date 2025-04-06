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

namespace Reading_data_using_a_DataReader
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TestDatabase.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataReader reader;   
        DataSet ds;
        SqlDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                MessageBox.Show("You connected!");

                conn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Issue detected: " + ex);
                return;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM ClientList";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "ClientList");

                dbView.DataSource = ds;
                dbView.DataMember = "ClientList";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot display in datagridview: "+ ex);
                return;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "SELECT * FROM ClientList";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                lstOutput.Items.Clear();
                lstOutput.Items.Add("ID\tNmae\tSurname\tEmail");
                lstOutput.Items.Add("------------------------------------------------------------------------");

                while (reader.Read())
                {
                    lstOutput.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot display in listbox: " + ex);
                return;
            }
        }
    }
}
