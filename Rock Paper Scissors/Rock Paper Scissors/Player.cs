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
        private static int rounds; //the amount of rounds to play

        public enum Choice //player's choice
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        public Player(int num, int roundAmount)
        {

            playerNumber = num;
            winner = false;
            rounds = roundAmount;

        }

        public Player(int num)
        {

            playerNumber = num;
            winner = false;

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
        

    }
}
