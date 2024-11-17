namespace Presentation_Layer.Customer_Forms.Accounts.Controls
{
    partial class ctrlShowAccountInfo
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            lblBalance = new Label();
            lblCurrency = new Label();
            label4 = new Label();
            panel1 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(169, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 23);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 1;
            label1.Text = "Account Number:";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.search_icon;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Location = new Point(485, 17);
            button1.Name = "button1";
            button1.Size = new Size(100, 55);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 109);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 3;
            label2.Text = "Balance:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(150, 109);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(41, 21);
            lblBalance.TabIndex = 4;
            lblBalance.Text = "[???]";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrency.Location = new Point(150, 170);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(41, 21);
            lblCurrency.TabIndex = 6;
            lblCurrency.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 170);
            label4.Name = "label4";
            label4.Size = new Size(79, 21);
            label4.TabIndex = 5;
            label4.Text = "Currency:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 89);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlShowAccountInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(lblCurrency);
            Controls.Add(label4);
            Controls.Add(lblBalance);
            Controls.Add(label2);
            Name = "ctrlShowAccountInfo";
            Size = new Size(611, 274);
            Load += ctrlShowAccountInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label lblBalance;
        private Label lblCurrency;
        private Label label4;
        private Panel panel1;
        private ErrorProvider errorProvider1;
    }
}
