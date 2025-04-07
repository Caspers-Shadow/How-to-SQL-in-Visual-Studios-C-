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
    public partial class frmDegreeOverview : Form
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\University.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm, comm2;

        SqlDataReader reader, reader2;
        public frmDegreeOverview()
        {
            InitializeComponent();
        }

        private void frmDegreeOverview_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                string sql = "SELECT DegreeName, Length, ApplicableFields FROM Degrees";

                comm = new SqlCommand(sql, conn);
                reader = comm.ExecuteReader();

                lstOutput.Items.Clear();
                lstOutput.Items.Add("Degree Names\t\tLength(Yrs)\t\tFields");
                lstOutput.Items.Add("----------------------------------------------------------------------------------------");

                while (reader.Read())
                {
                    lstOutput.Items.Add(reader.GetValue(0) + "\t\t" + reader.GetValue(1) + "\t\t" + reader.GetValue(2) + "\t\t");
                }

                

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eish: " + ex);
                return;
            }

            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                string sql2 = "SELECT count(*) FROM Students WHERE DegreeName = 'BSC Computer Science'";

                comm2 = new SqlCommand(sql2, conn);
                reader2 = comm2.ExecuteReader();

                while (reader2.Read())
                {
                    lstOutput.Items.Add("Number of students enrolled in BSC Computer Science: " + reader2.GetValue(0));
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eish: " + ex);
                return;
            }
        }
    }
}
