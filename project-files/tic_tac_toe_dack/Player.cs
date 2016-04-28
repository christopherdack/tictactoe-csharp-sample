using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_dack
{
    class Player
    {
        // Member variables
        public int player1WinTotal;
        public int player2WinTotal;
        public int tieTotal;

        // Default constructor
        public Player()
        {
            player1WinTotal = 0;
            player2WinTotal = 0;
            tieTotal = 0;
        }
    }
}
