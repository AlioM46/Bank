using Business_Layer;
using Microsoft.VisualBasic.ApplicationServices;
using Presentation_Layer.User_Forms.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms.Users.Controls
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public int UserID = -1;
        public clsUsers User;


        public void LoadInfo(int UserID)
        {

            User = clsUsers.Find(UserID);
            if (User != null)
            {
                lblRole.Text = User.Role == 2 ? "User" : "Admin";
                lblIsActive.Text = User.IsActive.ToString();
                lblCreatedDate.Text = User.CreatedDate.ToString();
                lblUserID.Text = User.UserID.ToString();
                lblUsername.Text = User.Username.ToString();




            }

        }

        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
