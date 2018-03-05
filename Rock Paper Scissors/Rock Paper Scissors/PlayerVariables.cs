using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class PlayerVariables
    {

        public static int currentRound = 1; //current round
        public static int rounds; //maximum amount of rounds that can be played
        public static Player playerOne;
        public static Player playerTwo;
        public static frmLaunch mainForm;

        //Purpose: resets the stats of the game
        public static void Reset()
        {

            currentRound = 1;
            rounds = 0;

            playerOne.IsComputer = false;
            playerOne.Score = 0;
            playerOne.PlayerNumber = 0;

            playerTwo.IsComputer = false;
            playerTwo.Score = 0;
            playerTwo.PlayerNumber = 0;

        }

    }
}
