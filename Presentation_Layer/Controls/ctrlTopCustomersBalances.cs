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

namespace Presentation_Layer.Controls
{
    public partial class ctrlTopCustomersBalances : UserControl
    {
        public ctrlTopCustomersBalances()
        {
            InitializeComponent();
        }

        private void gb1_Enter(object sender, EventArgs e)
        {

        }

        public void DisplayTop5Balances()
        {
            DataTable customers = clsCustomers.GetTop5CustomerBalance();
            int counter = 0;
            int verticalSpacing = 30; // Spacing between each row of labels

            foreach (DataRow row in customers.Rows)
            {
                counter++;

                // Create label for Customer Name
                Label lb = new Label();
                lb.Text = $"{counter} - {row["CustomerName"].ToString()}";
                lb.AutoSize = true;
                lb.Font = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Bold); // Set font size and style
                lb.Location = new System.Drawing.Point(40, 60 + (counter - 1) * verticalSpacing);

                // Create label for Balance
                Label lb2 = new Label();
                lb2.Text = "$" + Convert.ToDecimal(row["Money"]).ToString("N2");
                lb2.AutoSize = true;
                lb2.Font = new System.Drawing.Font("Arial", 18, System.Drawing.FontStyle.Regular); // Set font size and style
                lb2.Location = new System.Drawing.Point(300, 60 + (counter - 1) * verticalSpacing); // Offset for alignment with lb

                // Add labels to group box
                gb1.Controls.Add(lb);
                gb1.Controls.Add(lb2);
            }
        }

        private void ctrlTopCustomersBalances_Load(object sender, EventArgs e)
        {

        }
    }
}
