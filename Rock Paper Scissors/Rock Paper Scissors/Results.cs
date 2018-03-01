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

            CheckWin();

            if (PlayerVariables.playerOne.Winner)
            {
                lblWin.Text = "Player One Wins";
            }
            else
            {
                lblWin.Text = "Player Two Wins";
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void CheckWin()
        {
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
            else
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
        }

    }
}
