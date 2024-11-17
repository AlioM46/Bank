using Business_Layer;
using Presentation_Layer.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms.Support
{
    public partial class frmSupportResponse : Form
    {

        private int TicketID = -1;
        private clsSupportTickets Ticket;
        public frmSupportResponse(int ticketID)
        {
            InitializeComponent();
            TicketID = ticketID;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Cannot Be Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ticket.LastResponse = textBox1.Text;
            Ticket.LastResponseDate = DateTime.Now;
            Ticket.LastResponserID = clsGlobal.GlobalUser.UserID;

            if (!Ticket.Save())
            {

                MessageBox.Show("Error During Save The Response", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Response Saved Successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox1.Text = "";


        }

        private void frmSupportResponse_Load(object sender, EventArgs e)
        {

            Ticket = clsSupportTickets.Find(TicketID);
            if (Ticket == null)
            {
                MessageBox.Show("Ticket Is Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblSubject.Text = Ticket.Subject;
            lblDescription.Text = Ticket.Description;




        }
    }
}
