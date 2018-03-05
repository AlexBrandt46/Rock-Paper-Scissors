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
    public partial class Results : Form
    {
        public Results()
        {

            InitializeComponent(); 

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            PlayerVariables.currentRound++; //updates the round count

            PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerOne);

            this.Close();

            playerChoice.Show();

        }

        //Purpose: check which player one based on the simple rules of rock, paper, scissors
        public void CheckWin()
        {

            PlayerVariables.playerOne.Winner = false;
            PlayerVariables.playerTwo.Winner = false;

            if (PlayerVariables.playerOne.PlayerChoice == Player.Choice.PAPER)
            {
                if (PlayerVariables.playerTwo.PlayerChoice == Player.Choice.ROCK)
                {
                    PlayerVariables.playerOne.Winner = true;
                    PlayerVariables.playerTwo.Winner = false;
                }
                else if (PlayerVariables.playerTwo.PlayerChoice == Player.Choice.SCISSORS)
                {
                    PlayerVariables.playerTwo.Winner = true;
                    PlayerVariables.playerOne.Winner = false;
                }
            }
            else if (PlayerVariables.playerOne.PlayerChoice == Player.Choice.ROCK)
            {
                if (PlayerVariables.playerTwo.PlayerChoice == Player.Choice.SCISSORS)
                {
                    PlayerVariables.playerOne.Winner = true;
                    PlayerVariables.playerTwo.Winner = false;
                }
                else if (PlayerVariables.playerTwo.PlayerChoice == Player.Choice.PAPER)
                {
                    PlayerVariables.playerTwo.Winner = true;
                    PlayerVariables.playerOne.Winner = false;
                }
            }
            else if(PlayerVariables.playerOne.PlayerChoice == Player.Choice.SCISSORS)
            {
                if (PlayerVariables.playerTwo.PlayerChoice == Player.Choice.PAPER)
                {
                    PlayerVariables.playerOne.Winner = true;
                    PlayerVariables.playerTwo.Winner = false;
                }
                else if (PlayerVariables.playerTwo.PlayerChoice == Player.Choice.ROCK)
                {
                    PlayerVariables.playerTwo.Winner = true;
                    PlayerVariables.playerOne.Winner = false;
                }
            }

            UpdateScoreboard(); 

        }

        //Purpose: updates information on the scoreboard
        private void UpdateScoreboard()
        {

            if (PlayerVariables.playerOne.Winner)
            {
                lblWin.Text = "Player One Wins";
                PlayerVariables.playerOne.Score++; //increments player 1's score by 1
            }
            else if (PlayerVariables.playerOne.Winner == PlayerVariables.playerTwo.Winner) //checks if there's a tie
            {
                lblWin.Text = "Tie";
                PlayerVariables.currentRound--;
            }
            else
            {
                lblWin.Text = "Player Two Wins";
                PlayerVariables.playerTwo.Score++; //increments player 2's score by 1
            }

            //sets text of scoreboard
            lblPlayer1Score.Text = PlayerVariables.playerOne.Score.ToString();
            lblPlayer2Score.Text = PlayerVariables.playerTwo.Score.ToString();

            lblRoundCount.Text = PlayerVariables.currentRound.ToString() + "/" + PlayerVariables.rounds.ToString();

        }

    }
}
