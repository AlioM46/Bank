using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms.Customers
{
    public partial class frmShowCustomerInfo : Form
    {

        public int CustomerID = -1;
        public int PersonID = -1;

        public frmShowCustomerInfo(int CustomerID, int PersonID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;
            this.PersonID = PersonID;
        }

        private void frmShowCustomerInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonInfo1.LoadInfo(PersonID);
            ctrlCustomerInfo1.LoadInfo(CustomerID);
        }
    }
}
