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
using static Presentation_Layer.User_Forms.People.frmAddUpdatePeople;

namespace Presentation_Layer.User_Forms.People.Controls
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {


        public int PersonID = -1;

        private bool _EnableFilter;
        public bool EnableFilter
        {
            get { return _EnableFilter; }
            set
            {
                _EnableFilter = value;
                panel1.Enabled = value;
            }
        }


        public void LoadPersonInfo(int newPersonID)
        {
            textBox1.Text = newPersonID.ToString();
            ctrlPersonInfo2.LoadInfo(newPersonID);
            PersonID = newPersonID;
            EnableFilter = false;
        }


        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            
            
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Required!");
                return;
            }

            int PersonID = Convert.ToInt32(textBox1.Text);

            if (!clsPeople.DoesPeopleExists(PersonID))
            {
                MessageBox.Show("Failed", "There No Person With This ID.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.PersonID = PersonID;
            ctrlPersonInfo2.LoadInfo(PersonID);
            EnableFilter = false;

            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            this.Hide();
            frm.OnAddPerson += AddNewPersonForm_PersonAdded;
            frm.ShowDialog();
            this.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewPersonForm_PersonAdded(object sender, EventArgsPersonID e)
        {
            int newPersonID = e.ID;

            textBox1.Text = newPersonID.ToString();
            ctrlPersonInfo2.LoadInfo(newPersonID);
            PersonID = newPersonID;
            
            
            EnableFilter = false;
        }

        private void ctrlPersonInfo2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ctrlPersonInfoWithFilter_Load(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfoWithFilter_Load_1(object sender, EventArgs e)
        {

        }

        private void ctrlPersonInfo2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
