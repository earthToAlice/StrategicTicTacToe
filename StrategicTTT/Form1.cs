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
        char turn = 'X';
        // Holds the values of each tile
        char[,] grid = new char[3, 3];
 
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
            UpdateBoard(1, tile1);
        }

        private void tile2_Click(object sender, EventArgs e)
        {
            UpdateBoard(2, tile2);
        }

        private void tile3_Click(object sender, EventArgs e)
        {
            UpdateBoard(3, tile3);
        }

        private void tile4_Click(object sender, EventArgs e)
        {
            UpdateBoard(4, tile4);
        }

        private void tile5_Click(object sender, EventArgs e)
        {
            UpdateBoard(5, tile5);
        }

        private void tile6_Click(object sender, EventArgs e)
        {
            UpdateBoard(6, tile6);
        }

        private void tile7_Click(object sender, EventArgs e)
        {
            UpdateBoard(7, tile7);
        }

        private void tile8_Click(object sender, EventArgs e)
        {
            UpdateBoard(8, tile8);
        }

        private void tile9_Click(object sender, EventArgs e)
        {
            UpdateBoard(9, tile9);
        }

        // ---- Custom Methods ---- //

        // =-=-=-= START GAME LOGIC METHODS =-=-=-= //

        private void UpdateBoard(int tileNum, Label tile)
        {
            int i = 0, j;
            while ((tileNum - 1) - (i * 3) >= 3) i++;
            j = (tileNum - 1) - (i * 3);

            if (grid[i, j] == '\0')
            {
                grid[i, j] = turn;
                tile.Text = Convert.ToString(grid[i, j]);
                SwapTurns();
            }
        }

        // =-=-=-= END GAME LOGIC METHODS =-=-=-= //

        // =-=-=-= START TURN-RELATED METHODS =-=-=-= //

        private void SwapTurns()
        {
            switch (turn)
            {
                case 'X':
                    turn = 'O';
                    break;

                case 'O':
                    turn = 'X';
                    break;
            }

            TurnDisplay();

        } //swapTurn()

        private void TurnDisplay()
        {
            switch (turn)
            {
                case 'X':
                    player1Label.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    player2Label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    player1Label.BackColor = Color.FromArgb(235, 225, 218);
                    player2Label.BackColor = Color.Transparent;
                    break;

                case 'O':
                    player1Label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    player2Label.Font = new Font("Microsoft Sans Serif", 25, FontStyle.Bold);
                    player1Label.BackColor = Color.Transparent;
                    player2Label.BackColor = Color.FromArgb(235, 225, 218);
                    break;
            }
        }

        // =-=-=-= END TURN-RELATED METHODS =-=-=-= //
        
    }
}
