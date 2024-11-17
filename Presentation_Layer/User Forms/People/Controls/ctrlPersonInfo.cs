using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms.People.Controls
{
    public partial class ctrlPersonInfo : UserControl
    {
        public ctrlPersonInfo()
        {
            InitializeComponent();
        }

        public int ID = -1;

        public clsPeople Person = new clsPeople();

        public void LoadInfo(int PersonID) { 
        

            Person = clsPeople.Find(PersonID);
            if (Person == null) {
                MessageBox.Show("Person Is Null", "Could not Find The Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ID = PersonID; 

            lblFirstName.Text = Person.FirstName;
            lblSecondName.Text = Person.SecondName;
            lblThirdName.Text = Person.ThirdName;
            lblLastName.Text = Person.LastName;
            lblEmail.Text = Person.Email;
            lblAddress.Text = Person.Address;
            lblDateOfBirth.Text = Person.DateOfBirth.ToString();
            lblPersonID.Text = Person.PersonID.ToString();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
        }

        private void lblUpdatePerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople(ID);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            LoadInfo(ID);
        }
    }
}
