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

        private void btnSinglePlayer_Click(object sender, EventArgs e) {

            SetRounds();

            PlayerVariables.playerOne = new Player(1, false);
            PlayerVariables.playerTwo = new Player(2, true); //creates the computer to play against

            PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerOne);

            btn3Games.Checked = true;

            playerChoice.Show();

            this.Close();

        }

        private void btnTwoPlayer_Click(object sender, EventArgs e) {

            SetRounds();

            PlayerVariables.playerOne = new Player(1, false);
            PlayerVariables.playerTwo = new Player(2, false);

            PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerOne);

            btn3Games.Checked = true;

            playerChoice.Show();

            this.Hide();

        }

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
