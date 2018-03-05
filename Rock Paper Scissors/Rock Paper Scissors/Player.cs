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
        private int score; //the player's current score
        private bool winner; //whether or not the player is the winner of the round
        private bool isComputer; //whether or not this instance of player is computer

        public enum Choice //player's choice
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        public Player(int num, bool computer)
        {

            playerNumber = num;
            score = 0;
            winner = false;
            isComputer = computer;

        }

        //Purpose: return the player's number
        public int PlayerNumber {
            get {
                return playerNumber;
            }
        }

        //Purpose: gets and sets the player object's score
        public int Score {
            get {
                return score;
            }
            set {
                score = value;
            }
        }

        //Purpose: gets and sets the player's choice
        public Choice PlayerChoice {
            get;
            set;
        }

        //Purpose: gets and sets whether or not the player object is the winner of the round
        public bool Winner {
            get {
                return winner;
            }
            set {
                winner = value;
            }
        }

        //Purpose: returns whether or not the player object is the computer
        public bool IsComputer {
            get {
                return isComputer;
            }
        }
    }
}
