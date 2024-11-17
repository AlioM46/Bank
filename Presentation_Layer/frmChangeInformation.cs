using Business_Layer;
using Presentation_Layer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms
{
    public partial class frmChangeInformation : Form
    {


        private bool IsUser = false;

        public frmChangeInformation(bool IsUser)
        {
            InitializeComponent();

            this.IsUser = IsUser;


        }
        private clsUsers ?CurrentUser = null;
        private clsCustomers ?CurrentCustomer = null;
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (!tbPassword.IsValid())
            {
                errorProvider1.SetError(tbPassword, "Required");
                return;
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }

            if (tbPassword.Text.Trim() != tbRePassword.Text.Trim())
            {
                errorProvider1.SetError(tbRePassword, "They Must Match!");
                return;
            }
            else
            {
                errorProvider1.SetError(tbRePassword, "");
            }


            if (IsUser)
            {


                CurrentUser = clsUsers.Find(clsGlobal.GlobalUser.UserID);

                if (CurrentUser == null)
                {
                    MessageBox.Show("Error During Searching The User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                CurrentUser.Password = clsGlobal.HashText(tbPassword.Text.Trim());

                if (!CurrentUser.Save())
                {
                    MessageBox.Show("Error Occured During Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Password Changing Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbPassword.Text = "";
                tbRePassword.Text = "";
                return;
            }

            CurrentCustomer = clsCustomers.Find(clsGlobal.GlobalCustomer.CustomerID);

            if (CurrentCustomer == null)
            {
                MessageBox.Show("Error During Searching The Customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrentCustomer.Password = clsGlobal.HashText(tbPassword.Text.Trim());

            if (!CurrentCustomer.Save())
            {
                MessageBox.Show("Error Occured During Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Password Changing Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbPassword.Text = "";
            tbRePassword.Text = "";


        }

        private void frmChangeInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
