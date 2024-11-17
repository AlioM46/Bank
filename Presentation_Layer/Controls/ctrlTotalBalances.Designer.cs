namespace Presentation_Layer.Controls
{
    partial class ctrlTotalBalances
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
            lblRank = new Label();
            label4 = new Label();
            lblTotal = new Label();
            label2 = new Label();
            label1 = new Label();
            cbCurrencies = new ComboBox();
            gb1.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(lblRank);
            gb1.Controls.Add(label4);
            gb1.Controls.Add(lblTotal);
            gb1.Controls.Add(label2);
            gb1.Controls.Add(label1);
            gb1.Controls.Add(cbCurrencies);
            gb1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gb1.Location = new Point(0, 3);
            gb1.Name = "gb1";
            gb1.Size = new Size(830, 269);
            gb1.TabIndex = 0;
            gb1.TabStop = false;
            gb1.Text = "Your All Accounts Balance";
            gb1.Enter += gb1_Enter;
            // 
            // lblRank
            // 
            lblRank.AutoSize = true;
            lblRank.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRank.Location = new Point(166, 105);
            lblRank.Name = "lblRank";
            lblRank.Size = new Size(65, 32);
            lblRank.TabIndex = 5;
            lblRank.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 111);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 4;
            label4.Text = "Your Rank:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(164, 174);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 32);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "[???]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 181);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Currency:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 42);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 1;
            label1.Text = "Currency:";
            // 
            // cbCurrencies
            // 
            cbCurrencies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCurrencies.FormattingEnabled = true;
            cbCurrencies.Location = new Point(148, 42);
            cbCurrencies.Name = "cbCurrencies";
            cbCurrencies.Size = new Size(195, 33);
            cbCurrencies.TabIndex = 0;
            cbCurrencies.SelectedIndexChanged += cbCurrencies_SelectedIndexChanged;
            // 
            // ctrlTotalBalances
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gb1);
            Name = "ctrlTotalBalances";
            Size = new Size(833, 275);
            Load += ctrlTotalBalances_Load;
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb1;
        private Label label1;
        private ComboBox cbCurrencies;
        private Label label2;
        private Label lblRank;
        private Label label4;
        private Label lblTotal;
    }
}
