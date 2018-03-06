using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{

    public partial class PlayerChoice : Form
    {

        private Player current; //the current player in this instance of PlayerChoice


        //Purpose: creates a window for the current player to pick which choice they would like for the round
        //Input:
        //  player: the current player who gets to pick their choice between rock, paper, and scissors for the round
        public PlayerChoice(Player player)
        {

            current = player; 

            InitializeComponent();

            this.Text = "Player " + current.PlayerNumber.ToString() + " Choice"; //changes text to say current player number

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        //Purpose: get the player's choice for the round, and then either open the page with the results of the round, or open the options for the next player
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //checks which button is checked to assign that choice to the respective player
            if (btnScissors.Checked)
            {
                current.PlayerChoice = Player.Choice.SCISSORS;
            }
            else if (btnPaper.Checked)
            {
                current.PlayerChoice = Player.Choice.PAPER;
            }
            else
            {
                current.PlayerChoice = Player.Choice.ROCK;
            }

            //checks whether player 2 is a computer, or if the current player is player 2 so that the results page for the round can be displayed
            if (PlayerVariables.playerTwo.IsComputer || current.PlayerNumber == 2)
            {

                //picks a random choice for the computer if playerTwo is a computer
                if(PlayerVariables.playerTwo.IsComputer)
                {

                    Random rnd = new Random(); //used to generate the index of the value in Player.Choice that the computer will use this round

                    PlayerVariables.playerTwo.PlayerChoice = ((Player.Choice)rnd.Next(0, 3));

                }

                Results result = new Results(); //creates a form to show the results of the round 

                result.CheckWin();

                this.Close(); //closes the player choice window for the current player

                if ((Convert.ToDouble(PlayerVariables.playerOne.Score)) / PlayerVariables.rounds > .5 || (Convert.ToDouble(PlayerVariables.playerTwo.Score)) / PlayerVariables.rounds > .5) //checks whether or not a player has won the game, and displays the final score if a player has
                {

                    WinPage win = new WinPage(); //displays a page showing has won the game

                    win.Show();

                }
                else
                {

                    result.Show(); //shows the results of the round

                }

            } 
            else
            {

                PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerTwo);

                this.Close(); //closes the PlayerChoice window for the current player

                playerChoice.Show(); //show the PlayerChoice window for player 2

            }

        }
    }
}
