namespace Presentation_Layer.Customer_Forms
{
    partial class frmSupport
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
            tbSubject = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbDescription = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            btnPost = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tbSubject
            // 
            tbSubject.Location = new Point(177, 125);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(405, 23);
            tbSubject.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 118);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 1;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 178);
            label2.Name = "label2";
            label2.Size = new Size(131, 30);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(177, 187);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(689, 87);
            tbDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 9);
            label3.Name = "label3";
            label3.Size = new Size(168, 30);
            label3.TabIndex = 4;
            label3.Text = "Support Tickets";
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 446);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 439);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 276);
            button1.Name = "button1";
            button1.Size = new Size(102, 44);
            button1.TabIndex = 6;
            button1.Text = "SHOW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnPost
            // 
            btnPost.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPost.Location = new Point(757, 280);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(109, 52);
            btnPost.TabIndex = 7;
            btnPost.Text = "POST";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmSupport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 915);
            Controls.Add(btnPost);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbDescription);
            Controls.Add(label1);
            Controls.Add(tbSubject);
            Location = new Point(907, 954);
            MaximumSize = new Size(907, 954);
            Name = "frmSupport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSupport";
            Load += frmSupport_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSubject;
        private Label label1;
        private Label label2;
        private TextBox tbDescription;
        private Label label3;
        private Panel panel1;
        private Button button1;
        private Button btnPost;
        private ErrorProvider errorProvider1;
    }
}