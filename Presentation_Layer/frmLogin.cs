using Business_Layer;
using Presentation_Layer.CustomControls;
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

namespace Presentation_Layer.LoginForm
{
    public partial class frmLogin : Form
    {


        public void AutoLogin(string UserType)
        {
            string userName, password;
            clsGlobal.GetRememberMeCredentials(out userName, out password, UserType);

            if (UserType == "Customer")
            {
                tbPasswordLogin.Text = password;
                tbCustomerNameLogin.Text = userName;
            }
            if (UserType == "User")
            {
                tbPasswordUserLogin.Text = password;
                tbUserNameLogin.Text = userName;
            }

        }


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(null, null);
            tbPasswordLogin.MinCharLength = 4;
            tbPasswordLogin.Pattern = ctrlTextBoxValidation.enPattern.Password;

            tbPasswordUserLogin.MinCharLength = 4;
            tbPasswordUserLogin.Pattern = ctrlTextBoxValidation.enPattern.Password;


            tbUserNameLogin.MinCharLength = 4;
            tbUserNameLogin.Pattern = ctrlTextBoxValidation.enPattern.Username;

            tbCustomerNameLogin.MinCharLength = 4;
            tbCustomerNameLogin.Pattern = ctrlTextBoxValidation.enPattern.Username;

        }

        private void ctrlTextBoxValidation1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxValidation(object sender, CancelEventArgs e)
        {



            //ctrlTextBoxValidation Object = (ctrlTextBoxValidation)sender;

            //if (Object == null)
            //{
            //    return;
            //}

            //if (!Object.IsValid())
            //{
            //    errorProvider1.SetError(Object, "This Field Is Requirement.");
            //    e.Cancel = true;
            //}
            //else
            //{
            //    errorProvider1.SetError(Object, "");
            //    e.Cancel = false;
            //}




        }


        public void StartMainForm(Form frm)
        {
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        public bool IsValid()
        {
            if (!tbCustomerNameLogin.IsValid())
            {
                errorProvider1.SetError(tbCustomerNameLogin, tbCustomerNameLogin.ErrorMessage);
                return false;
            } else
            {
                errorProvider1.SetError(tbCustomerNameLogin, "");
            }
            if (!tbPasswordLogin.IsValid())
            {
                errorProvider1.SetError(tbPasswordLogin, tbPasswordLogin.ErrorMessage);
                return false;
            } else
            {
                errorProvider1.SetError(tbPasswordLogin, "");
            }

            return true;
        }

        private void btnCustomerLogin_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }



            if (!clsCustomers.DoesCustomersExists(tbCustomerNameLogin.Text.Trim(), clsGlobal.HashText(tbPasswordLogin.Text.Trim())))
            {
                MessageBox.Show("This Customer Does Not Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (!clsCustomers.Find(tbCustomerNameLogin.Text.Trim(), clsGlobal.HashText(tbPasswordLogin.Text.Trim())).IsActive)
            {
                MessageBox.Show("This Customer Has Been Blocked, Call The Admin.", "BLOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!clsGlobal.CustomerLogin(tbCustomerNameLogin.Text.Trim(), tbPasswordLogin.Text.Trim(), chkRememberMeCustomer.Checked))
            {
                MessageBox.Show("Some Errors Occurred During Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartMainForm(new frmCustomer());

        }

        private void chkRememberMeUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRememberMeCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }

        public bool IsUserValid()
        {
            if (!tbUserNameLogin.IsValid())
            {
                errorProvider1.SetError(tbUserNameLogin, tbUserNameLogin.ErrorMessage);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbUserNameLogin, "");
            }


            if (!tbPasswordUserLogin.IsValid())
            {
                errorProvider1.SetError(tbPasswordUserLogin, tbPasswordUserLogin.ErrorMessage);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbPasswordUserLogin, "");
            }

            return true;
        }

        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            if (!IsUserValid())
            {
                return;
            }

            if (!clsUsers.DoesUsersExists(tbUserNameLogin.Text.Trim(), clsGlobal.HashText(tbPasswordUserLogin.Text.Trim())))
            {
                MessageBox.Show("Invalid Username Or Password", "Try Again.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if (!clsUsers.Find(tbUserNameLogin.Text.Trim(), clsGlobal.HashText(tbPasswordUserLogin.Text.Trim())).IsActive)
            {

                MessageBox.Show("This User Has Been Blocked, Call The Admin.", "BLOCK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!clsGlobal.UserLogin(tbUserNameLogin.Text.Trim(), tbPasswordUserLogin.Text.Trim(), chkRememberMeUser.Checked))
            {
                MessageBox.Show("Some Errors Occurred During Login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            StartMainForm(new frmUser());
        }

        private void tpAdminLogin_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0 && chkRememberMeCustomer.Checked)
            {

                AutoLogin("Customer");

            }
            else if (tabControl1.SelectedIndex == 1 && chkRememberMeUser.Checked)
            {
                AutoLogin("User");
            }
        }

        private void tbPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
