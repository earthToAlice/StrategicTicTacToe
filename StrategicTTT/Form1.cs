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
        SceneManager sceneManager;
        // Holds the values of each tile
        Board[,] BoardGrid = new Board[3, 3];
        char[,] SuperGrid = new char[3, 3];
        int sbi1 = 1, sbi2 = 1;
        char turn = 'X';

        public Form1()
        {
            InitializeComponent();

            sceneManager = new SceneManager(gameScreen1, winScreen1);
            ((Button)winScreen1.Controls.Find("restartBtn", true)[0]).Click += new EventHandler(RestartBtn_Click);

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    ((Label)gameScreen1.Controls.Find($"Mini{i}Tile{j}", true)[0]).Click += new EventHandler(Tile_Click);
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BoardGrid[i, j] = new Board((j + 1) + (i * 3), this);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RestartBtn_Click(object sender, EventArgs e)
        {
            sceneManager.ShowGameScreen();
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            Label tile = (Label)sender;
            int tileNum = Convert.ToInt32(tile.Name.Substring(9)) - 1;
            int miniNum = Convert.ToInt32(tile.Name.Substring(4, 1)) - 1;
            UpdateBoard(tileNum, miniNum);
        }

        private void UpdateBoard(int tileNum, int miniNum)
        { //nice
            // Parses tileNum into 2 numbers usable as a 2D index
            int idx1 = tileNum / 3;
            int idx2 = tileNum % 3;
            if (SuperGrid[sbi1, sbi2] != '\0') { sbi1 = miniNum / 3; sbi2 = miniNum % 3; }

            char[,] activeGrid = BoardGrid[sbi1, sbi2].Grid;

            // Executes if the player clicked inside the correct
            // miniGrid AND the tile clicked was empty
            if (CheckValidMini(miniNum) && (activeGrid[idx1, idx2] == '\0'))
            {
                // Sets the clicked tile to the playing letter
                activeGrid[idx1, idx2] = turn;
                BoardGrid[sbi1, sbi2].playedTiles++;

                // If the miniGrid is full, set SuperGrid at current pos to ⨂
                if (BoardGrid[sbi1, sbi2].playedTiles == 9) SuperGrid[sbi1, sbi2] = '⨂';

                // If the miniGrid was won, set SuperGrid at current pos to playing letter
                if (CheckWin(activeGrid)) SuperGrid[sbi1, sbi2] = turn;

                // Updates the winLabel for the current miniGrid
                if (SuperGrid[sbi1, sbi2] != '\0') gameScreen1.UpdateWinLabel(miniNum, turn);

                // If SuperGrid was won, terminate all processes and exit
                // [CHANGE TO WIN SCREEN]
                if (CheckWin(SuperGrid)) Application.Exit();

                // X => O or O => X
                SwapTurns();

                // Update the screen with the current grid
                BoardGrid[sbi1, sbi2].UpdateMini(idx1, idx2);

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
                gameScreen1.SetMiniHighlight(SuperGrid, sbi1, sbi2);
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

            if (SuperGrid[sbi1, sbi2] == '\0')
            {
                output = (miniNum == (sbi2 + (sbi1 * 3)));
            }
            else
            {
                output = true;
            }

            return output;
        }

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

            gameScreen1.TurnDisplay(turn);

        } //swapTurn()

        // Manages each miniGrid and it's display
        public class Board
        {
            int miniID;
            public int playedTiles = 0;
            private Form c;
            public char[,] Grid { get; set; } = new char[3, 3];

            public Board(int id, Form c) { miniID = id; this.c = c; }

            // Updates the objects on-screen grid with the values in Grid
            public void UpdateMini(int i, int j)
            {
                ((Label)c.Controls.Find($"Mini{miniID}Tile{(j + 1 + (i * 3))}", true)[0]).Text = Convert.ToString(Grid[i, j]);
            }
        }
    }

    // Manages the different screens
    class SceneManager : Form1
    {
        UserControl gameScreen;
        UserControl winScreen;

        public SceneManager(UserControl game, UserControl win)
        {
            gameScreen = game;
            winScreen = win;
        }

        public void ShowGameScreen()
        {
            gameScreen.BringToFront();
        }

        public void ShowWinner(char winner)
        {
            winScreen.BringToFront();
            ((Label)winScreen.Controls.Find("congratsMsg", true)[0]).Text = $"{winner} Wins!";
        }
    }
}
