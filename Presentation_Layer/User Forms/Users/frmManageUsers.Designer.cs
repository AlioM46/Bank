namespace Presentation_Layer.User_Forms
{
    partial class frmManageUsers
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
            dgvAllUsers = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editUserToolStripMenuItem = new ToolStripMenuItem();
            blockToolStripMenuItem = new ToolStripMenuItem();
            activeToolStripMenuItem = new ToolStripMenuItem();
            viewUserInformationToolStripMenuItem = new ToolStripMenuItem();
            btnAdd = new Button();
            label1 = new Label();
            lblRecords = new Label();
            lblUsers = new Label();
            comboBox1 = new ComboBox();
            tbFilter = new TextBox();
            label2 = new Label();
            cbIsActive = new ComboBox();
            cbRole = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAllUsers).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllUsers
            // 
            dgvAllUsers.AllowUserToAddRows = false;
            dgvAllUsers.AllowUserToDeleteRows = false;
            dgvAllUsers.BackgroundColor = Color.White;
            dgvAllUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllUsers.ContextMenuStrip = contextMenuStrip1;
            dgvAllUsers.Location = new Point(2, 272);
            dgvAllUsers.Name = "dgvAllUsers";
            dgvAllUsers.ReadOnly = true;
            dgvAllUsers.Size = new Size(1890, 779);
            dgvAllUsers.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editUserToolStripMenuItem, blockToolStripMenuItem, activeToolStripMenuItem, viewUserInformationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(244, 130);
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(243, 26);
            editUserToolStripMenuItem.Text = "Edit User";
            editUserToolStripMenuItem.Click += editUserToolStripMenuItem_Click;
            // 
            // blockToolStripMenuItem
            // 
            blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            blockToolStripMenuItem.Size = new Size(243, 26);
            blockToolStripMenuItem.Text = "Block";
            blockToolStripMenuItem.Click += blockToolStripMenuItem_Click;
            // 
            // activeToolStripMenuItem
            // 
            activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            activeToolStripMenuItem.Size = new Size(243, 26);
            activeToolStripMenuItem.Text = "Active";
            activeToolStripMenuItem.Click += activeToolStripMenuItem_Click;
            // 
            // viewUserInformationToolStripMenuItem
            // 
            viewUserInformationToolStripMenuItem.Name = "viewUserInformationToolStripMenuItem";
            viewUserInformationToolStripMenuItem.Size = new Size(243, 26);
            viewUserInformationToolStripMenuItem.Text = "View User Information";
            viewUserInformationToolStripMenuItem.Click += viewUserInformationToolStripMenuItem_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(1768, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 89);
            btnAdd.TabIndex = 1;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 234);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 2;
            label1.Text = "Records: #";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F);
            lblRecords.Location = new Point(86, 234);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(31, 21);
            lblRecords.TabIndex = 3;
            lblRecords.Text = "???";
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Monotype Corsiva", 50.25F, FontStyle.Bold);
            lblUsers.Location = new Point(594, 9);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(390, 82);
            lblUsers.TabIndex = 4;
            lblUsers.Text = "Manage Users";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "User ID", "Person ID", "Full Name", "Is Active", "Role" });
            comboBox1.Location = new Point(275, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(402, 245);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(195, 23);
            tbFilter.TabIndex = 6;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(200, 243);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 7;
            label2.Text = "Filter By:";
            // 
            // cbIsActive
            // 
            cbIsActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsActive.FormattingEnabled = true;
            cbIsActive.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsActive.Location = new Point(402, 245);
            cbIsActive.Name = "cbIsActive";
            cbIsActive.Size = new Size(121, 23);
            cbIsActive.TabIndex = 8;
            cbIsActive.Visible = false;
            cbIsActive.SelectedIndexChanged += cbIsActive_SelectedIndexChanged;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "All", "User", "Admin" });
            cbRole.Location = new Point(402, 245);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(121, 23);
            cbRole.TabIndex = 9;
            cbRole.Visible = false;
            cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1904, 1041);
            Controls.Add(cbRole);
            Controls.Add(cbIsActive);
            Controls.Add(label2);
            Controls.Add(tbFilter);
            Controls.Add(comboBox1);
            Controls.Add(lblUsers);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(dgvAllUsers);
            Name = "frmManageUsers";
            Text = "Manage Users";
            WindowState = FormWindowState.Maximized;
            Load += frmManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllUsers).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllUsers;
        private Button btnAdd;
        private Label label1;
        private Label lblRecords;
        private Label lblUsers;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem blockToolStripMenuItem;
        private ToolStripMenuItem activeToolStripMenuItem;
        private ToolStripMenuItem viewUserInformationToolStripMenuItem;
        private ComboBox comboBox1;
        private TextBox tbFilter;
        private Label label2;
        private ComboBox cbIsActive;
        private ComboBox cbRole;
    }
}