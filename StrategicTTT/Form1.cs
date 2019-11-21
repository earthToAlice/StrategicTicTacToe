using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategicTTT
{
    public partial class Form1 : Form
    {
        // 1 or 2. Holds the current playing turn.
        int turn = 1;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 245, 238);
        }

        private void tile1_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            SwapTurns();
        }

        // ---- Custom Methods ---- //

        // =-=-=-= START TURN-RELATED METHODS =-=-=-= //
        private void SwapTurns()
        {
            switch (turn)
            {
                case 1:
                    turn = 2;
                    break;

                case 2:
                    turn = 1;
                    break;
            }

            TurnDisplay();

        } //swapTurn()

        private void TurnDisplay()
        {
            switch (turn)
            {
                case 1:
                    player1Label.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    player2Label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    player1Label.BackColor = Color.FromArgb(235, 225, 218);
                    player2Label.BackColor = Color.Transparent;
                    break;

                case 2:
                    player1Label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    player2Label.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    player1Label.BackColor = Color.Transparent;
                    player2Label.BackColor = Color.FromArgb(235, 225, 218);
                    break;
            }
        }

        
    }
}
