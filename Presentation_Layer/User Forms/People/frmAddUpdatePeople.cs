using Business_Layer;
using Presentation_Layer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms.People
{
    public partial class frmAddUpdatePeople : Form
    {

        public class EventArgsPersonID : EventArgs
        {
            public int ID;

            public EventArgsPersonID(int ID)
            {
                this.ID = ID;
            }
        }

        public event EventHandler<EventArgsPersonID> OnAddPerson;

        private int _ID = -1;


        public enum enMode
        {
            AddNew = 1,
            Update = 2
        }

        public string PersonImagePath = "";
        public string SourceImagePath = "";

        public clsPeople Person;

        public enMode Mode;

        public frmAddUpdatePeople()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
            Person = new clsPeople();
        }
        public frmAddUpdatePeople(int ID)
        {
            InitializeComponent();

            Mode = enMode.Update;
            _ID = ID;
        }

        private void frmAddUpdatePeople_Load(object sender, EventArgs e)
        {



            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            // Not Allowed 18- Age

            if (Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Person";

            }
            else
            {
                lblMode.Text = "Update Person";
                _LoadInfo();

            }
        }


        private void _LoadInfo()
        {
            Person = clsPeople.Find(_ID);

            if (Person == null)
            {
                MessageBox.Show("Person Is Null", "Could not Find The Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            tbFirstName.Text = Person.FirstName;
            tbSecondName.Text = Person.SecondName;
            tbThirdName.Text = Person.ThirdName;
            tbLastName.Text = Person.LastName;
            tbEmail.Text = Person.Email;
            tbAddress.Text = Person.Address;
            dateTimePicker1.Value = Person.DateOfBirth;
            lblID.Text = Person.PersonID.ToString();
            PersonImagePath = Person.ImagePath ?? "";




            if (!string.IsNullOrEmpty(PersonImagePath))
            {
                if (File.Exists(PersonImagePath))
                {
                    pictureBox1.ImageLocation = PersonImagePath;

                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Error", "Fill All Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            HandleImage(SourceImagePath);

            Person.FirstName = tbFirstName.Text;
            Person.SecondName = tbSecondName.Text;
            Person.ThirdName = tbThirdName.Text;
            Person.LastName = tbLastName.Text;
            Person.Email = tbEmail.Text;
            Person.Address = tbAddress.Text;
            Person.DateOfBirth = dateTimePicker1.Value;
            Person.ImagePath = PersonImagePath;
            Person.Gender = rbMale.Checked ? (byte)1 : (byte)2;


            if (Person.Save())
            {
                if (Mode == enMode.AddNew)
                {
                    lblID.Text = Person.PersonID.ToString();
                    Mode = enMode.Update;
                    lblMode.Text = "Update Person";

                }
                OnPersonAdded(Person.PersonID);


                MessageBox.Show("Done", "Person Created Successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Failed", "Failed To Create The Person.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void OnPersonAdded(int PersonID)
        {

            OnAddPerson?.Invoke(this, new EventArgsPersonID(PersonID));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Validating_Textbox(object sender, CancelEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (string.IsNullOrEmpty(textbox.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textbox, "Fill This Field");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textbox, "");

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbChange(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(PersonImagePath))
                return;



            if (rbMale.Checked)
            {
                pictureBox1.Image = Resources.man_icon;
            }
            else
            {
                pictureBox1.Image = Resources.woman_icon;
            }
        }


        public void HandleImage(string SourceImagePath)
        {

            if (string.IsNullOrEmpty(SourceImagePath))
            {
                if (rbMale.Checked)
                {
                    SourceImagePath = @"C:\Users\aliom\OneDrive\Desktop\man-icon.png";
                }
                else
                {
                    SourceImagePath = @"C:\Users\aliom\OneDrive\Desktop\woman-icon.png";
                }

            }


            if (!string.IsNullOrEmpty(Person.ImagePath))
            {
                if (File.Exists(Person.ImagePath))
                {
                    File.Delete(Person.ImagePath);
                }
                Person.ImagePath = "";
                PersonImagePath = "";
            }

            // Define the directory path
            string destinationFolder = @"C:\Bank-Images";

            // Ensure the directory exists, create it if it doesn't
            if (!Directory.Exists(destinationFolder))
            {
                Directory.CreateDirectory(destinationFolder);
            }

            // Generate a unique file name using a GUID and keep the original extension
            string fileExtension = Path.GetExtension(SourceImagePath);
            string uniqueFileName = Guid.NewGuid().ToString() + fileExtension;
            string destinationFilePath = Path.Combine(destinationFolder, uniqueFileName);


            // Copy the image to the destination with the new name

            File.Copy(SourceImagePath, destinationFilePath, overwrite: true);
            PersonImagePath = destinationFilePath;
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SourceImagePath = openFileDialog.FileName;
                    pictureBox1.ImageLocation = SourceImagePath;

                }
            }
        }

        private void btnResetImg_Click(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                pictureBox1.Image = Resources.man_icon;
            }
            else
            {
                pictureBox1.Image = Resources.woman_icon;
            }

            PersonImagePath = "";
            SourceImagePath = "";

        }


    }
}
