using Business_Layer;
using Presentation_Layer.User_Forms.People;
using Presentation_Layer.User_Forms.Users;
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
    public partial class frmPeople : Form
    {
        private DataTable _dtPeople = new DataTable();
        private DataView _dvPeople = new DataView();
        public frmPeople()
        {
            InitializeComponent();
        }


        private void _RefreshPeople()
        {
            _dtPeople = clsPeople.GetAllPeople();

            if (_dtPeople.Rows.Count > 0)
            {
                _dvPeople = _dtPeople.DefaultView;
                dgvAllPeople.DataSource = _dvPeople;


                foreach (DataGridViewColumn column in dgvAllPeople.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }



                dgvAllPeople.Columns[0].HeaderText = "Person ID";
                dgvAllPeople.Columns[1].HeaderText = "First Name";
                dgvAllPeople.Columns[2].HeaderText = "Second Name";
                dgvAllPeople.Columns[3].HeaderText = "Third Name";
                dgvAllPeople.Columns[4].HeaderText = "Last Name";
                dgvAllPeople.Columns[5].HeaderText = "Date Of Birth";
                dgvAllPeople.Columns[6].HeaderText = "Email";
                dgvAllPeople.Columns[7].HeaderText = "Address";
                dgvAllPeople.Columns[8].HeaderText = "Gender";
                dgvAllPeople.Columns[9].HeaderText = "Image Profile Path";
            }
            lblRecords.Text = _dtPeople.Rows.Count.ToString();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            _RefreshPeople();
            comboBox1.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshPeople();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshPeople();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Delete.


            clsPeople TempPerson = clsPeople.Find((int)dgvAllPeople.CurrentRow.Cells[0].Value);

            string ImageLocation = "";

            if (TempPerson != null)
            {
                ImageLocation = TempPerson.ImagePath;
            }



            if (MessageBox.Show("Warning!", "Are You Sure To Delete This Person?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;

            if (clsPeople.DeletePeople((int)dgvAllPeople.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("Done", "Person Deleted Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                if (File.Exists(ImageLocation))
                {
                    File.Delete(ImageLocation);
                }

                _RefreshPeople();



            }
            else
            {
                MessageBox.Show("Failed", "Failed To Delete Person.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void viewUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // View Person Info.
            frmShowPersonInfo frm = new frmShowPersonInfo((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshPeople();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "None")
            {
                _RefreshPeople();
                return;
            }

            tbFilter.Text = "";


        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {



            string FilterName = "";

            switch (comboBox1.Text)
            {

                case "None":
                    FilterName = "None";
                    break;
                case "Person ID":
                    FilterName = "PersonID";
                    break;
                case "First Name":
                    FilterName = "FirstName";
                    break;
                case "Last Name":
                    FilterName = "LastName";
                    break;
                case "Gender":
                    FilterName = "Gender";
                    break;

                default:
                    break;
            }


            if (FilterName == "None" || string.IsNullOrEmpty(tbFilter.Text))
            {
                _RefreshPeople();
                return;
            }

            if (FilterName == "PersonID")
            {
                _dvPeople.RowFilter = $"{FilterName} = {tbFilter.Text}";
            }
            else // For text filters like FirstName, LastName, and Gender
            {
                _dvPeople.RowFilter = $"{FilterName} LIKE '%{tbFilter.Text}%'";
            }

            lblRecords.Text = _dvPeople.Count.ToString();



        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBox1.Text == "Person ID")
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            }

        }

    }
}
