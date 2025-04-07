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

namespace Database_file_Handeling
{
    public partial class frmManageStudents : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\University.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;

        SqlDataAdapter adapter;
        DataSet ds;

        SqlDataReader reader;


        public frmManageStudents()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayAll()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Students";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds, "Students");

                dbView.DataSource = ds;
                dbView.DataMember = "Students";

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eish: " + ex);
            }
        }

        private void AddComboboxFill()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();


                string sql = "SELECT DegreeName FROM Degrees";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                while (reader.Read())
                {
                    cmbDegreeAdd.Items.Add(reader.GetValue(0));
                    cmbDegreeUpdate.Items.Add(reader.GetValue(0));
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Boxed out: " + ex);
            }
        }

        private void StudentIDUpdate()
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();


                string sql = "SELECT StudentID FROM Students";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                cmbStudID.Items.Clear();

                while (reader.Read())
                {
                    cmbStudID.Items.Add(reader.GetValue(0));
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Boxed out: " + ex);
            }

        }

        private void frmManageStudents_Load(object sender, EventArgs e)
        {
            DisplayAll();
            AddComboboxFill();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                string sql = "INSERT INTO Students (FirstName, LastName, DegreeName) VALUES (@name, @surname, @degree)";

                using (comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@name", txtNameAdd.Text);
                    comm.Parameters.AddWithValue("@surname", txtLastAdd.Text);
                    comm.Parameters.AddWithValue("@degree", cmbDegreeAdd.Text);
                    comm.ExecuteNonQuery();
                }

                conn.Close();

                DisplayAll();
                StudentIDUpdate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Doesn't ADD up: " + ex);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                string sql = "Update Students SET FirstName = @name, LastName = @surname, DegreeName = @degree WHERE StudentID = @id";

                using (comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@name", txtFirstUp.Text);
                    comm.Parameters.AddWithValue("@surname", txtLastUp.Text);
                    comm.Parameters.AddWithValue("@degree", cmbDegreeUpdate.Text);
                    comm.Parameters.AddWithValue("@id", cmbStudID.Text);
                    comm.ExecuteNonQuery();
                }

                conn.Close();

                DisplayAll();
                StudentIDUpdate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("UPDATE, youre wrong: " + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();


                string sql = "DELETE FROM Students WHERE StudentID = @id";

                using (comm = new SqlCommand(sql, conn))
                {
                    comm.Parameters.AddWithValue("@id", cmbStudID.Text);
                    comm.ExecuteNonQuery();
                }

                conn.Close();

                DisplayAll();
                StudentIDUpdate();

            }
            catch (Exception ex)
            {
                MessageBox.Show("DELETE, your brain at this point: " + ex);
            }
        }
    }
}
