namespace Presentation_Layer.User_Forms.Customers.Controls
{
    partial class ctrlCustomerInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblCustomerID = new Label();
            lblPersonID = new Label();
            label4 = new Label();
            label6 = new Label();
            lblCustomerName = new Label();
            label8 = new Label();
            lblCreatedDate = new Label();
            label10 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 63);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer ID:";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerID.Location = new Point(184, 63);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(48, 25);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "[???]";
            // 
            // lblPersonID
            // 
            lblPersonID.AutoSize = true;
            lblPersonID.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPersonID.Location = new Point(184, 125);
            lblPersonID.Name = "lblPersonID";
            lblPersonID.Size = new Size(48, 25);
            lblPersonID.TabIndex = 1;
            lblPersonID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 125);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 2;
            label4.Text = "Person ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(320, 63);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 4;
            label6.Text = "Is Active:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.Location = new Point(495, 125);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(48, 25);
            lblCustomerName.TabIndex = 5;
            lblCustomerName.Text = "[???]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(320, 125);
            label8.Name = "label8";
            label8.Size = new Size(157, 25);
            label8.TabIndex = 6;
            label8.Text = "Customer Name:";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedDate.Location = new Point(735, 63);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(48, 25);
            lblCreatedDate.TabIndex = 7;
            lblCreatedDate.Text = "[???]";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(581, 63);
            label10.Name = "label10";
            label10.Size = new Size(130, 25);
            label10.TabIndex = 8;
            label10.Text = "Created Date:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Enabled = false;
            checkBox1.Location = new Point(495, 63);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ctrlCustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox1);
            Controls.Add(lblCreatedDate);
            Controls.Add(label10);
            Controls.Add(lblCustomerName);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(lblPersonID);
            Controls.Add(label4);
            Controls.Add(lblCustomerID);
            Controls.Add(label1);
            Name = "ctrlCustomerInfo";
            Size = new Size(847, 226);
            Load += ctrlCustomerInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCustomerID;
        private Label lblPersonID;
        private Label label4;
        private Label label6;
        private Label lblCustomerName;
        private Label label8;
        private Label lblCreatedDate;
        private Label label10;
        private CheckBox checkBox1;
    }
}
