using System;
using System.Drawing;
using System.Windows.Forms;

namespace UnitConverterApp
{
    public partial class Form1 : Form
    {
        public



        private void BtnConvert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Text, out int totalCm))
            {
                if (totalCm >= 0)
                {
                    int meters = totalCm / 100;
                    int centimeters = totalCm % 100;

                    Text = $"{totalCm} см = {meters} м {centimeters} см";
                    ForeColor = Color.DarkGreen;
                }
                else
                {
                    Text = "Помилка: введено від’ємне значення!";
                    ForeColor = Color.Red;
                }
            }
            else
            {
                Text = "Помилка: введіть ціле число!";
                ForeColor = Color.Red;
            }
        }

        private void InitializeComponent()
        {
            txtInput = new Label();
            textBox1 = new TextBox();
            btnConvert = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.AutoSize = true;
            txtInput.Location = new Point(224, 153);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(114, 15);
            txtInput.TabIndex = 0;
            txtInput.Text = "Введіть сантиметри";
            txtInput.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "1";
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(226, 232);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(116, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Конвертувати";
            btnConvert.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(261, 350);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 3;
            lblResult.Click += label1_Click_1;
            // 
            // Form1
            // 
            ClientSize = new Size(735, 465);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(textBox1);
            Controls.Add(txtInput);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private Label txtInput;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private TextBox textBox1;
        private Button btnConvert;
        private Label lblResult;

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}