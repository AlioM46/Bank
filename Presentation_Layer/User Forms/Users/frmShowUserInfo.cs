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

namespace Presentation_Layer.User_Forms.Users
{
    public partial class frmShowUserInfo : Form
    {

        public int UserID = -1;
        public int PersonID = -1;
        public frmShowUserInfo(int UserID, int PersonID)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.PersonID = PersonID;

        }




        private void frmShowUserInfo_Load(object sender, EventArgs e)
        {
            ctrlUserInfo1.LoadInfo(UserID);
            ctrlPersonInfo1.LoadInfo(PersonID);
        }

        private void ctrlUserInfo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
