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

namespace Presentation_Layer.Customer_Forms
{
    public partial class frmSupport : Form
    {

        private clsSupportTickets Ticket = new clsSupportTickets();
        DataTable dt = new DataTable();

        public frmSupport()
        {
            InitializeComponent();
            panel1.AutoScroll = true;  // Enable AutoScroll on the panel

        }

        private string FilterName = "";


        private void _RefreshPanel()
        {
            dt = clsSupportTickets.GetAllSupportTicketsForCustomer(clsGlobal.GlobalCustomer.CustomerID);

            int yPosition = 10;  // Start Y position for the first label

            foreach (DataRow row in dt.Rows)
            {
                // Create a new label for Subject
                Label subjectLabel = new Label();
                subjectLabel.Text = "Subject: " + row["Subject"].ToString();  // Concatenate "Subject" with the actual value
                subjectLabel.Font = new Font("Arial", 16, FontStyle.Bold);  // Make the subject bold for emphasis
                subjectLabel.Location = new Point(10, yPosition);  // Set dynamic Y position
                subjectLabel.AutoSize = true;  // Automatically adjust size to fit text
                this.panel1.Controls.Add(subjectLabel);

                yPosition += 30;  // Increment Y position for next label

                // Create a new label for Description
                Label descriptionLabel = new Label();
                descriptionLabel.Text = "Description: " + row["Description"].ToString();  // Concatenate "Description" with the actual value
                descriptionLabel.Font = new Font("Arial", 14);  // Set font size for clarity
                descriptionLabel.Location = new Point(10, yPosition);  // Set dynamic Y position
                descriptionLabel.AutoSize = true;
                this.panel1.Controls.Add(descriptionLabel);

                yPosition += 30;  // Increment Y position for next label

                // Create a new label for PublishDate
                Label publishDateLabel = new Label();
                publishDateLabel.Text = "Publish Date: " + row["CreatedDate"].ToString();  // Concatenate "Publish Date" with the actual value
                publishDateLabel.Font = new Font("Arial", 14);
                publishDateLabel.Location = new Point(10, yPosition);  // Set dynamic Y position
                publishDateLabel.AutoSize = true;
                this.panel1.Controls.Add(publishDateLabel);

                yPosition += 30;  // Increment Y position for next label

                // Create a new label for Last Response Date
                Label lastResponseDateLabel = new Label();
                lastResponseDateLabel.Text = "Last Response Date: " + row["LastResponseDate"].ToString();  // Concatenate "Last Response Date" with the actual value
                lastResponseDateLabel.Font = new Font("Arial", 14);
                lastResponseDateLabel.Location = new Point(10, yPosition);  // Set dynamic Y position
                lastResponseDateLabel.AutoSize = true;
                this.panel1.Controls.Add(lastResponseDateLabel);

                yPosition += 30;  // Increment Y position for next label

                // Create a new label for ResponseText
                Label responseTextLabel = new Label();
                responseTextLabel.Text = "Response Text: " + row["LastResponse"].ToString();  // Concatenate "Response Text" with the actual value
                responseTextLabel.Font = new Font("Arial", 14);
                responseTextLabel.Location = new Point(10, yPosition);  // Set dynamic Y position
                responseTextLabel.AutoSize = true;
                this.panel1.Controls.Add(responseTextLabel);

                yPosition += 30;  // Increment Y position for next label

                // Create a new label for ResponserName
                Label responserNameLabel = new Label();
                int? userID = row["LastResponserID"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["LastResponserID"]);
                clsUsers TempUser = null;
                if (userID.HasValue)
                {
                    TempUser = clsUsers.Find(userID.Value);
                }

                if (TempUser != null)
                {
                    // if User object is Not Null, then check if the username is Null;
                    responserNameLabel.Text = "Responder: " + TempUser.Username ?? "No Response Yet.";  // Concatenate "Responder" with the actual value
                }
                else
                {
                    responserNameLabel.Text = "Responder: No Response Yet.";  // If no response, set default text
                }

                // Set background color if no response
                if (!userID.HasValue)
                {
                    responserNameLabel.BackColor = Color.Red;  // Red background if there's no response
                }

                responserNameLabel.Font = new Font("Arial", 14);
                responserNameLabel.Location = new Point(10, yPosition);  // Set dynamic Y position
                responserNameLabel.AutoSize = true;
                this.panel1.Controls.Add(responserNameLabel);

                yPosition += 30;  // Increment Y position for next label

                // Add a separator line to separate this record
                Label separatorLine = new Label();
                separatorLine.BorderStyle = BorderStyle.FixedSingle;  // This creates a simple line
                separatorLine.Location = new Point(10, yPosition);  // Set dynamic Y position
                separatorLine.Size = new Size(this.panel1.Width - 20, 2);  // Adjust the width of the separator line
                this.panel1.Controls.Add(separatorLine);

                yPosition += 20;  // Increment Y position for next record
            }
        }

        private void frmSupport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;
                return;
            }
            _RefreshPanel();
            panel1.Visible = true;
        }

        private bool IsValid()
        {
            if (string.IsNullOrEmpty(tbSubject.Text.Trim()))
            {
                errorProvider1.SetError(tbSubject, "Required");
                return false;
            }
            errorProvider1.SetError(tbSubject, "");
            return true;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

            if (Ticket.TicketID != -1)
            {
                MessageBox.Show("Ticket Is Already Published.", "Error During Publishing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValid())
            {
                return;
            }

            Ticket.Subject = tbSubject.Text.Trim();
            Ticket.Description = tbDescription.Text.Trim();

            Ticket.TicketPublisherID = Global_Classes.clsGlobal.GlobalCustomer.CustomerID;
            Ticket.CreatedDate = DateTime.Now;

            if (!Ticket.Save())
            {
                MessageBox.Show("Ticket Is Not Published Yet.", "Error During Publishing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnPost.Enabled = false;
                return;
            }
            MessageBox.Show("Ticket Is Published Successfully.", "Done Publishing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _RefreshPanel();
            return;

        }
    }
}
