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
    public partial class frmShowPersonInfo : Form
    {

        private int _ID = -1;
        public frmShowPersonInfo(int ID)
        {
            InitializeComponent();

            _ID = ID;
        }

        private void frmShowPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadInfo(_ID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
