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

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {

            Player playerOne = new Player(1);

        }

        private void btnTwoPlayer_Click(object sender, EventArgs e)
        {

            Player playerOne = new Player(1);
            Player playerTwo = new Player(2);

        }
    }
}
