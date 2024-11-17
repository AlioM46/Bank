using Business_Layer;
using Presentation_Layer.User_Forms.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.User_Forms
{
    public partial class frmSupportTickets : Form
    {
        public frmSupportTickets()
        {
            InitializeComponent();
            panel1.AutoScroll = true;

        }

        private DataTable dt = new DataTable();
        private DataView dv = new DataView();
        private string FilterName = "";


        private void _FillPanel()
        {

            panel1.Controls.Clear();

            // Use filtered DataView instead of the original DataTable
            DataTable filteredTable = dv.ToTable();

            int yPosition = 10;  // Start Y position for the first label

            foreach (DataRow row in filteredTable.Rows)
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


                Button ResponseButton = new Button
                {
                    Location = new Point(10, yPosition + 30),                // Set dynamic Y position
                    Size = new Size(100, 40),             // Adjust the width, height set to 30 for visibility
                    Text = "Response",
                    BackColor = Color.LightGray                         // Optional styling
                };

                // Add an OnClick event handler
                ResponseButton.Click += (sender, e) => ResponseButton_Click(sender, e, Convert.ToInt32(row["TicketID"]));

                this.panel1.Controls.Add(ResponseButton);


                // Add a separator line to separate this record
                Label separatorLine = new Label();
                separatorLine.BorderStyle = BorderStyle.FixedSingle;  // This creates a simple line
                separatorLine.Location = new Point(10, yPosition + 80);  // Set dynamic Y position
                separatorLine.Size = new Size(this.panel1.Width - 20, 2);  // Adjust the width of the separator line
                this.panel1.Controls.Add(separatorLine);

                yPosition += 100;  // Increment Y position for next record

                // Dynamically adjust AutoScrollMinSize
                panel1.AutoScrollMinSize = new Size(panel1.Width, yPosition);

                // Force panel to redraw and refresh
                panel1.PerformLayout();
                panel1.Invalidate();


            }

        }


        private void ResponseButton_Click(object sender, EventArgs e, int ticketID)
        {

            frmSupportResponse frm = new frmSupportResponse(ticketID);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            frmSupportTickets_Load(null, null);
        }

        private void frmSupportTickets_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;

            dt = clsSupportTickets.GetAllSupportTickets();
            dv = dt.DefaultView; // Assign DataView for filtering

            _FillPanel();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {


            tbFilter.Text = "";


            switch (cbFilter.Text)
            {
                case "None":
                    FilterName = "None";
                    break;
                case "Subject":
                    FilterName = "Subject";
                    break;
                case "Description":
                    FilterName = "Description";
                    break;
                case "Ticket ID":
                    FilterName = "TicketID";
                    break;
                case "Responser ID":
                    FilterName = "LastResponserID";
                    break;
                case "Publisher ID":
                    FilterName = "TicketPublisherID";
                    break;
            }

            if (cbFilter.Text == "None")
            {

                tbFilter.Enabled = false;
            }
            else
            {
                tbFilter.Enabled = true;

            }

        }

        private void ApplyFilter()
        {
            // If no filter is selected or no text is entered, show all records
            if (string.IsNullOrEmpty(FilterName) || FilterName == "None" || string.IsNullOrEmpty(tbFilter.Text))
            {
                dv.RowFilter = ""; // Reset filter
            }
            else
            {
                // Construct filter string based on selected FilterName and tbFilter text
                if (FilterName == "Subject" || FilterName == "Description")
                {
                    // Filter text columns using LIKE for partial match
                    dv.RowFilter = $"{FilterName} LIKE '%{tbFilter.Text}%'";
                }
                else
                {
                    // Filter numeric columns (ID fields) using exact match
                    dv.RowFilter = $"{FilterName} = {tbFilter.Text}";
                }
            }

            _FillPanel(); // Refresh panel with filtered results
        }


        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            ApplyFilter();

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (FilterName == "Subject" || FilterName == "Description")
            {
                return;
            }

            // Restrict input to digits only for numeric filters
            e.Handled = !(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
