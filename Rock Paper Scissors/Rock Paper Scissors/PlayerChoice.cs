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

        private Player current;

        public PlayerChoice(Player player)
        {

            current = player;

            InitializeComponent();

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

            if (current.IsComputer || current.PlayerNumber == 2)
            {
                Results result = new Results();
            } 
            else
            {

                PlayerChoice playerChoice = new PlayerChoice(PlayerVariables.playerTwo);

                playerChoice.Show();

            }

        }
    }
}
