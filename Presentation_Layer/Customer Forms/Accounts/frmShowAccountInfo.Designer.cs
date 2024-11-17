namespace Presentation_Layer.Customer_Forms.Accounts
{
    partial class frmShowAccountInfo
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
            ctrlShowAccountInfo1 = new Controls.ctrlShowAccountInfo();
            SuspendLayout();
            // 
            // ctrlShowAccountInfo1
            // 
            ctrlShowAccountInfo1.AccountMaximumBalance = new decimal(new int[] { 1, 0, 0, int.MinValue });
            ctrlShowAccountInfo1.EnableFilter = true;
            ctrlShowAccountInfo1.IsMyAccount = true;
            ctrlShowAccountInfo1.Location = new Point(2, 3);
            ctrlShowAccountInfo1.Name = "ctrlShowAccountInfo1";
            ctrlShowAccountInfo1.Size = new Size(611, 274);
            ctrlShowAccountInfo1.TabIndex = 0;
            // 
            // frmShowAccountInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 286);
            Controls.Add(ctrlShowAccountInfo1);
            Name = "frmShowAccountInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowAccountInfo";
            Load += frmShowAccountInfo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Controls.ctrlShowAccountInfo ctrlShowAccountInfo1;
    }
}