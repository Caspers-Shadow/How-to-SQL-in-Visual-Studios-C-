using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_file_Handeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageStudents students = new frmManageStudents();

            students.MdiParent = this;
            students.Show();
        }

        private void degreeOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDegreeOverview degree = new frmDegreeOverview();
            degree.MdiParent = this;
            degree.Show();
        }
    }
}
