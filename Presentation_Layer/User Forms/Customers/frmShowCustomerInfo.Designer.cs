namespace Presentation_Layer.User_Forms.Customers
{
    partial class frmShowCustomerInfo
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
            ctrlPersonInfo1 = new People.Controls.ctrlPersonInfo();
            ctrlCustomerInfo1 = new Controls.ctrlCustomerInfo();
            SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            ctrlPersonInfo1.Location = new Point(2, 247);
            ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            ctrlPersonInfo1.Size = new Size(830, 371);
            ctrlPersonInfo1.TabIndex = 0;
            // 
            // ctrlCustomerInfo1
            // 
            ctrlCustomerInfo1.Location = new Point(2, 12);
            ctrlCustomerInfo1.Name = "ctrlCustomerInfo1";
            ctrlCustomerInfo1.Size = new Size(830, 226);
            ctrlCustomerInfo1.TabIndex = 1;
            // 
            // frmShowCustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 618);
            Controls.Add(ctrlCustomerInfo1);
            Controls.Add(ctrlPersonInfo1);
            Name = "frmShowCustomerInfo";
            Text = "frmShowCustomerInfo";
            Load += frmShowCustomerInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private People.Controls.ctrlPersonInfo ctrlPersonInfo1;
        private Controls.ctrlCustomerInfo ctrlCustomerInfo1;
    }
}