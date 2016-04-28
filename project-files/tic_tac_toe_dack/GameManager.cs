using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_dack
{
    class GameManager
    {
        // Member variables
        public int gameNumber;
        public int playerTurn;

        // Default constructor
        public GameManager()
        {
            gameNumber = 1;
            playerTurn = 1;
        }
    }
}
