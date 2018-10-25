using System;
//  Uncomment  this using statement after you have remove the large Block Comment below 
using System.Drawing;
using System.Windows.Forms;
using Game_Logic_Class;
//  Uncomment  this using statement when you declare any object from Object Classes, eg Board,Square etc.
using Object_Classes;

namespace GUI_Class
{
    public partial class SpaceRaceForm : Form
    {
        // The numbers of rows and columns on the screen.
        const int NUM_OF_ROWS = 7;
        const int NUM_OF_COLUMNS = 8;
        private int[] prevSquare;
        private int playerStep = 0;
        private bool eachStep = true;
        // When we update what's on the screen, we show the movement of a player 
        // by removing them from their old square and adding them to their new square.
        // This enum makes it clear that we need to do both.
        enum TypeOfGuiUpdate { AddPlayer, RemovePlayer };


        public SpaceRaceForm()
        {
            InitializeComponent();
            Board.SetUpBoard();
            ResizeGUIGameBoard();
            SetUpGUIGameBoard();
            SetupPlayersDataGridView();
            DetermineNumberOfPlayers();
            SpaceRaceGame.SetUpPlayers();
            PrepareToPlay();
        }


        /// <summary>
        /// Handle the Exit button being clicked.
        /// Pre:  the Exit button is clicked.
        /// Post: the game is terminated immediately
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        //  ******************* Uncomment - Remove Block Comment below
        //                         once you've added the TableLayoutPanel to your form.
        //
        //       You will have to replace "tableLayoutPanel" by whatever (Name) you used.
        //
        //        Likewise with "playerDataGridView" by your DataGridView (Name)
        //  ******************************************************************************************


        /// <summary>
        /// Resizes the entire form, so that the individual squares have their correct size, 
        /// as specified by SquareControl.SQUARE_SIZE.  
        /// This method allows us to set the entire form's size to approximately correct value 
        /// when using Visual Studio's Designer, rather than having to get its size correct to the last pixel.
        /// Pre:  none.
        /// Post: the board has the correct size.
        /// </summary>
        private void ResizeGUIGameBoard()
        {
            const int SQUARE_SIZE = SquareControl.SQUARE_SIZE;
            int currentHeight = tableLayoutPanel.Size.Height;
            int currentWidth = tableLayoutPanel.Size.Width;
            int desiredHeight = SQUARE_SIZE * NUM_OF_ROWS;
            int desiredWidth = SQUARE_SIZE * NUM_OF_COLUMNS;
            int increaseInHeight = desiredHeight - currentHeight;
            int increaseInWidth = desiredWidth - currentWidth;
            this.Size += new Size(increaseInWidth, increaseInHeight);
            tableLayoutPanel.Size = new Size(desiredWidth, desiredHeight);

        }// ResizeGUIGameBoard


        /// <summary>
        /// Creates a SquareControl for each square and adds it to the appropriate square of the tableLayoutPanel.
        /// Pre:  none.
        /// Post: the tableLayoutPanel contains all the SquareControl objects for displaying the board.
        /// </summary>
        private void SetUpGUIGameBoard()
        {
            for (int squareNum = Board.START_SQUARE_NUMBER; squareNum <= Board.FINISH_SQUARE_NUMBER; squareNum++)
            {
                Square square = Board.Squares[squareNum];
                SquareControl squareControl = new SquareControl(square, SpaceRaceGame.Players);
                AddControlToTableLayoutPanel(squareControl, squareNum);
            }//endfor

        }// end SetupGameBoard
        
        private void AddControlToTableLayoutPanel(Control control, int squareNum)
        {
            MapSquareNumToScreenRowAndColumn(squareNum, out int screenRow, out int screenCol);
            tableLayoutPanel.Controls.Add(control, screenCol, screenRow);
        }// end Add Control


        /// <summary>
        /// For a given square number, tells you the corresponding row and column number
        /// on the TableLayoutPanel.
        /// Pre:  none.
        /// Post: returns the row and column numbers, via "out" parameters.
        /// </summary>
        /// <param name="squareNumber">The input square number.</param>
        /// <param name="rowNumber">The output row number.</param>
        /// <param name="columnNumber">The output column number.</param>
        private static void MapSquareNumToScreenRowAndColumn(int squareNum, out int screenRow, out int screenCol)
        {
            int remainder;
            screenRow = 6 - Convert.ToInt32(Math.Truncate(squareNum / 8.0));

            remainder = squareNum % 8; // position from where it starts

            if (screenRow % 2 == 0) screenCol = remainder;

            else screenCol = 7 - remainder;

        }//end MapSquareNumToScreenRowAndColumn


        private void SetupPlayersDataGridView()
        {
            // Stop the playersDataGridView from using all Player columns.
            playersDataGridView.AutoGenerateColumns = false;
            // Tell the playersDataGridView what its real source of data is.
            playersDataGridView.DataSource = SpaceRaceGame.Players;

        }// end SetUpPlayersDataGridView



        /// <summary>
        /// Obtains the current "selected item" from the ComboBox
        ///  and
        ///  sets the NumberOfPlayers in the SpaceRaceGame class.
        ///  Pre: none
        ///  Post: NumberOfPlayers in SpaceRaceGame class has been updated
        /// </summary>
        private void DetermineNumberOfPlayers()
        {
            // Store the SelectedItem property of the ComboBox in a string
            string userInput = numPlayersinput.SelectedItem.ToString();
            // Parse string to a number
            int.TryParse(userInput, out int userInt);
            // Set the NumberOfPlayers in the SpaceRaceGame class to that number
            SpaceRaceGame.NumberOfPlayers = userInt;
            resetButton.Enabled = true;
        }//end DetermineNumberOfPlayers

        /// <summary>
        /// The players' tokens are placed on the Start square
        /// </summary>
        private void PrepareToPlay()
        {
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
            if (yesRadiobutton.Checked == true)
            {
                for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
                {
                    SquareControlAt(prevSquare[i]).ContainsPlayers[i] = false;
                }
            }
            // Store the SelectedItem property of the ComboBox in a string
            string userInput = numPlayersinput.SelectedItem.ToString();
            // Parse string to a number
            int.TryParse(userInput, out int userInt);
            // Set the NumberOfPlayers in the SpaceRaceGame class to that number
            SpaceRaceGame.NumberOfPlayers = userInt;
            SpaceRaceGame.Players.Clear();
            prevSquare = new int[userInt];
            SpaceRaceGame.SetUpPlayers();
            
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
            
            
        }//end PrepareToPlay()


        /// <summary>
        /// Tells you which SquareControl object is associated with a given square number.
        /// Pre:  a valid squareNumber is specified; and
        ///       the tableLayoutPanel is properly constructed.
        /// Post: the SquareControl object associated with the square number is returned.
        /// </summary>
        /// <param name="squareNumber">The square number.</param>
        /// <returns>Returns the SquareControl object associated with the square number.</returns>
        private SquareControl SquareControlAt(int squareNum)
        {
            // Uncomment the following lines once you've added the tableLayoutPanel to your form. 
            //     and delete the "return null;" 
            //
            MapSquareNumToScreenRowAndColumn(squareNum, out int screenRow, out int screenCol);
            return (SquareControl)tableLayoutPanel.GetControlFromPosition(screenCol, screenRow);

        }


        /// <summary>
        /// Tells you the current square number of a given player.
        /// Pre:  a valid playerNumber is specified.
        /// Post: the square number of the player is returned.
        /// </summary>
        /// <param name="playerNumber">The player number.</param>
        /// <returns>Returns the square number of the player.</returns>
        private int GetSquareNumberOfPlayer(int playerNumber)
        {
            // Code needs to be added here.
            return SpaceRaceGame.Players[playerNumber].Position;
            //     delete the "return -1;" once body of method has been written 
        }//end GetSquareNumberOfPlayer


        /// <summary>
        /// When the SquareControl objects are updated (when players move to a new square),
        /// the board's TableLayoutPanel is not updated immediately.  
        /// Each time that players move, this method must be called so that the board's TableLayoutPanel 
        /// is told to refresh what it is displaying.
        /// Pre:  none.
        /// Post: the board's TableLayoutPanel shows the latest information 
        ///       from the collection of SquareControl objects in the TableLayoutPanel.
        /// </summary>
        private void RefreshBoardTablePanelLayout()
        {
            //Uncomment the following line once you've added the tableLayoutPanel to your form.
            tableLayoutPanel.Invalidate(true);
        }

        /// <summary>
        /// When the Player objects are updated (location, etc),
        /// the players DataGridView is not updated immediately.  
        /// Each time that those player objects are updated, this method must be called 
        /// so that the players DataGridView is told to refresh what it is displaying.
        /// Pre:  none.
        /// Post: the players DataGridView shows the latest information 
        ///       from the collection of Player objects in the SpaceRaceGame.
        /// </summary>
        private void UpdatesPlayersDataGridView()
        {
            SpaceRaceGame.Players.ResetBindings();
        }

        /// <summary>
        /// At several places in the program's code, it is necessary to update the GUI board,
        /// so that player's tokens are removed from their old squares
        /// or added to their new squares. E.g. at the end of a round of play or 
        /// when the Reset button has been clicked.
        /// 
        /// Moving all players from their old to their new squares requires this method to be called twice: 
        /// once with the parameter typeOfGuiUpdate set to RemovePlayer, and once with it set to AddPlayer.
        /// In between those two calls, the players locations must be changed. 
        /// Otherwise, you won't see any change on the screen.
        /// 
        /// Pre:  the Players objects in the SpaceRaceGame have each players' current locations
        /// Post: the GUI board is updated to match 
        /// </summary>
        private void UpdatePlayersGuiLocations(TypeOfGuiUpdate typeOfGuiUpdate)
        {
            // Code needs to be added here which does the following:
            //
            //   for each player
            //       determine the square number of the player
            //       retrieve the SquareControl object with that square number
            //       using the typeOfGuiUpdate, update the appropriate element of 
            //          the ContainsPlayers array of the SquareControl object.
            //          
            for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
            {
                int onSquare = SpaceRaceGame.Players[i].Position;
                if (typeOfGuiUpdate == TypeOfGuiUpdate.AddPlayer) SquareControlAt(onSquare).ContainsPlayers[i] = true; // SquareControl object with that square number   

                else if (typeOfGuiUpdate == TypeOfGuiUpdate.RemovePlayer) SquareControlAt(onSquare).ContainsPlayers[i] = false;
            }

            RefreshBoardTablePanelLayout();//must be the last line in this method. Do not put inside above loop.
        } //end UpdatePlayersGuiLocations

        private void ToggleAll(bool enable)
        {
            exitButton.Enabled = enable; // enabled at the start of a game, disabled during any round and enabled at the start of any round. NOT COMPLETE
            playersDataGridView.Enabled = enable;
            numPlayersinput.Enabled = enable;
            singleStepgroupbox.Enabled = enable;
        }

        
        private void DiceButton_Click(object sender, EventArgs e)
        {
            if (yesRadiobutton.Checked == true) // allow single step
            {
                SingleStep(playerStep);
                playerStep++;

                if (playerStep == SpaceRaceGame.NumberOfPlayers)
                {
                    eachStep = true;
                    resetButton.Enabled = true;
                    exitButton.Enabled = true;
                    playerStep = 0; // reset to first player's turn
                }

                else
                {
                    for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
                    {
                        if (SpaceRaceGame.Players[i].Position == Board.FINISH_SQUARE_NUMBER)
                        {
                            resetButton.Enabled = true;
                            break;
                        }

                        else resetButton.Enabled = false;
                    } // enable after game ends;

                }

            }

            if (noRadiobutton.Checked == true)
            {
                AllStep(); // all move at once
            }

            if (SpaceRaceGame.AllPlayerFuel() == true)
            {
                MessageBox.Show("All players has 0 fuel."); // if all players run out of fuel 
                exitButton.Enabled = true;
                diceButton.Enabled = false;
            }
        }

        private void SingleStep(int playerNum)
        {
            if (this.eachStep == true)
            {
                for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
                {
                    prevSquare[i] = SpaceRaceGame.Players[i].Position;

                }
                eachStep = false;
            }// save previous position

            SquareControlAt(prevSquare[playerNum]).ContainsPlayers[playerNum] = false; // remove token
            SpaceRaceGame.PlayOneTurn(playerNum);

            if (SpaceRaceGame.Players[playerNum].RocketFuel == 0) MessageBox.Show(string.Format("{0} has 0 fuel.", SpaceRaceGame.Players[playerNum].Name)); // check for 0 fuel
            int onSquare = SpaceRaceGame.Players[playerNum].Position;
            SquareControlAt(onSquare).ContainsPlayers[playerNum] = true; // add token
            UpdatesPlayersDataGridView(); // update all
            RefreshBoardTablePanelLayout();
   
            ToggleAll(false);

            EndGame();

            WinnerMessage(EndGame());

        } // end SingleStep() method

        private void AllStep()
        {
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.RemovePlayer);
            SpaceRaceGame.PlayOneRound();
            UpdatePlayersGuiLocations(TypeOfGuiUpdate.AddPlayer);
            UpdatesPlayersDataGridView();
            resetButton.Enabled = true;
            ToggleAll(false);
            EndGame();
            WinnerMessage(EndGame());
        } // no single step

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PrepareToPlay();
            ToggleAll(true);

            diceButton.Enabled = false;
            yesRadiobutton.Checked = false;
            noRadiobutton.Checked = false;
            eachStep = true;
            playerStep = 0;
        } // end Reset Button.

        private string[] EndGame()
        {
            string[] winners = new string[6];
           
            for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
            {
                if (SquareControlAt(Board.FINISH_SQUARE_NUMBER).ContainsPlayers[i] == true) // check if players finished
                {
                    winners[i] = SpaceRaceGame.Players[i].Name; // store winners' names
                    diceButton.Enabled = false;
                    exitButton.Enabled = true;
                    
                }
            }

            return winners;            
        }// end EndGame


        private void WinnerMessage(string[] winners)
        {
            
            if (noRadiobutton.Checked == true) // for all steps
            {
                
                for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
                {
                    if (SquareControlAt(Board.FINISH_SQUARE_NUMBER).ContainsPlayers[i] == true)
                    {
                        exitButton.Enabled = true;
                        MessageBox.Show(string.Format("The following player(s) finished the game\n\t{0}", string.Join(Environment.NewLine, winners)));
                        noRadiobutton.Checked = false;
                        break; // prevent multiple messageboxes for multiple winners
                    }
                }
            }

            else // for single step
            {
                for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
                {
                    if (SquareControlAt(Board.FINISH_SQUARE_NUMBER).ContainsPlayers[i] == true)
                    {
                        MessageBox.Show(string.Format("The following player(s) finished the game\n\t{0}", string.Join(Environment.NewLine, winners)));
                        exitButton.Enabled = true;
                        resetButton.Enabled = true;
                        yesRadiobutton.Checked = false;
                    }
                }
                
            }

        } // end WinnerMessage to show winners

        private void SingleStepToggle()
        {
            diceButton.Enabled = true;
            singleStepgroupbox.Enabled = false;
        }

        private void YesRadiobutton_Click(object sender, EventArgs e)
        {
            SingleStepToggle();
        } 

        private void NoRadiobutton_Click(object sender, EventArgs e)
        {
            SingleStepToggle();
        }

        private void NumPlayersinput_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrepareToPlay();
            numPlayersinput.Enabled = false;
        }

    }
}
