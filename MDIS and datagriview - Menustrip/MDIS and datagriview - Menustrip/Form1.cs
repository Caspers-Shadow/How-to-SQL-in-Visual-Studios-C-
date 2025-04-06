using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIS_and_datagriview___Menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exits the entire application
            Application.Exit();
        }

        private void listDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Makes the new form a child to this form
            frmDVDNew newDVD = new frmDVDNew();

            newDVD.MdiParent = this;
            newDVD.Show();
        }
    }
}
