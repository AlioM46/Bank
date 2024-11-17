namespace Presentation_Layer.User_Forms.People.Controls
{
    partial class ctrlPersonInfoWithFilter
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
            panel1 = new Panel();
            label1 = new Label();
            btnAdd = new Button();
            btnSearch = new Button();
            textBox1 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ctrlPersonInfo2 = new ctrlPersonInfo();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 86);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(93, 45);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 3;
            label1.Text = "Person ID:";
            // 
            // btnAdd
            // 
            btnAdd.BackgroundImage = Properties.Resources.add_img;
            btnAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdd.Location = new Point(719, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 64);
            btnAdd.TabIndex = 2;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackgroundImage = Properties.Resources.search_icon;
            btnSearch.BackgroundImageLayout = ImageLayout.Zoom;
            btnSearch.Location = new Point(606, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 64);
            btnSearch.TabIndex = 1;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonInfo2
            // 
            ctrlPersonInfo2.Location = new Point(3, 92);
            ctrlPersonInfo2.Name = "ctrlPersonInfo2";
            ctrlPersonInfo2.Size = new Size(830, 371);
            ctrlPersonInfo2.TabIndex = 2;
            ctrlPersonInfo2.Load += ctrlPersonInfo2_Load_1;
            // 
            // ctrlPersonInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonInfo2);
            Controls.Add(panel1);
            Name = "ctrlPersonInfoWithFilter";
            Size = new Size(837, 471);
            Load += ctrlPersonInfoWithFilter_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfo ctrlPersonInfo1;
        private Panel panel1;
        private Label label1;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox textBox1;
        private ErrorProvider errorProvider1;
        private ctrlPersonInfo ctrlPersonInfo2;
    }
}
