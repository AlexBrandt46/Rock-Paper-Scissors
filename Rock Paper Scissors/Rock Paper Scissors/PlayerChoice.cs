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

        public PlayerChoice(Player player)
        {

            current = player;

            InitializeComponent();

            this.Text = "Player " + current.PlayerNumber.ToString() + " Choice"; //changes text to say current player number

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
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

                if ((Convert.ToDouble(PlayerVariables.playerOneScore)) / PlayerVariables.rounds > .5 || (Convert.ToDouble(PlayerVariables.playerTwoScore)) / PlayerVariables.rounds > .5)
                {

                    WinPage win = new WinPage();

                    win.Show();

                }
                else
                {

                    result.Show();

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
