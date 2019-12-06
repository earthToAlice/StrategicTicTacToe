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
        int sbi1 = 1, sbi2 = 1;
        // Holds the values of each tile
        Board[,] boardGrid = new Board[3, 3];
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
                    Label Current = ((Label)Controls.Find($"Mini{i}Tile{j}", true)[0]);
                    Current.Text = "";
                    Current.TextAlign = ContentAlignment.MiddleCenter;
                    Current.BorderStyle = BorderStyle.FixedSingle;
                    Current.Margin = new Padding(0);
                    Current.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardGrid[i, j] = new Board(((j + 1) + (i * 3)), this);
                }
            }

            this.BackColor = Color.FromArgb(255, 245, 238);
        }

        // Responds to any tile click
        private void Tile_Click(object sender, EventArgs e)
        {
            Label tile = (Label)sender;
            int tileNum = Convert.ToInt32(tile.Name.Substring(9))-1;
            int miniNum = Convert.ToInt32(tile.Name.Substring(4, 1))-1;
            UpdateBoard(tileNum, miniNum);
        }

        // ---- Custom Methods ---- //

        // =-=-=-= START GAME LOGIC METHODS =-=-=-= //

        private void UpdateBoard(int tileNum, int miniNum)
        {
            int i = tileNum / 3;
            int j = tileNum % 3;
            char[,] activeGrid = boardGrid[sbi1, sbi2].Grid;

            if ((miniNum == (sbi2 + (sbi1 * 3))) && (activeGrid[i, j] == '\0'))
            {
                activeGrid[i, j] = turn;
                
                if (CheckWin(activeGrid)) superGrid[sbi1, sbi2] = turn;
                if (CheckWin(superGrid)) Application.Exit();
                
                SwapTurns();
                
                boardGrid[sbi1, sbi2].Update();

                sbi1 = i;
                sbi2 = j;
            }
        }

        private bool CheckWin(char[,] activeGrid)
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
                    if (activeGrid[i, j] == turn) h++;
                    if (activeGrid[j, i] == turn) v++;
                    if (activeGrid[j, 2 - j] == turn) up++;
                    if (activeGrid[j, j] == turn) down++;
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

        class Board
        {
            int miniID;
            Form form;
            private char[,] grid = new char[3, 3];
            public char[,] Grid {
                get { return grid; }
                set { grid = value; }
            }

            public Board(int id, Form form)
            {
                miniID = id;
                this.form = form;
            }
            
            public void Update()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ((Label)form.Controls.Find($"Mini{miniID}Tile{((j + 1) + (i * 3))}", true)[0]).Text = Convert.ToString(grid[i, j]);
                    }
                }
            }
        }
    }
}
