namespace Presentation_Layer
{
    partial class frmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            manageCustomersToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationsToolStripMenuItem = new ToolStripMenuItem();
            supportTicketsToolStripMenuItem = new ToolStripMenuItem();
            changeInformationToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.GripMargin = new Padding(2);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageUsersToolStripMenuItem, peopleToolStripMenuItem, manageCustomersToolStripMenuItem, manageApplicationsToolStripMenuItem, supportTicketsToolStripMenuItem, changeInformationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1904, 37);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(205, 33);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += manageUsersToolStripMenuItem_Click;
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(109, 33);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // manageCustomersToolStripMenuItem
            // 
            manageCustomersToolStripMenuItem.Name = "manageCustomersToolStripMenuItem";
            manageCustomersToolStripMenuItem.Size = new Size(163, 33);
            manageCustomersToolStripMenuItem.Text = "Customers";
            manageCustomersToolStripMenuItem.Click += manageCustomersToolStripMenuItem_Click;
            // 
            // manageApplicationsToolStripMenuItem
            // 
            manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            manageApplicationsToolStripMenuItem.Size = new Size(180, 33);
            manageApplicationsToolStripMenuItem.Text = "Applications";
            manageApplicationsToolStripMenuItem.Click += manageApplicationsToolStripMenuItem_Click;
            // 
            // supportTicketsToolStripMenuItem
            // 
            supportTicketsToolStripMenuItem.Name = "supportTicketsToolStripMenuItem";
            supportTicketsToolStripMenuItem.Size = new Size(227, 33);
            supportTicketsToolStripMenuItem.Text = "Support Tickets";
            supportTicketsToolStripMenuItem.Click += supportTicketsToolStripMenuItem_Click;
            // 
            // changeInformationToolStripMenuItem
            // 
            changeInformationToolStripMenuItem.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold);
            changeInformationToolStripMenuItem.Name = "changeInformationToolStripMenuItem";
            changeInformationToolStripMenuItem.Size = new Size(281, 33);
            changeInformationToolStripMenuItem.Text = "Change Information";
            changeInformationToolStripMenuItem.Click += changeInformationToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1426, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 67);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmUser";
            Text = "Admins Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += frmUser_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageCustomersToolStripMenuItem;
        private ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private ToolStripMenuItem supportTicketsToolStripMenuItem;
        private ToolStripMenuItem changeInformationToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private ToolStripMenuItem peopleToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}