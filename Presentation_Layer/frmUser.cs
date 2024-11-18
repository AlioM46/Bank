using Business_Layer;
using Presentation_Layer.Global_Classes;
using Presentation_Layer.User_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        public void HandleForms(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleForms(new frmManageUsers());
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleForms(new frmPeople());

        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleForms(new frmManageCustomers());

        }

        private void manageApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleForms(new frmManageApplications());

        }

        private void supportTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HandleForms(new frmSupportTickets());

        }

        private void changeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // This Will Expose - User Control - 
            HandleForms(new frmChangeInformation(true));

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }


        private void frmUser_Load(object sender, EventArgs e)
        {
            
            pictureBox1.ImageLocation = Global_Classes.clsGlobal.GlobalUser.People.ImagePath;

            // Make the PictureBox circular
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Width = 100;  // Set width (make sure height is the same for a square)
            pictureBox1.Height = 100; // Set height (same as width for a square)



            if (clsGlobal.Role == clsGlobal.enRole.User)
            {
                manageUsersToolStripMenuItem.Visible = false;
            }
        }

        private void enterDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Logout", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;

            this.Close();
            clsGlobal.GlobalUser = null;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
