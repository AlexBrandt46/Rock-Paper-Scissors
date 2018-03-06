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
    public partial class frmLaunch : Form
    {

        //Purpose: creates a window to select how many games to play, and whether it's single-player or two-player
        public frmLaunch()
        {
            InitializeComponent();

            PlayerVariables.mainForm = this;
        }

        //Purpose: confirms whether or not the user would like to close the application
        private void btnExit_Click(object sender, EventArgs e)
        {

            DialogResult result; //the user result from the message box

            result = MessageBox.Show("Would you like to close the game?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {

                this.Close();

            }

        }

        //Purpose: creates a single player game against a computer if clicked
        private void btnSinglePlayer_Click(object sender, EventArgs e) {

            SetRounds();

            PlayerVariables.playerOne = new Player(1, false); //the player controlled by the user
            PlayerVariables.playerTwo = new Player(2, true); //creates the computer to play against

            PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerOne);

            btn3Games.Checked = true;

            playerChoice.Show();

            this.Hide();

        }

        //Purpose: creates a two player game
        private void btnTwoPlayer_Click(object sender, EventArgs e) {

            SetRounds();

            PlayerVariables.playerOne = new Player(1, false);
            PlayerVariables.playerTwo = new Player(2, false);

            PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerOne);

            btn3Games.Checked = true;

            playerChoice.Show();

            this.Hide();

        }

        //Purpose: sets the maximum amount of rounds that can be played and have the score change (if there's a tie, then the score won't change)
        private void SetRounds() {
            if (btn7Games.Checked)
            {
                PlayerVariables.rounds = 7;
            }
            else if (btn5Games.Checked)
            {
                PlayerVariables.rounds = 5;
            }
            else
            {
                PlayerVariables.rounds = 3;
            }
        }
    }
}
