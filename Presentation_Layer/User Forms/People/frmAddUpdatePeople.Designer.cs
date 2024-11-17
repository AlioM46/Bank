namespace Presentation_Layer.User_Forms.People
{
    partial class frmAddUpdatePeople
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
            lblMode = new Label();
            tbFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbSecondName = new TextBox();
            label3 = new Label();
            tbThirdName = new TextBox();
            label4 = new Label();
            tbLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbEmail = new TextBox();
            label7 = new Label();
            tbAddress = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            lblID = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            errorProvider1 = new ErrorProvider(components);
            label9 = new Label();
            rbMale = new RadioButton();
            tbFemale = new RadioButton();
            pictureBox1 = new PictureBox();
            btnAddImg = new Button();
            btnResetImg = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Font = new Font("Segoe UI", 24F);
            lblMode.Location = new Point(382, 22);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(61, 45);
            lblMode.TabIndex = 0;
            lblMode.Text = "[...]";
            // 
            // tbFirstName
            // 
            tbFirstName.Font = new Font("Segoe UI", 12F);
            tbFirstName.Location = new Point(201, 257);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(167, 29);
            tbFirstName.TabIndex = 1;
            tbFirstName.Validating += Validating_Textbox;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(38, 251);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 2;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(38, 352);
            label2.Name = "label2";
            label2.Size = new Size(138, 28);
            label2.TabIndex = 4;
            label2.Text = "Second Name:";
            // 
            // tbSecondName
            // 
            tbSecondName.Font = new Font("Segoe UI", 12F);
            tbSecondName.Location = new Point(201, 355);
            tbSecondName.Name = "tbSecondName";
            tbSecondName.Size = new Size(167, 29);
            tbSecondName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(38, 453);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 6;
            label3.Text = "Third Name:";
            // 
            // tbThirdName
            // 
            tbThirdName.Font = new Font("Segoe UI", 12F);
            tbThirdName.Location = new Point(201, 459);
            tbThirdName.Name = "tbThirdName";
            tbThirdName.Size = new Size(167, 29);
            tbThirdName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(38, 554);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 8;
            label4.Text = "Last Name:";
            // 
            // tbLastName
            // 
            tbLastName.Font = new Font("Segoe UI", 12F);
            tbLastName.Location = new Point(201, 560);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(167, 29);
            tbLastName.TabIndex = 7;
            tbLastName.Validating += Validating_Textbox;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(431, 453);
            label5.Name = "label5";
            label5.Size = new Size(126, 28);
            label5.TabIndex = 14;
            label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(431, 352);
            label6.Name = "label6";
            label6.Size = new Size(63, 28);
            label6.TabIndex = 12;
            label6.Text = "Email:";
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F);
            tbEmail.Location = new Point(594, 358);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(167, 29);
            tbEmail.TabIndex = 11;
            tbEmail.Validating += Validating_Textbox;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(431, 251);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(86, 28);
            label7.TabIndex = 10;
            label7.Text = "Address:";
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Segoe UI", 12F);
            tbAddress.Location = new Point(594, 257);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(167, 29);
            tbAddress.TabIndex = 9;
            tbAddress.Validating += Validating_Textbox;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(594, 465);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(38, 162);
            label8.Name = "label8";
            label8.Size = new Size(135, 37);
            label8.TabIndex = 16;
            label8.Text = "Person ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 18F);
            lblID.Location = new Point(317, 166);
            lblID.Name = "lblID";
            lblID.Size = new Size(51, 32);
            lblID.TabIndex = 17;
            lblID.Text = "[ID]";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(1114, 797);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 44);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Done";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 12F);
            btnCancel.Location = new Point(985, 797);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 44);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(431, 554);
            label9.Name = "label9";
            label9.Size = new Size(80, 28);
            label9.TabIndex = 23;
            label9.Text = "Gender:";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Checked = true;
            rbMale.Location = new Point(596, 573);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 24;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbChange;
            // 
            // tbFemale
            // 
            tbFemale.AutoSize = true;
            tbFemale.Location = new Point(698, 573);
            tbFemale.Name = "tbFemale";
            tbFemale.Size = new Size(63, 19);
            tbFemale.TabIndex = 25;
            tbFemale.Text = "Female";
            tbFemale.UseVisualStyleBackColor = true;
            tbFemale.CheckedChanged += rbChange;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man_icon;
            pictureBox1.Location = new Point(909, 162);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnAddImg
            // 
            btnAddImg.Font = new Font("Segoe UI", 12F);
            btnAddImg.Location = new Point(1019, 394);
            btnAddImg.Name = "btnAddImg";
            btnAddImg.Size = new Size(173, 44);
            btnAddImg.TabIndex = 27;
            btnAddImg.Text = "Add Profile Image";
            btnAddImg.UseVisualStyleBackColor = true;
            btnAddImg.Click += btnAddImg_Click;
            // 
            // btnResetImg
            // 
            btnResetImg.Font = new Font("Segoe UI", 12F);
            btnResetImg.Location = new Point(909, 394);
            btnResetImg.Name = "btnResetImg";
            btnResetImg.Size = new Size(104, 44);
            btnResetImg.TabIndex = 28;
            btnResetImg.Text = "Reset Image";
            btnResetImg.UseVisualStyleBackColor = true;
            btnResetImg.Click += btnResetImg_Click;
            // 
            // frmAddUpdatePeople
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 853);
            Controls.Add(btnResetImg);
            Controls.Add(btnAddImg);
            Controls.Add(pictureBox1);
            Controls.Add(tbFemale);
            Controls.Add(rbMale);
            Controls.Add(label9);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblID);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(tbEmail);
            Controls.Add(label7);
            Controls.Add(tbAddress);
            Controls.Add(label4);
            Controls.Add(tbLastName);
            Controls.Add(label3);
            Controls.Add(tbThirdName);
            Controls.Add(label2);
            Controls.Add(tbSecondName);
            Controls.Add(label1);
            Controls.Add(tbFirstName);
            Controls.Add(lblMode);
            Name = "frmAddUpdatePeople";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddUpdatePeople";
            Load += frmAddUpdatePeople_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMode;
        private TextBox tbFirstName;
        private Label label1;
        private Label label2;
        private TextBox tbSecondName;
        private Label label3;
        private TextBox tbThirdName;
        private Label label4;
        private TextBox tbLastName;
        private Label label5;
        private Label label6;
        private TextBox tbEmail;
        private Label label7;
        private TextBox tbAddress;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label lblID;
        private Button btnAdd;
        private Button btnCancel;
        private ErrorProvider errorProvider1;
        private Label label9;
        private RadioButton rbMale;
        private RadioButton tbFemale;
        private Button btnResetImg;
        private Button btnAddImg;
        private PictureBox pictureBox1;
    }
}