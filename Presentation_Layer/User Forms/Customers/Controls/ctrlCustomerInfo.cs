using Azure.Identity;
using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms.Customers.Controls
{
    public partial class ctrlCustomerInfo : UserControl
    {
        public ctrlCustomerInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo(int CustomerID)
        {
            clsCustomers customer = clsCustomers.Find(CustomerID);
            if (customer == null)
            {
                MessageBox.Show("Customer ID Is Not Correct.", "Not Available!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCreatedDate.Text = customer.CreatedDate.ToString();
            lblCustomerID.Text = customer.CustomerID.ToString();
            lblCustomerName.Text = customer.CustomerName.ToString();
            checkBox1.Checked = customer.IsActive;
            lblPersonID.Text = customer.PersonID.ToString();

        }

        private void ctrlCustomerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
