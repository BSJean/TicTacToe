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
                if (radioButtonAI.Checked && countSteps!=9 && countSteps != 0)
                {
                    if ((radioButtonX.Checked && countSteps != 1)||(radioButtonO.Checked))
                    {
                        if (radioButtonAINovice.Checked)
                            randomButton(lastStep ? "O" : "X");
                        else if (radioButtonX.Checked)
                        {
                            chooseAI("X");
                        }
                        else
                            chooseAI("O");
                        if (lastStep)
                            lastStep = false;
                        else
                            lastStep = true;
                        countSteps++;
                        checkForWinner();
                    }
                }
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
            labelX.Text = radioButtonPlayer.Checked ?  $"X won: {countX}" : $"You won: {countX}";
            labelO.Text = radioButtonPlayer.Checked ?  $"O won: {countO}" : $"AI won: {countO}";
            labelDraw.Text = $"Draws: {countDraws}";
            countSteps = 0;
            lastStep = false;
            if (radioButtonAI.Checked && radioButtonX.Checked)
            {
                if (radioButtonAIMaster.Checked)
                    button11.Text = "X";
                else
                {
                    randomButton("X");
                }
                lastStep = true;
                countSteps++;
            }
        }

        private void radioButtonAI_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAI.Checked)
            {
                groupBoxPlay.Visible = true;
                groupBoxLevel.Visible = true;
                radioButtonO.Checked = true;
                radioButtonAINovice.Checked = true;
                btnNewGame_Click(sender,e);
            }

        }

        private void radioButtonPlayer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlayer.Checked)
            {
                groupBoxPlay.Visible = false;
                groupBoxLevel.Visible = false;
                btnNewGame_Click(sender, e);
            }            
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {            
            countX = countO = countDraws = 0;
            newGame();
        }
        
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
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
                else if ((button01.Text == button11.Text && button01.Text == button21.Text && button01.Text != "") ||
                    (button10.Text == button11.Text && button10.Text == button12.Text && button10.Text != "") ||
                    (button02.Text == button11.Text && button20.Text == button11.Text && button11.Text != ""))
                {
                    winnerMessage(button11.Text);
                }
                else if ((button02.Text == button12.Text && button02.Text == button22.Text && button22.Text != "") ||
                    (button20.Text == button21.Text && button20.Text == button22.Text && button22.Text != ""))
                {
                    winnerMessage(button22.Text);
                }
                else if (countSteps==9)
                {
                    winnerMessage("Draw");
                }
            }
        }

        void winnerMessage(string s)
        {
            if (s == "X")
            {
                if (radioButtonAI.Checked && radioButtonX.Checked)
                    countO++;
                else
                    countX++;
                MessageBox.Show("X won!");                
            }
            else if (s == "O")
            {
                if ((radioButtonAI.Checked && radioButtonO.Checked) || radioButtonPlayer.Checked)
                    countO++;
                else
                    countX++;
                MessageBox.Show("O won!");
            }
            else
            {
                countDraws++;
                MessageBox.Show("Draw!");
            }
            newGame();
        }

        private void radioButtonAILevel_CheckedChanged(object sender, EventArgs e)
        {
            newGame();
        }

        void randomButton (string s)
        {
            List<Button> listButtons = new List<Button>
            {
                button00,
                button01,
                button02,
                button10,
                button11,
                button12,
                button20,
                button21,
                button22
            };
            List<Button> newList = new List<Button> { };
            foreach (Button b in listButtons)
            {
                if (b.Text == "")
                    newList.Add(b);
            }
            Random t = new Random();
            newList[t.Next(0, newList.Count)].Text = s;
        }

        void chooseAI(string s)
        {
            if (s == "X")
            {
                Random r = new Random();
                switch (countSteps)
                {
                    case 2:
                        if (button10.Text == "O")
                        {
                            if (r.Next(1, 3) == 1)
                                button02.Text = "X";
                            else
                                button22.Text = "X";
                        }
                        else if (button01.Text == "O")
                        {
                            if (r.Next(1, 3) == 1)
                                button20.Text = "X";
                            else
                                button22.Text = "X";
                        }
                        else if (button12.Text == "O")
                        {
                            if (r.Next(1, 3) == 1)
                                button00.Text = "X";
                            else
                                button20.Text = "X";
                        }
                        else if (button21.Text == "O")
                        {
                            if (r.Next(1, 3) == 1)
                                button00.Text = "X";
                            else
                                button02.Text = "X";
                        }
                        else if (button00.Text == "O")
                            button22.Text = "X";
                        else if (button20.Text == "O")
                            button02.Text = "X";
                        else if (button02.Text == "O")
                            button20.Text = "X";
                        else if (button22.Text == "O")
                            button00.Text = "X";
                        break;
                    case 4:
                        checkYourPosition("X", "X");
                        if (countSteps == 5)
                            countSteps--;
                        else
                            checkYourPosition("O", "X");
                        if (countSteps == 5)
                            countSteps--;
                        else if (button00.Text == "O" && button12.Text == "O")
                            button20.Text = "X";
                        else if (button00.Text == "O" && button21.Text == "O")
                            button02.Text = "X";
                        else if (button02.Text == "O" && button21.Text == "O")
                            button00.Text = "X";
                        else if (button02.Text == "O" && button10.Text == "O")
                            button22.Text = "X";
                        else if (button20.Text == "O" && button01.Text == "O")
                            button22.Text = "X";
                        else if (button20.Text == "O" && button12.Text == "O")
                            button00.Text = "X";
                        else if (button22.Text == "O" && button10.Text == "O")
                            button02.Text = "X";
                        else if (button22.Text == "O" && button01.Text == "O")
                            button20.Text = "X";
                        break;
                    case 6:
                        checkYourPosition("X", "X");
                        if (countSteps == 7)
                            countSteps--;
                        else
                            checkYourPosition("O", "X");                        
                        if (countSteps == 7)
                            countSteps--;
                        else if (button10.Text == "" && button12.Text == "")
                        {
                            if (r.Next(1, 3) == 1)
                                button10.Text = "X";
                            else
                                button12.Text = "X";
                        }
                        else if (button01.Text == "" && button21.Text == "")
                        {
                            if (r.Next(1, 3) == 1)
                                button01.Text = "X";
                            else
                                button21.Text = "X";
                        }
                        break;
                    case 8:
                            randomButton("X");
                        break;
                }
            }
            else
            {
                Random r = new Random();                
                switch (countSteps)
                {                    
                    case 1:
                        int a = r.Next(1, 5);
                        if (button11.Text == "")
                            button11.Text = "O";
                        else if(a == 1)
                                button00.Text = "O";
                        else if (a == 2)
                            button02.Text = "O";
                        else if (a == 3)
                            button20.Text = "O";
                        else 
                            button22.Text = "O";
                        break;
                    case 3:
                        checkYourPosition("X", "O");
                        if (countSteps == 4)
                            countSteps--;
                        else if (button11.Text == "X" || (button01.Text == "X" && button21.Text == "X") ||
                            (button10.Text == "X" && button12.Text == "X") || (button00.Text == "X" && button22.Text == "X") ||
                            (button20.Text == "X" && button02.Text == "X"))
                        {
                            List<Button> listCorners = new List<Button> { button00, button02, button20, button22 };
                            List<Button> listEmptyCorners = new List<Button>();
                            foreach (Button b in listCorners)
                            {
                                if (b.Text == "")
                                    listEmptyCorners.Add(b);
                            }
                            listEmptyCorners[r.Next(0, listEmptyCorners.Count)].Text = "O";
                        }
                        else if (button01.Text == "X" && button10.Text == "X")
                            button00.Text = "O";
                        else if (button01.Text == "X" && button12.Text == "X")
                            button02.Text = "O";
                        else if (button21.Text == "X" && button10.Text == "X")
                            button20.Text = "O";
                        else if (button12.Text == "X" && button21.Text == "X")
                            button22.Text = "O";
                        else if (button01.Text == "X" && (button20.Text == "X" || button22.Text == "X"))
                        {
                            a = r.Next(1, 3);
                            if (a == 1)
                                button00.Text = "O";
                            else
                                button02.Text = "O";
                        }
                        else if (button10.Text == "X" && (button02.Text == "X" || button22.Text == "X"))
                        {
                            a = r.Next(1, 3);
                            if (a == 1)
                                button00.Text = "O";
                            else
                                button20.Text = "O";
                        }
                        else if (button21.Text == "X" && (button00.Text == "X" || button02.Text == "X"))
                        {
                            a = r.Next(1, 3);
                            if (a == 1)
                                button20.Text = "O";
                            else
                                button22.Text = "O";
                        }
                        else if (button12.Text == "X" && (button00.Text == "X" || button20.Text == "X"))
                        {
                            a = r.Next(1, 3);
                            if (a == 1)
                                button22.Text = "O";
                            else
                                button02.Text = "O";
                        }
                        break;
                    case 5:
                        checkYourPosition("O", "O");
                        if (countSteps == 6)
                        {
                            countSteps--;
                            break;
                        }                            
                        else
                            checkYourPosition("X", "O");
                        if (countSteps == 6)
                            countSteps--;
                        else
                            randomButton("O");
                        break;
                    case 7:
                        checkYourPosition("O", "O");
                        if (countSteps == 8)
                        {
                            countSteps--;
                            break;
                        }                            
                        else
                            checkYourPosition("X", "O");
                        if (countSteps == 8)
                            countSteps--;
                        else
                            randomButton("O");
                        break;
                }
            }
        }

        void checkYourPosition(string s, string t)
        {
            countSteps++;
            if (button00.Text == s && button01.Text == s && button02.Text == "")
                button02.Text = t;
            else if (button00.Text == s && button02.Text == s && button01.Text == "")
                button01.Text = t;
            else if (button01.Text == s && button02.Text == s && button00.Text == "")
                button00.Text = t;
            else if (button00.Text == s && button10.Text == s && button20.Text == "")
                button20.Text = t;
            else if (button00.Text == s && button20.Text == s && button10.Text == "")
                button10.Text = t;
            else if (button10.Text == s && button20.Text == s && button00.Text == "")
                button00.Text = t;
            else if (button02.Text == s && button12.Text == s && button22.Text == "")
                button22.Text = t;
            else if (button02.Text == s && button22.Text == s && button12.Text == "")
                button12.Text = t;
            else if (button12.Text == s && button22.Text == s && button02.Text == "")
                button02.Text = t;
            else if (button20.Text == s && button21.Text == s && button22.Text == "")
                button22.Text = t;
            else if (button20.Text == s && button22.Text == s && button21.Text == "")
                button21.Text = t;
            else if (button22.Text == s && button21.Text == s && button20.Text == "")
                button20.Text = t;
            else if (button00.Text == s && button11.Text == s && button22.Text == "")
                button22.Text = t;
            else if (button00.Text == s && button22.Text == s && button11.Text == "")
                button11.Text = t;
            else if (button22.Text == s && button11.Text == s && button00.Text == "")
                button00.Text = t;
            else if (button20.Text == s && button11.Text == s && button02.Text == "")
                button02.Text = t;
            else if (button20.Text == s && button02.Text == s && button11.Text == "")
                button11.Text = t;
            else if (button02.Text == s && button11.Text == s && button20.Text == "")
                button20.Text = t;
            else if (button01.Text == s && button11.Text == s && button21.Text == "")
                button21.Text = t;
            else if (button01.Text == s && button21.Text == s && button11.Text == "")
                button11.Text = t;
            else if (button21.Text == s && button11.Text == s && button01.Text == "")
                button01.Text = t;
            else if (button10.Text == s && button11.Text == s && button12.Text == "")
                button12.Text = t;
            else if (button10.Text == s && button12.Text == s && button11.Text == "")
                button11.Text = t;
            else if (button12.Text == s && button11.Text == s && button10.Text == "")
                button10.Text = t;
            else
            {
                countSteps--;
            }
        }
    }
}