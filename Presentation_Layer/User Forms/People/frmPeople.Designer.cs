namespace Presentation_Layer.User_Forms
{
    partial class frmPeople
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
            dgvAllPeople = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editUserToolStripMenuItem = new ToolStripMenuItem();
            activeToolStripMenuItem = new ToolStripMenuItem();
            viewUserInformationToolStripMenuItem = new ToolStripMenuItem();
            lblUsers = new Label();
            lblRecords = new Label();
            label1 = new Label();
            btnAdd = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            tbFilter = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvAllPeople).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAllPeople
            // 
            dgvAllPeople.AllowUserToAddRows = false;
            dgvAllPeople.AllowUserToDeleteRows = false;
            dgvAllPeople.BackgroundColor = Color.White;
            dgvAllPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllPeople.ContextMenuStrip = contextMenuStrip1;
            dgvAllPeople.Location = new Point(7, 257);
            dgvAllPeople.Name = "dgvAllPeople";
            dgvAllPeople.ReadOnly = true;
            dgvAllPeople.Size = new Size(1890, 779);
            dgvAllPeople.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.White;
            contextMenuStrip1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editUserToolStripMenuItem, activeToolStripMenuItem, viewUserInformationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(260, 82);
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            editUserToolStripMenuItem.Size = new Size(259, 26);
            editUserToolStripMenuItem.Text = "Update Person";
            editUserToolStripMenuItem.Click += editUserToolStripMenuItem_Click;
            // 
            // activeToolStripMenuItem
            // 
            activeToolStripMenuItem.Name = "activeToolStripMenuItem";
            activeToolStripMenuItem.Size = new Size(259, 26);
            activeToolStripMenuItem.Text = "Delete";
            activeToolStripMenuItem.Click += activeToolStripMenuItem_Click;
            // 
            // viewUserInformationToolStripMenuItem
            // 
            viewUserInformationToolStripMenuItem.Name = "viewUserInformationToolStripMenuItem";
            viewUserInformationToolStripMenuItem.Size = new Size(259, 26);
            viewUserInformationToolStripMenuItem.Text = "View Person Information";
            viewUserInformationToolStripMenuItem.Click += viewUserInformationToolStripMenuItem_Click;
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Monotype Corsiva", 50.25F, FontStyle.Bold);
            lblUsers.Location = new Point(599, 5);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(410, 82);
            lblUsers.TabIndex = 9;
            lblUsers.Text = "Manage People";
            // 
            // lblRecords
            // 
            lblRecords.AutoSize = true;
            lblRecords.Font = new Font("Segoe UI", 12F);
            lblRecords.Location = new Point(91, 230);
            lblRecords.Name = "lblRecords";
            lblRecords.Size = new Size(31, 21);
            lblRecords.TabIndex = 8;
            lblRecords.Text = "???";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 230);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 7;
            label1.Text = "Records: #";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(1773, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 89);
            btnAdd.TabIndex = 6;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(164, 230);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 10;
            label2.Text = "Filter By:";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Person ID", "First Name", "Last Name", "Gender" });
            comboBox1.Location = new Point(239, 228);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tbFilter
            // 
            tbFilter.Location = new Point(383, 228);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(121, 23);
            tbFilter.TabIndex = 12;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // frmPeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tbFilter);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(dgvAllPeople);
            Controls.Add(lblUsers);
            Controls.Add(lblRecords);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "frmPeople";
            Text = "Manage People";
            WindowState = FormWindowState.Maximized;
            Load += frmPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAllPeople).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAllPeople;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem activeToolStripMenuItem;
        private ToolStripMenuItem viewUserInformationToolStripMenuItem;
        private Label lblUsers;
        private Label lblRecords;
        private Label label1;
        private Button btnAdd;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox tbFilter;
    }
}