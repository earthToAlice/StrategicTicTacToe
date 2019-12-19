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
        // Manages the visibility of screens
        SceneManager sceneManager;
        // Holds all miniGrid Board objects
        Board[,] BoardGrid = new Board[3, 3];
        // Holds the value of each space on the large board
        char[,] SuperGrid = new char[3, 3];
        // SuperBoardIndexes 1 and 2 (location of current miniGrid)
        int sbi1 = 1, sbi2 = 1;
        // Holds the current turn
        char turn = 'X';

        // Ininitalizes the form and sets up all components
        public Form1()
        {
            // Library-made method
            InitializeComponent();

            // Creates a new SceneManager and gives access to game, win, and rules screens
            sceneManager = new SceneManager(gameScreen1, winScreen1, rulesScreen1);
            // Links all singular event handlers for buttons
            ((Button)winScreen1.Controls.Find("restartBtn", true)[0]).Click += new EventHandler(RestartBtn_Click);
            ((Label)gameScreen1.Controls.Find("rulesLabel", true)[0]).Click += new EventHandler(HTP_Click);
            ((Label)rulesScreen1.Controls.Find("backBtn", true)[0]).Click += new EventHandler(backBtn_Click);

            // Links every tile to event handler Tile_Click
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    ((Label)gameScreen1.Controls.Find($"Mini{i}Tile{j}", true)[0]).Click += new EventHandler(Tile_Click);
                }
            }

            // Initializes every board object with miniID and the form
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BoardGrid[i, j] = new Board((j + 1) + (i * 3), this);
                }
            }

            // Highlights the center miniGrid
            ((TableLayoutPanel)Controls.Find("miniGrid5", true)[0]).BackColor = Color.FromArgb(235, 225, 218);

            gameScreen1.TurnDisplay(turn);

        }

        // Shows the instructions screen when How to Play button is clicked
        private void HTP_Click(object sender, EventArgs e)
        {
            sceneManager.ShowInstructions();
        }

        // Shows the game screen when the back button on the instructions screen is clicked
        private void backBtn_Click(object sender, EventArgs e)
        {
            sceneManager.ShowGameScreen();
        }

        // Resets the board and shows the game screen when restart button is clicked
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            ResetBoard();
            sceneManager.ShowGameScreen();
        }

        // When any tile is clicked, call UpdateBoard with specific tile's info
        private void Tile_Click(object sender, EventArgs e)
        {
            Label tile = (Label)sender;
            int tileNum = Convert.ToInt32(tile.Name.Substring(9)) - 1;
            int miniNum = Convert.ToInt32(tile.Name.Substring(4, 1)) - 1;
            UpdateBoard(tileNum, miniNum);
        }

        // Checks if the tile is valid, updates the display, checks if anyone
        // won, and sets up for next turn
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
                if (SuperGrid[sbi1, sbi2] != '\0') gameScreen1.UpdateWinLabel(miniNum);

                // If SuperGrid was won, terminate all processes and exit
                // [CHANGE TO WIN SCREEN]
                if (CheckWin(SuperGrid)) sceneManager.ShowWinner(turn);

                // X => O or O => X
                SwapTurns();

                // Update the screen with the current grid
                BoardGrid[sbi1, sbi2].UpdateMini(idx1, idx2);

                // Updates superBoardIndexes
                sbi1 = idx1;
                sbi2 = idx2;

                // Highlights current TableLayoutPanel
                gameScreen1.SetMiniHighlight(SuperGrid, sbi1, sbi2);
            }
        }

        // Checks whether the selected grid has been won
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

        // Checks whether the tile clicked was within the correct miniGrid
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

        // Swaps between X and O
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

        // Fully resets the board
        private void ResetBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    BoardGrid[i, j].Reset();
                    SuperGrid[i, j] = '\0';
                }
            }

            sbi1 = 1;
            sbi2 = 1;

            gameScreen1.Reset();
        }

        // Manages each miniGrid and it's display
        public class Board
        {
            int miniID;
            public int playedTiles = 0;
            private Form c;
            public char[,] Grid { get; set; } = new char[3, 3];

            public Board(int id, Form c)
            {
                miniID = id;
                this.c = c;
            }

            // Updates the objects on-screen grid with the values in Grid
            public void UpdateMini(int i, int j)
            {
                ((Label)c.Controls.Find($"Mini{miniID}Tile{(j + 1 + (i * 3))}", true)[0]).Text = Convert.ToString(Grid[i, j]);
            }

            // Resets the individual miniGrid
            public void Reset()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Grid[i, j] = '\0';
                    }
                }
            }
        }
    }

    // Manages the different screens
    class SceneManager
    {
        UserControl gameScreen, winScreen, rulesScreen;

        public SceneManager(UserControl game, UserControl win, UserControl rules)
        {
            gameScreen = game;
            winScreen = win;
            rulesScreen = rules;
        }

        public void ShowGameScreen()
        {
            gameScreen.BringToFront();
        }

        public void ShowInstructions()
        {
            rulesScreen.BringToFront();
        }

        public void ShowWinner(char winner)
        {
            winScreen.BringToFront();
            ((Label)winScreen.Controls.Find("congratsMsg", true)[0]).Text = $"{winner} Wins!";
        }
    }
}
