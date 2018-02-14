using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    public class Player
    {

        private int playerNumber; //determines whether player is Player 1 or Player 2
        public enum Choice //player's choice
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        public Player(int num)
        {

            playerNumber = num;

        }

        //Purpose: return the player's number
        public int PlayerNumber {
            get {
                return playerNumber;
            }
        }

        //Purpose: gets and sets the player's choice
        public Choice PlayerChoice {
            get;
            set;
        }
    }
}
