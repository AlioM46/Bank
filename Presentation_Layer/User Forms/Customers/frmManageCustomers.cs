using Business_Layer;
using Presentation_Layer.User_Forms.Customers;
using Presentation_Layer.User_Forms.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Presentation_Layer.Global_Classes.clsGlobal;

namespace Presentation_Layer.User_Forms
{
    public partial class frmManageCustomers : Form
    {
        public frmManageCustomers()
        {
            InitializeComponent();
        }

        private void frmManageCustomers_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            _RefreshCustomers();

        }


        private DataTable _dtCustomers = new DataTable();
        private DataView _dvCustomers = new DataView();



        private void _RefreshCustomers()
        {
            _dtCustomers = clsCustomers.GetAllCustomers();

            if (_dtCustomers.Rows.Count > 0)
            {
                _dvCustomers = _dtCustomers.DefaultView;
                dgvAllCustomers.DataSource = _dvCustomers;
                // Set Columns Names, Width.
                // UserID, PersonID, Username, CreatedDate,IsActive, Role
                foreach (DataGridViewColumn column in dgvAllCustomers.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                dgvAllCustomers.Columns[0].HeaderText = "Customer ID";
                dgvAllCustomers.Columns[1].HeaderText = "Person ID";
                dgvAllCustomers.Columns[2].HeaderText = "Customer Name";
                dgvAllCustomers.Columns[3].HeaderText = "Is Active?";
                dgvAllCustomers.Columns[4].HeaderText = "Customer Since";

                lblRecords.Text = _dtCustomers.Rows.Count.ToString();
            }


        }














        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "None")
            {
                _RefreshCustomers();
                tbFilter.Visible = false;
                cbIsActive.Visible = false;
                return;
            }


            tbFilter.Text = "";

            if (comboBox1.Text == "Is Active")
            {
                tbFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.SelectedIndex = 0;

            }
            else
            {
                tbFilter.Visible = true;
                cbIsActive.Visible = false;
            }
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {


            string FilterName = "";

            switch (comboBox1.Text)
            {

                case "None":
                    FilterName = "None";
                    break;
                case "Customer ID":
                    FilterName = "CustomerID";
                    break;
                case "Person ID":
                    FilterName = "PersonID";
                    break;
                case "Customer Name":
                    FilterName = "CustomerName";
                    break;
                default:
                    break;
            }


            if (FilterName == "None" || string.IsNullOrEmpty(tbFilter.Text))
            {
                _RefreshCustomers();
                return;
            }

            if (FilterName == "PersonID" || FilterName == "CustomerID")
            {
                _dvCustomers.RowFilter = $"{FilterName} = {tbFilter.Text}";
            }
            else // For text filters like FirstName, LastName, and Gender
            {
                _dvCustomers.RowFilter = $"{FilterName} LIKE '%{tbFilter.Text}%'";
            }

            lblRecords.Text = _dvCustomers.Count.ToString();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.Text == "Person ID" || comboBox1.Text == "Customer ID")
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshCustomers();
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsCustomers Customer = clsCustomers.Find((int)dgvAllCustomers.CurrentRow.Cells[0].Value);
            if (Customer != null)
            {

                if (!Customer.IsActive)
                {
                    MessageBox.Show("Customer Is Already Blocked!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Customer.IsActive = false;
                if (Customer.Save())
                {


                    MessageBox.Show("Customer Blocked Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCustomers();
                }
                else
                {
                    MessageBox.Show("Failed To Block The Customer.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsCustomers Customer = clsCustomers.Find((int)dgvAllCustomers.CurrentRow.Cells[0].Value);
            if (Customer != null)
            {
                if (Customer.IsActive)
                {
                    MessageBox.Show("Customer Is Already Active", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Customer.IsActive = true;
                if (Customer.Save())
                {
                    MessageBox.Show("Customer Active Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshCustomers();
                }
                else
                {
                    MessageBox.Show("Failed To Active The Customer.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterName = cbIsActive.Text;

            if (FilterName == "All")
            {
                _RefreshCustomers();
                return;
            }

            // All,Active, !Active.

            FilterName = FilterName == "Yes" ? "1" : "0";

            _dvCustomers.RowFilter = $"IsActive = {FilterName}";
            lblRecords.Text = _dvCustomers.Count.ToString();
        }


        private void viewCustomerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCustomerInfo frm = new frmShowCustomerInfo((int)dgvAllCustomers.CurrentRow.Cells[0].Value, (int)dgvAllCustomers.CurrentRow.Cells[1].Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditCustomer frm = new frmAddEditCustomer((int)dgvAllCustomers.CurrentRow.Cells[0].Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshCustomers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete This Customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            int CustomerID = (int)dgvAllCustomers.CurrentRow.Cells[0].Value;

            if(clsCustomers.Delete(CustomerID))
            {
                MessageBox.Show("Customer Deleted Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshCustomers();
            } else
            {
                MessageBox.Show("Failed To Delete The Customer", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
