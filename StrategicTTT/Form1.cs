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

            ((TableLayoutPanel)Controls.Find($"miniGrid{((sbi2 + 1) + (sbi1 * 3))}", true)[0]).BackColor = Color.FromArgb(235, 225, 218);

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
            // Parses tileNum into 2 numbers usable as a 2D index
            int idx1 = tileNum / 3;
            int idx2 = tileNum % 3;
            if (superGrid[sbi1, sbi2] != '\0') { sbi1 = miniNum / 3; sbi2 = miniNum % 3; }

            char[,] activeGrid = boardGrid[sbi1, sbi2].Grid;
            
            // Executes if the player clicked inside the correct
            // miniGrid AND the tile clicked was empty
            if (CheckValidMini(miniNum) && (activeGrid[idx1, idx2] == '\0'))
            {
                // Sets the clicked tile to the playing letter
                activeGrid[idx1, idx2] = turn;
                boardGrid[sbi1, sbi2].playedTiles++;

                // If the miniGrid is full, set superGrid at current pos to ⨂
                if (boardGrid[sbi1, sbi2].playedTiles == 9) superGrid[sbi1, sbi2] = '⨂';

                // If the miniGrid was won, set superGrid at current pos to playing letter
                if (CheckWin(activeGrid)) superGrid[sbi1, sbi2] = turn;

                // Updates the winLabel for the current miniGrid
                if (superGrid[sbi1, sbi2] != '\0') UpdateWinLabel(miniNum);

                // If superGrid was won, terminate all processes and exit
                // [CHANGE TO WIN SCREEN]
                if (CheckWin(superGrid)) Application.Exit();
                
                // X => O or O => X
                SwapTurns();
                
                // Update the screen with the current grid
                boardGrid[sbi1, sbi2].UpdateMini(idx1, idx2);

                // Resets all TableLayoutPanel BGs
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ((TableLayoutPanel)Controls.Find($"miniGrid{((i + 1) + (j * 3))}", true)[0]).BackColor = Color.Transparent;
                    }
                }

                // Updates superBoardIndexes
                sbi1 = idx1;
                sbi2 = idx2;

                // Highlights current TableLayoutPanel
                SetMiniHighlight(miniNum);
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

        private bool CheckValidMini(int miniNum)
        {
            bool output;

            if (superGrid[sbi1, sbi2] == '\0')
            {
                output = (miniNum == (sbi2 + (sbi1 * 3)));
            }
            else
            {
                output = true;
            }

            return output;
        }

        private void UpdateWinLabel(int miniNum)
        {
            Panel activePanel = ((Panel)Controls.Find($"Cell{miniNum + 1}", true)[0]);
            Label activeLabel = ((Label)activePanel.Controls.Find($"winLabel{miniNum + 1}", true)[0]);
            activeLabel.Text = Convert.ToString(superGrid[sbi1, sbi2]);
            activeLabel.Visible = true;
        }

        private void SetMiniHighlight(int miniNum)
        {
            if (superGrid[sbi1, sbi2] == '\0')
            {
                ((TableLayoutPanel)Controls.Find($"miniGrid{((sbi2 + 1) + (sbi1 * 3))}", true)[0]).BackColor = Color.FromArgb(235, 225, 218);
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ((TableLayoutPanel)Controls.Find($"miniGrid{((i + 1) + (j * 3))}", true)[0]).BackColor = Color.FromArgb(235, 225, 218);
                    }
                }
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

        class Board
        {
            int miniID;
            public int playedTiles = 0;
            public char[,] Grid { get; set; } = new char[3, 3];
            Form f;

            public Board(int id, Form f) { miniID = id; this.f = f; }
            
            // Updates the objects on-screen grid with the values in Grid
            public void UpdateMini(int i, int j)
            {
                ((Label)f.Controls.Find($"Mini{miniID}Tile{((j + 1) + (i * 3))}", true)[0]).Text = Convert.ToString(Grid[i, j]);
            }
        }
    }
}
