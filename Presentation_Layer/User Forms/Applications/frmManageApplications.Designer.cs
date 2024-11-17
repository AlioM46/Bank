namespace Presentation_Layer.User_Forms
{
    partial class frmManageApplications
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
            components = new System.ComponentModel.Container();
            dgvAllApplications = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            approveToolStripMenuItem = new ToolStripMenuItem();
            rejectToolStripMenuItem = new ToolStripMenuItem();
            provideDocumentsToolStripMenuItem = new ToolStripMenuItem();
            tbFilter = new TextBox();
            cbFilters = new ComboBox();
            label2 = new Label();
            lblUsers = new Label();
            lblRecords = new Label();
            label1 = new Label();
            btnAdd = new Button();
            cbSecondFilter = new ComboBox();
            payFeesToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAllApplications).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllApplications
            // 
            dgvAllApplications.AllowUserToAddRows = false;
            dgvAllApplications.AllowUserToDeleteRows = false;
            dgvAllApplications.BackgroundColor = Color.White;
            dgvAllApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllApplications.ContextMenuStrip = contextMenuStrip1;
            dgvAllApplications.Location = new Point(7, 257);
            dgvAllApplications.Name = "dgvAllApplications";
            dgvAllApplications.ReadOnly = true;
            dgvAllApplications.Size = new Size(1890, 779);
            dgvAllApplications.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { approveToolStripMenuItem, rejectToolStripMenuItem, provideDocumentsToolStripMenuItem, payFeesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(224, 130);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // approveToolStripMenuItem
            // 
            approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            approveToolStripMenuItem.Size = new Size(223, 26);
            approveToolStripMenuItem.Text = "Approve";
            approveToolStripMenuItem.Click += approveToolStripMenuItem_Click;
            // 
            // rejectToolStripMenuItem
            // 
            rejectToolStripMenuItem.Name = "rejectToolStripMenuItem";
            rejectToolStripMenuItem.Size = new Size(223, 26);
            rejectToolStripMenuItem.Text = "Reject";
            rejectToolStripMenuItem.Click += rejectToolStripMenuItem_Click;
            // 
            // provideDocumentsToolStripMenuItem
            // 
            provideDocumentsToolStripMenuItem.Name = "provideDocumentsToolStripMenuItem";
            provideDocumentsToolStripMenuItem.Size = new Size(223, 26);
            provideDocumentsToolStripMenuItem.Text = "Provide Documents";
            provideDocumentsToolStripMenuItem.Click += provideDocumentsToolStripMenuItem_Click;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(559, 228);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(238, 23);
            tbFilter.TabIndex = 20;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // cbFilters
            // 
            cbFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilters.FormattingEnabled = true;
            cbFilters.Items.AddRange(new object[] { "None", "Accounts", "Loans" });
            cbFilters.Location = new Point(239, 228);
            cbFilters.Name = "cbFilters";
            cbFilters.Size = new Size(121, 23);
            cbFilters.TabIndex = 19;
            cbFilters.SelectedIndexChanged += cbFilters_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(164, 230);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 18;
            label2.Text = "Filter By:";
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Monotype Corsiva", 50.25F, FontStyle.Bold);
            lblUsers.Location = new Point(599, 5);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(561, 82);
            lblUsers.TabIndex = 17;
            lblUsers.Text = "Manage Applications";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F);
            lblRecords.Location = new Point(91, 230);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(31, 21);
            lblRecords.TabIndex = 16;
            lblRecords.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 230);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 15;
            label1.Text = "Records: #";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(1773, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 89);
            btnAdd.TabIndex = 14;
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // cbSecondFilter
            // 
            cbSecondFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSecondFilter.FormattingEnabled = true;
            cbSecondFilter.Items.AddRange(new object[] { "None", "Application ID", "Customer ID", "Customer Name", "Status" });
            cbSecondFilter.Location = new Point(403, 228);
            cbSecondFilter.Name = "cbSecondFilter";
            cbSecondFilter.Size = new Size(150, 23);
            cbSecondFilter.TabIndex = 21;
            cbSecondFilter.SelectedIndexChanged += cbSecondFilter_SelectedIndexChanged;
            // 
            // payFeesToolStripMenuItem
            // 
            payFeesToolStripMenuItem.Name = "payFeesToolStripMenuItem";
            payFeesToolStripMenuItem.Size = new Size(223, 26);
            payFeesToolStripMenuItem.Text = "Pay Fees";
            payFeesToolStripMenuItem.Click += payFeesToolStripMenuItem_Click;
            // 
            // frmManageApplications
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(cbSecondFilter);
            Controls.Add(dgvAllApplications);
            Controls.Add(tbFilter);
            Controls.Add(cbFilters);
            Controls.Add(label2);
            Controls.Add(lblUsers);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "frmManageApplications";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Applications";
            WindowState = FormWindowState.Maximized;
            Load += frmManageApplications_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllApplications).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllApplications;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbFilter;
        private ComboBox cbFilters;
        private Label label2;
        private Label lblUsers;
        private Label lblRecords;
        private Label label1;
        private Button btnAdd;
        private ComboBox cbSecondFilter;
        private ToolStripMenuItem approveToolStripMenuItem;
        private ToolStripMenuItem rejectToolStripMenuItem;
        private ToolStripMenuItem provideDocumentsToolStripMenuItem;
        private ToolStripMenuItem payFeesToolStripMenuItem;
    }
}