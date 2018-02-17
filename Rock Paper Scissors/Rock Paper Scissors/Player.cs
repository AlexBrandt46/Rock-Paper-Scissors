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
        private bool winner; //whether or not the player is the winner of the round
        private int rounds; //the amount of rounds to play
        private bool computer; //whether or not this instance of player is computer
        public static Choice[] choices = new Choice[2]; //each player's choices

        public enum Choice //player's choice
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        public Player(int num, bool isComputer, int roundAmount)
        {

            playerNumber = num;
            winner = false;
            rounds = roundAmount;
            computer = isComputer;

        }

        public Player(int num, bool isComputer)
        {

            playerNumber = num;
            winner = false;
            computer = isComputer;

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

        public bool Winner {
            get {
                return winner;
            }
            set {
                winner = value;
            }
        }

        public bool Computer {
            get {
                return computer;
            }
        }
    }
}
