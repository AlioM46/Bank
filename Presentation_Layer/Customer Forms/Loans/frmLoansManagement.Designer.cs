namespace Presentation_Layer.Customer_Forms.Loans
{
    partial class frmLoansManagement
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
            dgvAllLoans = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            payToolStripMenuItem = new ToolStripMenuItem();
            cLOSEToolStripMenuItem = new ToolStripMenuItem();
            lblLoans = new Label();
            lblRecords = new Label();
            label1 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAllLoans).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllLoans
            // 
            dgvAllLoans.AllowUserToAddRows = false;
            dgvAllLoans.AllowUserToDeleteRows = false;
            dgvAllLoans.BackgroundColor = Color.White;
            dgvAllLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllLoans.ContextMenuStrip = contextMenuStrip1;
            dgvAllLoans.Location = new Point(7, 257);
            dgvAllLoans.Name = "dgvAllLoans";
            dgvAllLoans.ReadOnly = true;
            dgvAllLoans.Size = new Size(1890, 779);
            dgvAllLoans.TabIndex = 24;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { payToolStripMenuItem, cLOSEToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(128, 56);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // payToolStripMenuItem
            // 
            payToolStripMenuItem.Name = "payToolStripMenuItem";
            payToolStripMenuItem.Size = new Size(127, 26);
            payToolStripMenuItem.Text = "Pay";
            payToolStripMenuItem.Click += payToolStripMenuItem_Click;
            // 
            // cLOSEToolStripMenuItem
            // 
            cLOSEToolStripMenuItem.Name = "cLOSEToolStripMenuItem";
            cLOSEToolStripMenuItem.Size = new Size(127, 26);
            cLOSEToolStripMenuItem.Text = "CLOSE";
            cLOSEToolStripMenuItem.Click += cLOSEToolStripMenuItem_Click;
            // 
            // lblLoans
            // 
            lblLoans.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLoans.AutoSize = true;
            lblLoans.Font = new Font("Monotype Corsiva", 50.25F, FontStyle.Bold);
            lblLoans.Location = new Point(565, 4);
            lblLoans.Name = "lblLoans";
            lblLoans.Size = new Size(401, 82);
            lblLoans.TabIndex = 28;
            lblLoans.Text = "Manage Loans";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F);
            lblRecords.Location = new Point(91, 219);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(31, 21);
            lblRecords.TabIndex = 27;
            lblRecords.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 219);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 26;
            label1.Text = "Records: #";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(1773, 151);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 89);
            btnAdd.TabIndex = 25;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmLoansManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dgvAllLoans);
            Controls.Add(lblLoans);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "frmLoansManagement";
            Text = "frmLoansManagement";
            WindowState = FormWindowState.Maximized;
            Load += frmLoansManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllLoans).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllLoans;
        private ContextMenuStrip contextMenuStrip1;
        private Label lblLoans;
        private Label lblRecords;
        private Label label1;
        private Button btnAdd;
        private ToolStripMenuItem payToolStripMenuItem;
        private ToolStripMenuItem cLOSEToolStripMenuItem;
    }
}