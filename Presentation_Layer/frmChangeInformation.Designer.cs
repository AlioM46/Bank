namespace Presentation_Layer.User_Forms
{
    partial class frmChangeInformation
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
            label1 = new Label();
            label2 = new Label();
            tbPassword = new CustomControls.ctrlTextBoxValidation();
            tbRePassword = new TextBox();
            btnChange = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 67);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 163);
            label2.Name = "label2";
            label2.Size = new Size(143, 30);
            label2.TabIndex = 1;
            label2.Text = "Re-Password:";
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F);
            tbPassword.Location = new Point(283, 76);
            tbPassword.MinCharLength = 4;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Pattern = CustomControls.ctrlTextBoxValidation.enPattern.Password;
            tbPassword.RegExp = "^[a-zA-Z0-9]{4,}$";
            tbPassword.Size = new Size(219, 29);
            tbPassword.TabIndex = 2;
            // 
            // tbRePassword
            // 
            tbRePassword.Font = new Font("Segoe UI", 12F);
            tbRePassword.Location = new Point(283, 170);
            tbRePassword.Name = "tbRePassword";
            tbRePassword.PasswordChar = '*';
            tbRePassword.Size = new Size(219, 29);
            tbRePassword.TabIndex = 3;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI", 12F);
            btnChange.Location = new Point(532, 329);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(122, 39);
            btnChange.TabIndex = 4;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmChangeInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 380);
            Controls.Add(btnChange);
            Controls.Add(tbRePassword);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(682, 419);
            MinimumSize = new Size(682, 419);
            Name = "frmChangeInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Change Information";
            Load += frmChangeInformation_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private CustomControls.ctrlTextBoxValidation tbPassword;
        private TextBox tbRePassword;
        private Button btnChange;
        private ErrorProvider errorProvider1;
    }
}