using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Player
    {

        private int playerNumber;
        public enum Choice
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        public Player(int num)
        {

            playerNumber = num;

        }

        public int PlayerNumber {
            get {
                return playerNumber;
            }
        }

        public Choice PlayerChoice {
            get;
            set;
        }
    }
}
