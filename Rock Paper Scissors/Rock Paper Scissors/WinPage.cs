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
    public partial class WinPage : Form
    {
        public WinPage()
        {

            InitializeComponent();

            lblPlayer1Score.Text = PlayerVariables.playerOne.Score.ToString();
            lblPlayer2Score.Text = PlayerVariables.playerTwo.Score.ToString();

            if (PlayerVariables.playerOne.Winner)
            {

                lblWinner.Text = "Player One Wins!";
                lblWinner.ForeColor = Color.FromArgb(0, 64, 0); //changes font color to match  results page

            }
            else
            {
                lblWinner.Text = "Player Two Wins!";
                lblWinner.ForeColor = Color.Red;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
