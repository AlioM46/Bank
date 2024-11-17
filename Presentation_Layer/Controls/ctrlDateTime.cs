using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.Controls
{
    public partial class ctrlDateTime : UserControl
    {
        public ctrlDateTime()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); // 12-hour format with AM/PM
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlDateTime_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
