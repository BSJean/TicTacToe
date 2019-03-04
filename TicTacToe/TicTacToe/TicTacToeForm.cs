using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToeForm : Form
    {
        int countX, countO, countDraws, countSteps = 0;
        bool lastStep = false;
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelX.Text = $"X won: {countX}";
            labelO.Text = $"O won: {countO}";
            labelDraw.Text = $"Draws: {countDraws}";
        }
        
        
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text=="")
            {
                if (!lastStep)
                {
                    b.Text = "X";
                    lastStep = true;
                }
                else
                {
                    b.Text = "O";
                    lastStep = false;
                }
                countSteps++;
                checkForWinner();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            newGame();
        }

        void newGame()
        {
            button00.Text = button01.Text = button02.Text = button10.Text = button11.Text = button12.Text =
                button20.Text = button21.Text = button22.Text = "";
            labelX.Text = $"X won: {countX}";
            labelO.Text = $"O won: {countO}";
            labelDraw.Text = $"Draws: {countDraws}";
            countSteps = 0;
            lastStep = false;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {            
            countX = countO = countDraws = 0;
            newGame();
        }

        void checkForWinner()
        {
            if (countSteps>=5)
            {
                if ((button00.Text==button01.Text && button00.Text==button02.Text && button00.Text!="") ||
                    (button00.Text == button10.Text && button00.Text == button20.Text && button00.Text != "") ||
                    (button00.Text == button11.Text && button00.Text == button22.Text && button00.Text != ""))
                {
                    winnerMessage(button00.Text);
                }
                if ((button01.Text == button11.Text && button01.Text == button21.Text && button01.Text != "") ||
                    (button10.Text == button11.Text && button10.Text == button12.Text && button10.Text != "") ||
                    (button02.Text == button11.Text && button20.Text == button11.Text && button11.Text != ""))
                {
                    winnerMessage(button11.Text);
                }
                if ((button02.Text == button12.Text && button02.Text == button22.Text && button22.Text != "") ||
                    (button20.Text == button21.Text && button20.Text == button22.Text && button22.Text != ""))
                {
                    winnerMessage(button22.Text);
                }
                if (countSteps==9)
                {
                    winnerMessage("Draw");
                }
            }
        }

        void winnerMessage(string s)
        {
            if (s == "X")
            {
                countX++;
                MessageBox.Show("X won!");                
            }
            else if (s == "O")
            {
                countO++;
                MessageBox.Show("O won!");
            }
            else
            {
                countDraws++;
                MessageBox.Show("Draw!");
            }
            newGame();
        }
    }
}
