using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Adding_a_database__WebApps_
{
    public partial class Kennel : System.Web.UI.Page
    {
        string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Kennel.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adapter;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT HouseID, PetName, PetType FROM PetInfo";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds);

                gvView.DataSource = ds;
                gvView.DataBind();
            }

            catch (Exception ex)
            {
                gvView.Visible = false;
                lblError.Text = "Error: " + ex.Message;
                return;
            }
        }

        protected void btnLarge_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(conStr);
                conn.Open();

                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT HouseID, PetName FROM PetInfo WHERE PetSize LIKE '%Large%'";

                comm = new SqlCommand(sql, conn);

                adapter.SelectCommand = comm;
                adapter.Fill(ds);

                gvView.DataSource = ds;
                gvView.DataBind();
            }

            catch (Exception ex)
            {
                gvView.Visible = false;
                lblError.Text = "Error: " + ex.Message;
                return;
            }
        }
    }
}