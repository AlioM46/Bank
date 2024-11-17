using Business_Layer;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation_Layer.User_Forms.Customers
{
    public partial class frmAddEditCustomer : Form
    {

        public int CustomerID = -1;
        public enum enMode { AddNew = 1, Edit = 2 }
        public enMode Mode;

        public clsCustomers Customer;
        public frmAddEditCustomer(int CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            Mode = enMode.Edit;
        }


        public frmAddEditCustomer()
        {
            InitializeComponent();
            Mode = enMode.AddNew;

        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Customer";
                this.Text = "Add New Customer";
                button1.Text = "Add";
                Customer = new clsCustomers();
            }
            else
            {
                this.Text = "Update Customer";
                lblMode.Text = "Update Customer";
                button1.Text = "Update";
                _Load();
            }
        }


        private void _Load()
        {
            Customer = clsCustomers.Find(CustomerID);
            if (Customer == null)
            {
                MessageBox.Show("Customer Is Null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ctrlPersonInfoWithFilter1.LoadPersonInfo(Customer.PersonID);
            lblCreatedDate.Text = Customer.CreatedDate.ToString();
            lblCustomerID.Text = Customer.CustomerID.ToString();
            tbCustomerName.Text = Customer.CustomerName.ToString();
            chkIsActive.Checked = Customer.IsActive;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ctrlPersonInfoWithFilter1.PersonID != -1)
            {
                if (Mode == enMode.Edit)
                {
                    tabControl1.SelectedIndex = 1;
                    return;
                }

                if (clsCustomers.IsThePersonAvailableToConnectWithCustomer(ctrlPersonInfoWithFilter1.PersonID))
                {
                    tabControl1.SelectedIndex = 1;

                }
                else
                {
                    MessageBox.Show("This Person Is Already Connected With Another Customer.", "This Person Is Not Available", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonInfoWithFilter1.EnableFilter = true;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmation?", "Are You Sure To Close This Page?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public bool IsAllValid()
        {




            if (!tbCustomerName.IsValid())
            {
                errorProvider1.SetError(tbCustomerName, tbCustomerName.ErrorMessage);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbCustomerName, "");
            }

            if (!clsCustomers.IsCustomerNameAvailable(tbCustomerName.Text) && Customer.CustomerName != tbCustomerName.Text)
            {
                errorProvider1.SetError(tbCustomerName, "This Name Is Already Used, Try Another One.");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbCustomerName, "");
            }



            if (!tbPassword.IsValid())
            {
                errorProvider1.SetError(tbPassword, tbPassword.ErrorMessage);
                return false;
            }
            else
            {
                errorProvider1.SetError(tbPassword, "");
            }


            if (tbPassword.Text.Length > 0 && tbRePassword.Text != tbPassword.Text)
            {
                errorProvider1.SetError(tbRePassword, "Re-Password Is Not Match with Original Password!");
                return false;
            }
            else
            {
                errorProvider1.SetError(tbRePassword, "");
            }


            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (!IsAllValid())
                return;


            Customer.CustomerName = tbCustomerName.Text;
            Customer.Password = clsGlobal.HashText(tbPassword.Text);
            Customer.PersonID = ctrlPersonInfoWithFilter1.PersonID;
            if (Customer.CustomerID == -1)
            {
                Customer.CreatedDate = DateTime.Now;
            }
            Customer.IsActive = chkIsActive.Checked;


            if (Customer.Save())
            {
                lblMode.Text = "Update Customer";
                this.Text = "Update Customer";
                lblCreatedDate.Text = Customer.CreatedDate.ToString();
                lblCustomerID.Text = Customer.CustomerID.ToString();
                Mode = enMode.Edit;
                MessageBox.Show("Customer Operation Done Successfully.", "Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operation has Failed.", "Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

            if (ctrlPersonInfoWithFilter1.PersonID != -1)
            {
                if (!clsCustomers.IsThePersonAvailableToConnectWithCustomer(ctrlPersonInfoWithFilter1.PersonID))
                {

                    if (Mode == enMode.Edit && Customer.PersonID == ctrlPersonInfoWithFilter1.PersonID)
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
