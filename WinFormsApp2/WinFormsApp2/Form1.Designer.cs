    namespace WinFormsApp2
{
    partial class Form1
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
            btnRun = new Button();
            panel1 = new Panel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            richTextBox1 = new RichTextBox();
            btnOpen = new Button();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(29, 21);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(92, 33);
            btnRun.TabIndex = 0;
            btnRun.Text = "спіймай мене";
            btnRun.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(b9);
            panel1.Controls.Add(b1);
            panel1.Controls.Add(b8);
            panel1.Controls.Add(b2);
            panel1.Controls.Add(b7);
            panel1.Controls.Add(b3);
            panel1.Controls.Add(b6);
            panel1.Controls.Add(b4);
            panel1.Controls.Add(b5);
            panel1.Location = new Point(233, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 142);
            panel1.TabIndex = 1;
            // 
            // b1
            // 
            b1.Location = new Point(0, 0);
            b1.Name = "b1";
            b1.Size = new Size(50, 50);
            b1.TabIndex = 2;
            b1.Text = "b1";
            b1.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            b2.Location = new Point(47, 0);
            b2.Name = "b2";
            b2.Size = new Size(50, 50);
            b2.TabIndex = 3;
            b2.Text = "b2";
            b2.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            b3.Location = new Point(94, 0);
            b3.Name = "b3";
            b3.Size = new Size(50, 50);
            b3.TabIndex = 4;
            b3.Text = "b3";
            b3.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            b4.Location = new Point(0, 45);
            b4.Name = "b4";
            b4.Size = new Size(50, 50);
            b4.TabIndex = 5;
            b4.Text = "b4";
            b4.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            b5.Location = new Point(47, 45);
            b5.Name = "b5";
            b5.Size = new Size(50, 50);
            b5.TabIndex = 6;
            b5.Text = "b5";
            b5.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            b6.Location = new Point(94, 45);
            b6.Name = "b6";
            b6.Size = new Size(50, 50);
            b6.TabIndex = 7;
            b6.Text = "b6";
            b6.UseVisualStyleBackColor = true;
            // 
            // b7
            // 
            b7.Location = new Point(0, 91);
            b7.Name = "b7";
            b7.Size = new Size(50, 50);
            b7.TabIndex = 8;
            b7.Text = "b7";
            b7.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            b8.Location = new Point(47, 91);
            b8.Name = "b8";
            b8.Size = new Size(50, 50);
            b8.TabIndex = 9;
            b8.Text = "b8";
            b8.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            b9.Location = new Point(94, 91);
            b9.Name = "b9";
            b9.Size = new Size(50, 50);
            b9.TabIndex = 10;
            b9.Text = "b9";
            b9.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(459, 120);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(224, 127);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(459, 120);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(123, 23);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(578, 120);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            ClientSize = new Size(799, 413);
            Controls.Add(btnSave);
            Controls.Add(btnOpen);
            Controls.Add(richTextBox1);
            Controls.Add(panel1);
            Controls.Add(btnRun);
            Name = "Form1";
            MouseEnter += btnRun_MouseEnter;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            // Add initialization code for controls here.
            // This is usually auto-generated by the designer.
            // For example:
            // this.tabPage1 = new System.Windows.Forms.TabPage();
            // this.b1 = new System.Windows.Forms.Button();
            // ... etc.
        }

        #endregion

        private Button btnRun;
        private Panel panel1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private RichTextBox richTextBox1;
        private Button btnOpen;
        private Button btnSave;
    }
}
