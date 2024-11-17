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

namespace Presentation_Layer.Customer_Forms.Loans
{
    public partial class frmLoansManagement : Form
    {

        private DataTable _dt = new DataTable();

        public frmLoansManagement()
        {
            InitializeComponent();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddNewLoan frm = new frmAddNewLoan();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshDataGrid();
        }

        private void _RefreshDataGrid()
        {
            _dt = clsLoans.GetAllLoans();

            if (_dt.Rows.Count > 0)
            {




                dgvAllLoans.DataSource = _dt;
                dgvAllLoans.Columns[0].HeaderText = "Loan ID";
                dgvAllLoans.Columns[1].HeaderText = "Application ID";
                dgvAllLoans.Columns[2].HeaderText = "Amount";
                dgvAllLoans.Columns[3].HeaderText = "Start Date";
                dgvAllLoans.Columns[4].HeaderText = "End Date";
                dgvAllLoans.Columns[5].HeaderText = "Loan Type";
                dgvAllLoans.Columns[6].HeaderText = "All Payments";
                dgvAllLoans.Columns[7].HeaderText = "Status";
                dgvAllLoans.Columns[8].HeaderText = "Number of Days";
                dgvAllLoans.Columns[9].HeaderText = "Last Update";
                foreach (DataGridViewColumn column in dgvAllLoans.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            lblRecords.Text = _dt.Rows.Count.ToString();

        }


        private void frmLoansManagement_Load(object sender, EventArgs e)
        {
            _RefreshDataGrid();
        }

        private void payToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanPayment frm = new frmLoanPayment((int)dgvAllLoans.CurrentRow.Cells[0].Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshDataGrid();

        }

        private void cLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Cancel This Loan?", "Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;


            clsLoans Loan = clsLoans.Find((int)dgvAllLoans.CurrentRow.Cells[0].Value);


            if (Loan.Status == (int)clsLoans.enLoanStatus.Closed)
            {
                MessageBox.Show("Loan Already Cancelled.", "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (Loan.Status != (int)clsLoans.enLoanStatus.InRepayment && Loan.Status != (int)clsLoans.enLoanStatus.Pending)
            {
                // Should Handle this Later, Get the Money from The Account, To CLoSe IT.

                MessageBox.Show("Cannot Cancel This Loan.", "Cannot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


            // so now it's (InRepayment) or Pending Mode.

            Loan.Status = (int)clsLoans.enLoanStatus.Closed;


            if (Loan.Save())
            {
                MessageBox.Show("Loan Cancelled Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataGrid();
                return;
            }
            else
            {
                MessageBox.Show("Failed To Cancel The Loan.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            clsLoans Loan = clsLoans.Find((int)dgvAllLoans.CurrentRow.Cells[0].Value);

            if (Loan == null)
            {
                MessageBox.Show("Could not Found the Loan", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            if (Loan.Status != (int)clsLoans.enLoanStatus.InRepayment)
            {
                payToolStripMenuItem.Enabled = false;
                return;
            }
            else
                payToolStripMenuItem.Enabled = true;
            {
            }
        }
    }
}
