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

namespace MDI_and_datagridviews
{
    public partial class Form1 : Form
    {

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Film.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;

        SqlDataAdapter adapter;
        DataSet ds;

        SqlDataReader reader;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connStr);

                conn.Open();

                string sql = "SELECT DISTINCT Genre FROM Movie";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                cmbxGenre.Items.Clear();

                while (reader.Read())
                {
                    cmbxGenre.Items.Add(reader.GetValue(0));
                }

                MessageBox.Show("This Connection works!");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oh goodness here we go: " + ex);
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

                string sql = "SELECT * FROM Movie";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "Movie");

                dbView.DataSource = ds;
                dbView.DataMember = "Movie";                

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("How did you not do this: " + ex);
                return;
            }
        }

        private void btnGoodMovies_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Movie WHERE Rating > 3";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "Movie");

                dbView.DataSource = ds;
                dbView.DataMember = "Movie";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("How did you not do this: " + ex);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string sql = "SELECT MovieID, MovieName, Rating, Price  FROM Movie WHERE Genre LIKE '%" + cmbxGenre.SelectedItem + "%'";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                lstOutput.Items.Clear();

                lstOutput.Items.Add("ID\tMovie Name\tRating\tPrice");
                lstOutput.Items.Add("-----------------------------------------------------------------");

                while (reader.Read())
                {
                    lstOutput.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3) + "\t");
                }


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Almost got it: " + ex);
                return;
            }
        }
    }
}
