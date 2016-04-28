using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_dack
{
    class Board
    {
        // Member variables
        public bool gameWin;
        public bool gameTie;
        public int winScenario;
        public short[,] gameBoard = new short[3, 3];

        // Default constructor
        public Board()
        {
            gameWin = false;
            gameTie = false;
            winScenario = -1;
            gameBoard[0, 0] = 0;
            gameBoard[0, 1] = 0;
            gameBoard[0, 2] = 0;
            gameBoard[1, 0] = 0;
            gameBoard[1, 1] = 0;
            gameBoard[1, 2] = 0;
            gameBoard[2, 0] = 0;
            gameBoard[2, 1] = 0;
            gameBoard[2, 2] = 0;
        }
        public void DetermineWinner()
        {
            if (gameBoard[0,0] + gameBoard[0,1] + gameBoard[0,2] == 3 ||
                gameBoard[0, 0] + gameBoard[0, 1] + gameBoard[0, 2] == -3)
            {
                gameWin = true;
                winScenario = 1;
            }
            else if (gameBoard[1,0] + gameBoard[1,1] + gameBoard[1,2] == 3 ||
                     gameBoard[1, 0] + gameBoard[1, 1] + gameBoard[1, 2] == -3)
            {
                gameWin = true;
                winScenario = 2;
            }
            else if (gameBoard[2,0] + gameBoard[2,1] + gameBoard[2,2] == 3 ||
                     gameBoard[2, 0] + gameBoard[2, 1] + gameBoard[2, 2] == -3)
            {
                gameWin = true;
                winScenario = 3;
            }
            else if (gameBoard[0,0] + gameBoard[1,0] + gameBoard[2,0] == 3 ||
                     gameBoard[0, 0] + gameBoard[1, 0] + gameBoard[2, 0] == -3)
            {
                gameWin = true;
                winScenario = 4;
            }
            else if (gameBoard[0,1] + gameBoard[1,1] + gameBoard[2,1] == 3 ||
                     gameBoard[0, 1] + gameBoard[1, 1] + gameBoard[2, 1] == -3)
            {
                gameWin = true;
                winScenario = 5;
            }
            else if (gameBoard[0,2] + gameBoard[1,2] + gameBoard[2,2] == 3 ||
                     gameBoard[0, 2] + gameBoard[1, 2] + gameBoard[2, 2] == -3)
            {
                gameWin = true;
                winScenario = 6;
            }
            else if (gameBoard[0,0] + gameBoard[1,1] + gameBoard[2,2] == 3 ||
                     gameBoard[0, 0] + gameBoard[1, 1] + gameBoard[2, 2] == -3)
            {
                gameWin = true;
                winScenario = 7;
            }
            else if (gameBoard[2,0] + gameBoard[1,1] + gameBoard[0,2] == 3 ||
                     gameBoard[2, 0] + gameBoard[1, 1] + gameBoard[0, 2] == -3)
            {
                gameWin = true;
                winScenario = 8;
            }
            else
            {
                gameWin = false;
            }
        }

        public void DetermineTie()
        {
            if (
            gameBoard[0,0] != 0 &&
            gameBoard[0,1] != 0 &&
            gameBoard[0,2] != 0 &&
            gameBoard[1,0] != 0 &&
            gameBoard[1,1] != 0 &&
            gameBoard[1,2] != 0 &&
            gameBoard[2,0] != 0 &&
            gameBoard[2,1] != 0 &&
            gameBoard[2,2] != 0)
            {
                gameTie = true;
            } 
        }
    }
}
