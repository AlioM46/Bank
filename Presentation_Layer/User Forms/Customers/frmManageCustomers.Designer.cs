namespace Presentation_Layer.User_Forms
{
    partial class frmManageCustomers
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
            dgvAllCustomers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editUserToolStripMenuItem = new ToolStripMenuItem();
            blockToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            activeToolStripMenuItem = new ToolStripMenuItem();
            viewUserInformationToolStripMenuItem = new ToolStripMenuItem();
            cbIsActive = new ComboBox();
            label2 = new Label();
            tbFilter = new TextBox();
            lblUsers = new Label();
            lblRecords = new Label();
            label1 = new Label();
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAllCustomers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllCustomers
            // 
            dgvAllCustomers.AllowUserToAddRows = false;
            dgvAllCustomers.AllowUserToDeleteRows = false;
            dgvAllCustomers.BackgroundColor = Color.White;
            dgvAllCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllCustomers.ContextMenuStrip = contextMenuStrip1;
            dgvAllCustomers.Location = new Point(7, 262);
            dgvAllCustomers.Name = "dgvAllCustomers";
            dgvAllCustomers.ReadOnly = true;
            dgvAllCustomers.Size = new Size(1890, 779);
            dgvAllCustomers.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editUserToolStripMenuItem, blockToolStripMenuItem, deleteToolStripMenuItem, activeToolStripMenuItem, viewUserInformationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(282, 134);
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(281, 26);
            editUserToolStripMenuItem.Text = "Edit Customer";
            editUserToolStripMenuItem.Click += editCustomerToolStripMenuItem_Click;
            // 
            // blockToolStripMenuItem
            // 
            blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            blockToolStripMenuItem.Size = new Size(281, 26);
            blockToolStripMenuItem.Text = "Block";
            blockToolStripMenuItem.Click += blockToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(281, 26);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // activeToolStripMenuItem
            // 
            activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            activeToolStripMenuItem.Size = new Size(281, 26);
            activeToolStripMenuItem.Text = "Active";
            activeToolStripMenuItem.Click += activeToolStripMenuItem_Click;
            // 
            // viewUserInformationToolStripMenuItem
            // 
            viewUserInformationToolStripMenuItem.Name = "viewUserInformationToolStripMenuItem";
            viewUserInformationToolStripMenuItem.Size = new Size(281, 26);
            viewUserInformationToolStripMenuItem.Text = "View Customer Information";
            viewUserInformationToolStripMenuItem.Click += viewCustomerInformationToolStripMenuItem_Click;
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(407, 235);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(121, 23);
            cbIsActive.TabIndex = 18;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 233);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 17;
            label2.Text = "Filter By:";
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(407, 235);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(195, 23);
            tbFilter.TabIndex = 16;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Monotype Corsiva", 50.25F, FontStyle.Bold);
            lblUsers.Location = new Point(544, 9);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(500, 82);
            lblUsers.TabIndex = 14;
            lblUsers.Text = "Manage Customers";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F);
            lblRecords.Location = new Point(91, 224);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(31, 21);
            lblRecords.TabIndex = 13;
            lblRecords.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 224);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 12;
            label1.Text = "Records: #";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(1773, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 89);
            btnAdd.TabIndex = 11;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Customer ID", "Person ID", "Customer Name", "Is Active" });
            comboBox1.Location = new Point(280, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // frmManageCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(dgvAllCustomers);
            Controls.Add(cbIsActive);
            Controls.Add(label2);
            Controls.Add(tbFilter);
            Controls.Add(comboBox1);
            Controls.Add(lblUsers);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "frmManageCustomers";
            StartPosition = FormStartPosition.Manual;
            Text = "Manage Customers";
            WindowState = FormWindowState.Maximized;
            Load += frmManageCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllCustomers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllCustomers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem blockToolStripMenuItem;
        private ToolStripMenuItem activeToolStripMenuItem;
        private ToolStripMenuItem viewUserInformationToolStripMenuItem;
        private ComboBox cbIsActive;
        private Label label2;
        private TextBox tbFilter;
        private Label lblUsers;
        private Label lblRecords;
        private Label label1;
        private Button btnAdd;
        private ComboBox comboBox1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}