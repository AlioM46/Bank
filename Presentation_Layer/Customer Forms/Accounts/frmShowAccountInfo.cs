using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Customer_Forms.Accounts
{
    public partial class frmShowAccountInfo : Form
    {



        private string _AccountNumber = "";

        public frmShowAccountInfo(string AccountNumber)
        {
            InitializeComponent();
            _AccountNumber = AccountNumber;
        }

        private void frmShowAccountInfo_Load(object sender, EventArgs e)
        {
            if (_AccountNumber != "")
            {
                ctrlShowAccountInfo1.EnableFilter = false;
                ctrlShowAccountInfo1.LoadInfo(_AccountNumber);
            }
        }
    }
}
