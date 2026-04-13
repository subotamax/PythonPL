using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private bool xTurn = true;
        private Button[] ticTacToeButtons;
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
            // Ініціалізуємо масив після того, як кнопки створені в InitializeComponent
            ticTacToeButtons = new Button[] { b1, b2, b3, b4, b5, b6, b7, b8, b9 };

            foreach (var btn in ticTacToeButtons)
            {
                btn.Text = "";
                btn.Click += TicTacToe_Click;
            }
        }

        // 1. КНОПКА "СПІЙМАЙ МЕНЕ"
        private void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                Random rnd = new Random();
                int maxX = this.ClientSize.Width - btn.Width;
                int maxY = this.ClientSize.Height - btn.Height;
                btn.Location = new Point(rnd.Next(0, Math.Max(0, maxX)), rnd.Next(0, Math.Max(0, maxY)));
            }
        }

        // 2. ХРЕСТИКИ-НОЛИКИ
        private void TicTacToe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text != "") return;

            btn.Text = xTurn ? "X" : "O";
            btn.ForeColor = xTurn ? Color.Blue : Color.Red;

            if (CheckWinner())
            {
                MessageBox.Show($"Переміг {(xTurn ? "X" : "O")}!");
                ResetGame();
            }
            else
            {
                xTurn = !xTurn;
            }
        }

        private bool CheckWinner()
        {
            int[,] wins = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, { 0, 4, 8 }, { 2, 4, 6 } };
            for (int i = 0; i < 8; i++)
            {
                if (ticTacToeButtons[wins[i, 0]].Text != "" &&
                    ticTacToeButtons[wins[i, 0]].Text == ticTacToeButtons[wins[i, 1]].Text &&
                    ticTacToeButtons[wins[i, 1]].Text == ticTacToeButtons[wins[i, 2]].Text)
                    return true;
            }
            return false;
        }

        private void ResetGame()
        {
            foreach (var b in ticTacToeButtons) b.Text = "";
            xTurn = true;
        }

        // 3. РЕДАКТОР
        private void btnOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Text files|*.txt" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = ofd.FileName;
                    txtEditor.Text = File.ReadAllText(currentFilePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Text files|*.txt" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK) currentFilePath = sfd.FileName;
                    else return;
                }
            }
            File.WriteAllText(currentFilePath, txtEditor.Text);
            MessageBox.Show("Збережено!");
        }
    }
}