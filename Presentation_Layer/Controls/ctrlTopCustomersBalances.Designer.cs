namespace Presentation_Layer.Controls
{
    partial class ctrlTopCustomersBalances
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
            gb1 = new GroupBox();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb1.Location = new Point(3, 3);
            gb1.Name = "gb1";
            gb1.Size = new Size(768, 455);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Top 5 Customers Wallets for United States Market $";
            gb1.Enter += gb1_Enter;
            // 
            // ctrlTopCustomersBalances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb1);
            Name = "ctrlTopCustomersBalances";
            Size = new Size(778, 461);
            Load += ctrlTopCustomersBalances_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
    }
}
