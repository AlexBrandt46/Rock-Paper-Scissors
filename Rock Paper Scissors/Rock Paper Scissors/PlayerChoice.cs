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
        public PlayerChoice(Player player)
        {

            InitializeComponent();

            this.Text = "Player " + player.PlayerNumber + " Choice";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }
    }
}
