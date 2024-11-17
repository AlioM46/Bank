namespace Presentation_Layer.Customer_Forms.Accounts
{
    partial class frmManageAccounts
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
            dgvAllAccounts = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            lblUsers = new Label();
            lblRecords = new Label();
            label1 = new Label();
            btnAdd = new Button();
            showInfoToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvAllAccounts).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllAccounts
            // 
            dgvAllAccounts.AllowUserToAddRows = false;
            dgvAllAccounts.AllowUserToDeleteRows = false;
            dgvAllAccounts.BackgroundColor = Color.White;
            dgvAllAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllAccounts.ContextMenuStrip = contextMenuStrip1;
            dgvAllAccounts.Location = new Point(7, 262);
            dgvAllAccounts.Name = "dgvAllAccounts";
            dgvAllAccounts.ReadOnly = true;
            dgvAllAccounts.Size = new Size(1890, 779);
            dgvAllAccounts.TabIndex = 19;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, showInfoToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 78);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(180, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Monotype Corsiva", 50.25F, FontStyle.Bold);
            lblUsers.Location = new Point(565, 9);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(613, 82);
            lblUsers.TabIndex = 23;
            lblUsers.Text = "Manage Your Accounts";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F);
            lblRecords.Location = new Point(91, 224);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(31, 21);
            lblRecords.TabIndex = 22;
            lblRecords.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 224);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 21;
            label1.Text = "Records: #";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(1773, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 89);
            btnAdd.TabIndex = 20;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // showInfoToolStripMenuItem
            // 
            showInfoToolStripMenuItem.Name = "showInfoToolStripMenuItem";
            showInfoToolStripMenuItem.Size = new Size(180, 26);
            showInfoToolStripMenuItem.Text = "Show Info";
            showInfoToolStripMenuItem.Click += showInfoToolStripMenuItem_Click;
            // 
            // frmManageAccounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dgvAllAccounts);
            Controls.Add(lblUsers);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "frmManageAccounts";
            Text = "frmManageAccounts";
            WindowState = FormWindowState.Maximized;
            Load += frmManageAccounts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllAccounts).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllAccounts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label lblUsers;
        private Label lblRecords;
        private Label label1;
        private Button btnAdd;
        private ToolStripMenuItem showInfoToolStripMenuItem;
    }
}