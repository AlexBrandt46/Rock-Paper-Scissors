using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class PlayerVariables
    {

        public static int rounds; //maximum amount of rounds that can be played
        public static int playerOneScore = 0;
        public static int playerTwoScore = 0;
        public static Player.Choice[] choices = new Player.Choice[2]; //each player's choices


    }
}
