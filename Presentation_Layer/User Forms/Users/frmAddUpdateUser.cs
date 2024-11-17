using Business_Layer;
using Presentation_Layer.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation_Layer.User_Forms.Users
{
    public partial class frmAddUpdateUser : Form
    {

        private int _ID = -1;

        public enum enMode { AddNew = 1, Update = 2 };

        private enMode _Mode;
        public clsUsers User;

        public frmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateUser(int iD)
        {
            InitializeComponent();
            _ID = iD;
            _Mode = enMode.Update;
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {



            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add New User";
                lblMode.Text = "Add New User";
                button1.Text = "Add New";
                User = new clsUsers();

            }
            else
            {
                this.Text = "Update User";
                lblMode.Text = "Update User";
                button1.Text = "Update";
                comboBox1.SelectedIndex = 0;
                LoadUserInfo();
            }



        }

        public void LoadUserInfo()
        {
            User = clsUsers.Find(_ID);
            if (User == null)
            {
                MessageBox.Show("User Is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonInfoWithFilter1.LoadPersonInfo(User.PersonID);
            //
            tbUserName.Text = User.Username;
            tbPassword.Text = "";
            tbRePassword.Text = "";
            string role = User.Role == 2 ? "User" : "Admin";
            comboBox1.SelectedIndex = comboBox1.FindString(role);
            chkIsActive.Checked = User.IsActive;
            lblUserID.Text = User.UserID.ToString();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ctrlPersonInfoWithFilter1.PersonID != -1)
            {
                if (_Mode == enMode.Update && User.PersonID == ctrlPersonInfoWithFilter1.PersonID)
                {
                    tabControl1.SelectedIndex = 1;
                    return;
                }

                if (clsUsers.IsThePersonAvailableToConnectWithUser(ctrlPersonInfoWithFilter1.PersonID))
                {
                    tabControl1.SelectedIndex = 1;

                }
                else
                {
                    MessageBox.Show("This Person Is Already Connected With Another User.", "This Person Is Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonInfoWithFilter1.EnableFilter = true;
                }

            }
        }



        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text.Length > 0)
            {
                if (tbPassword.Text != tbRePassword.Text)
                {
                    errorProvider1.SetError(tbRePassword, "Password's Is Not Matched");
                }
                else
                {
                    errorProvider1.SetError(tbRePassword, "");
                }
            }
        }

        private void tbRePassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
                return;

            User.Username = tbUserName.Text;
            // Hashed Password.
            User.Password = Global_Classes.clsGlobal.HashText(tbPassword.Text);
            User.IsActive = chkIsActive.Checked;
            User.PersonID = ctrlPersonInfoWithFilter1.PersonID;
            User.Role = comboBox1.Text == "User" ? (byte)2 : (byte)3;
            if (User.UserID == -1)
            {
                User.CreatedDate = DateTime.Now;
            }

            if (User.Save())
            {
                lblMode.Text = "Update User";
                this.Text = "Update User";
                _Mode = enMode.Update;
                lblUserID.Text = User.UserID.ToString();
                MessageBox.Show("User Operation Done Successfully.", "Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation has Failed.", "Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmation?", "Are You Sure To Close This Page?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ctrlPersonInfoWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {


            if (!tbUserName.IsValid())
            {
                errorProvider1.SetError(tbUserName, tbUserName.ErrorMessage);
                e.Cancel = true;
            }
            else if (clsUsers.IsUserNameAvailable(tbUserName.Text) == false && tbUserName.Text != User.Username)
            {
                errorProvider1.SetError(tbUserName, "User Name Is Already in Use!");
                e.Cancel = true; // Allow the control to lose focus

            }
            else
            {
                errorProvider1.SetError(tbUserName, "");
                e.Cancel = false;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {

            if (!tbPassword.IsValid())
            {
                errorProvider1.SetError(tbPassword, tbPassword.ErrorMessage);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
                e.Cancel = false;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (ctrlPersonInfoWithFilter1.PersonID != -1)
            {
                if (!clsUsers.IsThePersonAvailableToConnectWithUser(ctrlPersonInfoWithFilter1.PersonID))
                {

                    if (_Mode == enMode.Update && User.PersonID == ctrlPersonInfoWithFilter1.PersonID)
                    {
                        return;
                    }


                    MessageBox.Show("This Person Is Already Connected With Another Customer.", "This Person Is Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonInfoWithFilter1.EnableFilter = true;
                    e.Cancel = true;
                }
                else
                {
                    ctrlPersonInfoWithFilter1.EnableFilter = false;
                }


            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
