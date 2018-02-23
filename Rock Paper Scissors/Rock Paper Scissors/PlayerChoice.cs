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

        Player current;
        Player next;

        public PlayerChoice(Player playerOne, Player playerTwo)
        {

            InitializeComponent();

            current = playerOne;
            next = playerTwo;

            this.Text = "Player " + current.PlayerNumber + " Choice";

        }

        public PlayerChoice(Player player)
        {

            InitializeComponent();

            current = player;

            this.Text = "Player " + current.PlayerNumber + " Choice";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            if (btnScissors.Checked)
            {
                PlayerVariables.choices[current.PlayerNumber - 1] = Player.Choice.SCISSORS;
            }
            else if (btnPaper.Checked)
            {
                PlayerVariables.choices[current.PlayerNumber - 1] = Player.Choice.PAPER;
            }
            else
            {
                PlayerVariables.choices[current.PlayerNumber - 1] = Player.Choice.ROCK;
            }

            if (next.IsComputer || current.PlayerNumber == 2)
            {
                Results result = new Results();
            } 
            else
            {

                PlayerChoice playerChoice = new PlayerChoice(next);

                playerChoice.Show();

            }

        }
    }
}
