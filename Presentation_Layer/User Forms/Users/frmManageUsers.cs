using Business_Layer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentation_Layer.User_Forms
{
    public partial class frmManageUsers : Form
    {

        private DataTable _dtUsers = new DataTable();
        private DataView _dvUsers = new DataView();

        public frmManageUsers()
        {
            InitializeComponent();
        }



        private void _RefreshUsers()
        {
            _dtUsers = clsUsers.GetAllUsers();

            if (_dtUsers.Rows.Count > 0)
            {
                _dvUsers = _dtUsers.DefaultView;
                dgvAllUsers.DataSource = _dvUsers;
                // Set Columns Names, Width.
                // UserID, PersonID, Username, CreatedDate,IsActive, Role
                foreach (DataGridViewColumn column in dgvAllUsers.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                
                
                dgvAllUsers.Columns[0].HeaderText = "User ID";
                dgvAllUsers.Columns[1].HeaderText = "Person ID";
                dgvAllUsers.Columns[2].HeaderText = "User Name";
                dgvAllUsers.Columns[3].HeaderText = "Full Name";

                dgvAllUsers.Columns[4].HeaderText = "Is Active?";
                dgvAllUsers.Columns[5].HeaderText = "Role";
                dgvAllUsers.Columns[6].HeaderText = "User Since";
            }
            lblRecords.Text = _dtUsers.Rows.Count.ToString();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();

            this.Hide();
            frm.ShowDialog();
            this.Show();
            _RefreshUsers();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.Text == "None")
            {
                _RefreshUsers();
                tbFilter.Visible = false;
                cbIsActive.Visible = false;
                cbRole.Visible = false;
                return;
            }


            tbFilter.Text = "";
            if (comboBox1.Text == "Role")
            {
                tbFilter.Visible = false;
                cbIsActive.Visible = false;
                cbRole.Visible = true;
                cbRole.SelectedIndex = 0;
            }
            else if (comboBox1.Text == "Is Active")
            {
                tbFilter.Visible = false;
                cbIsActive.Visible = true;
                cbRole.Visible = false;
                cbIsActive.SelectedIndex = 0;

            }
            else
            {
                tbFilter.Visible = true;
                cbIsActive.Visible = false;
                cbRole.Visible = false;
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
                case "User ID":
                    FilterName = "UserID";
                    break;
                case "Person ID":
                    FilterName = "PersonID";
                    break;
                case "Full Name":
                    FilterName = "FullName";
                    break;
                case "Is Active":
                    FilterName = "IsActive";
                    break;
                case "Role":
                    FilterName = "Role";
                    break;

                default:
                    break;
            }


            if (FilterName == "None" || string.IsNullOrEmpty(tbFilter.Text))
            {
                _RefreshUsers();
                return;
            }

            if (FilterName == "PersonID" || FilterName == "UserID")
            {
                _dvUsers.RowFilter = $"{FilterName} = {tbFilter.Text}";
            }
            else // For text filters like FirstName, LastName, and Gender
            {
                _dvUsers.RowFilter = $"{FilterName} LIKE '%{tbFilter.Text}%'";
            }

            lblRecords.Text = _dvUsers.Count.ToString();



        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (comboBox1.Text == "Person ID" || comboBox1.Text == "User ID")
            {
                e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            }

        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frmAddUser = new frmAddUpdateUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            this.Hide();
            frmAddUser.ShowDialog();
            this.Show();
            _RefreshUsers();
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.Find((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            if (User != null)
            {

                if (!User.IsActive)
                {
                    MessageBox.Show("User Is Already Blocked!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                User.IsActive = false;
                if (User.Save())
                {
                    MessageBox.Show("User Blocked Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsers();
                }
                else
                {
                    MessageBox.Show("Failed To Block The User.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsUsers User = clsUsers.Find((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            if (User != null)
            {
                if (User.IsActive)
                {
                    MessageBox.Show("User Is Already Active", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                User.IsActive = true;
                if (User.Save())
                {
                    MessageBox.Show("User Active Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshUsers();
                }
                else
                {
                    MessageBox.Show("Failed To Active The User.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frm = new frmShowUserInfo((int)dgvAllUsers.CurrentRow.Cells[0].Value, (int)dgvAllUsers.CurrentRow.Cells[1].Value);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterName = cbIsActive.Text;

            if (FilterName == "All")
            {
                _RefreshUsers();
                return;
            }

            // All,Users,Admins

            FilterName = FilterName == "Yes" ? "1" : "0";

            _dvUsers.RowFilter = $"IsActive = {FilterName}";
            lblRecords.Text = _dvUsers.Count.ToString();
        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterName = cbRole.Text;

            if (filterName == "All")
            {
                _RefreshUsers();
                return;
            }


            _dvUsers.RowFilter = $"Role LIKE '%{filterName}%'";
            lblRecords.Text = _dvUsers.Count.ToString();

        }
    }
}
