/****
* Programmer: Christopher Dack
* Date: 1/30/2016
* Assignment 1
* CITP 280, Spring 2016
****/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe_dack
{
    public partial class frmTicTacToe : Form
    {
        public frmTicTacToe()
        {
            InitializeComponent();
        }

        // Instantiate classes
        Player Player1 = new Player();
        Board Board1 = new Board();
        GameManager GameManager1 = new GameManager();

        private void btnSquare_Click(object sender, EventArgs e)
        {
            // Identify player by pulling playerTurn from GameManager object.
            // Player 1 is always X's; Player 2 is always O's.
            int playerID = GameManager1.playerTurn;

            // Identify button clicked using Tag property (1-9) added to
            // all gameboard buttons
            Button b = (Button)sender;
            string buttonID = b.Tag.ToString();

            switch (buttonID)
            {
                case ("1"):
                    if (playerID == 1)
                    {
                        btnSquare1.Text = "X";
                        Board1.gameBoard[0, 0] = 1;
                    }
                    else
                    {
                        btnSquare1.Text = "O";
                        Board1.gameBoard[0, 0] = -1;
                    }
                    btnSquare1.Enabled = false;
                    break;
                case ("2"):
                    if (playerID == 1)
                    {
                        btnSquare2.Text = "X";
                        Board1.gameBoard[0, 1] = 1;
                    }
                    else
                    {
                        btnSquare2.Text = "O";
                        Board1.gameBoard[0, 1] = -1;
                    }
                    btnSquare2.Enabled = false;
                    break;
                case ("3"):
                    if (playerID == 1)
                    {
                        btnSquare3.Text = "X";
                        Board1.gameBoard[0, 2] = 1;
                    }
                    else
                    {
                        btnSquare3.Text = "O";
                        Board1.gameBoard[0, 2] = -1;
                    }
                    btnSquare3.Enabled = false;
                    break;
                case ("4"):
                    if (playerID == 1)
                    {
                        btnSquare4.Text = "X";
                        Board1.gameBoard[1, 0] = 1;
                    }
                    else
                    {
                        btnSquare4.Text = "O";
                        Board1.gameBoard[1, 0] = -1;
                    }
                    btnSquare4.Enabled = false;
                    break;
                case ("5"):
                    if (playerID == 1)
                    {
                        btnSquare5.Text = "X";
                        Board1.gameBoard[1, 1] = 1;
                    }
                    else
                    {
                        btnSquare5.Text = "O";
                        Board1.gameBoard[1, 1] = -1;
                    }
                    btnSquare5.Enabled = false;
                    break;
                case ("6"):
                    if (playerID == 1)
                    {
                        btnSquare6.Text = "X";
                        Board1.gameBoard[1, 2] = 1;
                    }
                    else
                    {
                        btnSquare6.Text = "O";
                        Board1.gameBoard[1, 2] = -1;
                    }
                    btnSquare6.Enabled = false;
                    break;
                case ("7"):
                    if (playerID == 1)
                    {
                        btnSquare7.Text = "X";
                        Board1.gameBoard[2, 0] = 1;
                    }
                    else
                    {
                        btnSquare7.Text = "O";
                        Board1.gameBoard[2, 0] = -1;
                    }
                    btnSquare7.Enabled = false;
                    break;
                case ("8"):
                    if (playerID == 1)
                    {
                        btnSquare8.Text = "X";
                        Board1.gameBoard[2, 1] = 1;
                    }
                    else
                    {
                        btnSquare8.Text = "O";
                        Board1.gameBoard[2, 1] = -1;
                    }
                    btnSquare8.Enabled = false;
                    break;
                case ("9"):
                    if (playerID == 1)
                    {
                        btnSquare9.Text = "X";
                        Board1.gameBoard[2, 2] = 1;
                    }
                    else
                    {
                        btnSquare9.Text = "O";
                        Board1.gameBoard[2, 2] = -1;
                    }
                    btnSquare9.Enabled = false;
                    break;
            }
            // Call the IsWinner function
            IsWinner();
        }

        public void IsWinner()
        {
            Board1.DetermineWinner();
            if (Board1.gameWin == true)
            {
                GameManager1.gameNumber += 1;
                HighlightBoard();
                btnPlayAgain.Enabled = true;
                btnPlayAgain.ForeColor = SystemColors.ControlDarkDark;
                btnReset.Enabled = true;
                btnReset.ForeColor = SystemColors.ControlDarkDark;
                if (GameManager1.playerTurn == 1)
                {
                    Player1.player1WinTotal += 1;
                    lblPlayer1Wins.Text = Player1.player1WinTotal.ToString();
                    MessageBox.Show("Player 1 wins!");
                }
                else
                {
                    Player1.player2WinTotal += 1;
                    lblPlayer2Wins.Text = Player1.player2WinTotal.ToString();
                    MessageBox.Show("Player 2 wins!");
                }
                Board1.gameWin = false;
            }
            else
            {
                // Call the IsTie function to determine if the game is tied
                IsTie();
            }
        }

        public void IsTie()
        {
            Board1.DetermineTie();
            if (Board1.gameTie == true)
            {
                GameManager1.gameNumber += 1;
                Player1.tieTotal += 1;
                lblGamesTied.Text = Player1.tieTotal.ToString();
                btnPlayAgain.Enabled = true;
                btnPlayAgain.ForeColor = SystemColors.ControlDarkDark;
                btnReset.Enabled = true;
                btnReset.ForeColor = SystemColors.ControlDarkDark;
                Board1.gameTie = false;
                MessageBox.Show("It's a tie!");
            }
            else
            {
                // Because no win and no tie, change turns and continue play
                ChangeTurn();
            }

        }

        public void ChangeTurn()
        {
            if (GameManager1.playerTurn == 1)
            {
                GameManager1.playerTurn = 2;
                lblPlayerTurn.Text = "Player 2's Turn";
            }
            else
            {
                GameManager1.playerTurn = 1;
                lblPlayerTurn.Text = "Player 1's Turn";
            }
        }

        public void HighlightBoard()
        {
            int currentScenario = Board1.winScenario;
            switch (currentScenario)
            {
                case (1):
                    btnSquare1.BackColor = Color.Green;
                    btnSquare2.BackColor = Color.Green;
                    btnSquare3.BackColor = Color.Green;
                    break;
                case (2):
                    btnSquare4.BackColor = Color.Green;
                    btnSquare5.BackColor = Color.Green;
                    btnSquare6.BackColor = Color.Green;
                    break;
                case (3):
                    btnSquare7.BackColor = Color.Green;
                    btnSquare8.BackColor = Color.Green;
                    btnSquare9.BackColor = Color.Green;
                    break;
                case (4):
                    btnSquare1.BackColor = Color.Green;
                    btnSquare4.BackColor = Color.Green;
                    btnSquare7.BackColor = Color.Green;
                    break;
                case (5):
                    btnSquare2.BackColor = Color.Green;
                    btnSquare5.BackColor = Color.Green;
                    btnSquare8.BackColor = Color.Green;
                    break;
                case (6):
                    btnSquare3.BackColor = Color.Green;
                    btnSquare6.BackColor = Color.Green;
                    btnSquare9.BackColor = Color.Green;
                    break;
                case (7):
                    btnSquare1.BackColor = Color.Green;
                    btnSquare5.BackColor = Color.Green;
                    btnSquare9.BackColor = Color.Green;
                    break;
                case (8):
                    btnSquare7.BackColor = Color.Green;
                    btnSquare5.BackColor = Color.Green;
                    btnSquare3.BackColor = Color.Green;
                    break;
            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            int currentGameNumber = GameManager1.gameNumber;
            int remainder = currentGameNumber % 2;
            if (remainder == 0)
            {
                lblPlayerTurn.Text = "Player 2's Turn";
                GameManager1.playerTurn = 2;
            }
            else
            {
                lblPlayerTurn.Text = "Player 1's Turn";
                GameManager1.playerTurn = 1;
            }
            NewGame();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblPlayerTurn.Text = "Player 1's Turn";
            GameManager1.playerTurn = 1;
            GameManager1.gameNumber = 1;
            Player1.player1WinTotal = 0;
            lblPlayer1Wins.Text = Player1.player1WinTotal.ToString();
            Player1.player2WinTotal = 0;
            lblPlayer2Wins.Text = Player1.player2WinTotal.ToString();
            Player1.tieTotal = 0;
            lblGamesTied.Text = Player1.tieTotal.ToString();
            NewGame();
        }

        public void NewGame()
        {
            Board1.gameBoard[0, 0] = 0;
            Board1.gameBoard[0, 1] = 0;
            Board1.gameBoard[0, 2] = 0;
            Board1.gameBoard[1, 0] = 0;
            Board1.gameBoard[1, 1] = 0;
            Board1.gameBoard[1, 2] = 0;
            Board1.gameBoard[2, 0] = 0;
            Board1.gameBoard[2, 1] = 0;
            Board1.gameBoard[2, 2] = 0;
            btnSquare1.Text = "";
            btnSquare2.Text = "";
            btnSquare3.Text = "";
            btnSquare4.Text = "";
            btnSquare5.Text = "";
            btnSquare6.Text = "";
            btnSquare7.Text = "";
            btnSquare8.Text = "";
            btnSquare9.Text = "";
            btnSquare1.BackColor = Color.DarkSeaGreen;
            btnSquare2.BackColor = Color.DarkSeaGreen;
            btnSquare3.BackColor = Color.DarkSeaGreen;
            btnSquare4.BackColor = Color.DarkSeaGreen;
            btnSquare5.BackColor = Color.DarkSeaGreen;
            btnSquare6.BackColor = Color.DarkSeaGreen;
            btnSquare7.BackColor = Color.DarkSeaGreen;
            btnSquare8.BackColor = Color.DarkSeaGreen;
            btnSquare9.BackColor = Color.DarkSeaGreen;
            btnSquare1.Enabled = true;
            btnSquare2.Enabled = true;
            btnSquare3.Enabled = true;
            btnSquare4.Enabled = true;
            btnSquare5.Enabled = true;
            btnSquare6.Enabled = true;
            btnSquare7.Enabled = true;
            btnSquare8.Enabled = true;
            btnSquare9.Enabled = true;
            btnPlayAgain.Enabled = false;
            btnPlayAgain.ForeColor = SystemColors.AppWorkspace;
            btnReset.Enabled = false;
            btnReset.ForeColor = SystemColors.AppWorkspace;
            lblGameNumber.Text = GameManager1.gameNumber.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTicTacToe_Load(object sender, EventArgs e)
        {

        }

        private void btnJunk_Click(object sender, EventArgs e)
        {
        }
    }
}
