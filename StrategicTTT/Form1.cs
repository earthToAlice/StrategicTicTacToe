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
        char[,] superGrid = new char[3, 3];
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    ((Label)this.Controls.Find($"Mini{i}Tile{j}", true)[0]).Text = $"{i*j}";
                }
            }
            this.BackColor = Color.FromArgb(255, 245, 238);
        }

        

        // ---- Custom Methods ---- //

        // =-=-=-= START GAME LOGIC METHODS =-=-=-= //

        private void UpdateBoard(int tileNum, Label tile)
        {
            int i = tileNum % 3;
            int j = tileNum / 3;

            if (grid[i, j] == '\0')
            {
                grid[i, j] = turn;
                tile.Text = Convert.ToString(grid[i, j]);
                if (CheckWin()) superGrid[i, j] = turn;
                SwapTurns();
            }
            
        }

        private bool CheckWin()
        {
            int h, v, up, down;

            for (int i = 0; i < 3; i++)
            {
                h = 0;
                v = 0;
                up = 0;
                down = 0;
                
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == turn) h++;
                    if (grid[j, i] == turn) v++;
                    if (grid[j, 2 - j] == turn) up++;
                    if (grid[j, j] == turn) down++;
                    if (h == 3 || v == 3 || up == 3 || down == 3) return true;
                }
            }

            return false;
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
