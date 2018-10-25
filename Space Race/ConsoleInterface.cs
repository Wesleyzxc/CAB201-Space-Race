using System;
//DO NOT DELETE the two following using statements *********************************
using Game_Logic_Class;
using Object_Classes;


namespace Space_Race
{
    class Console_Class
    {
        /// <summary>
        /// Algorithm below currently plays only one game
        /// 
        /// when have this working correctly, add the abilty for the user to 
        /// play more than 1 game if they choose to do so.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DisplayIntroductionMessage();
            Board.SetUpBoard();

            SpaceRaceGame.NumberOfPlayers = NumberOfPlayersInput();
            SpaceRaceGame.SetUpPlayers();

            StartRound();
            string nextRound = YesNoInput(); // store user's input
            while (nextRound == "Y" || nextRound == "y") // Loop to check for next game
            {
                NextGame();
                nextRound = YesNoInput();
            }

            /*                    
             Set up the board in Board class (Board.SetUpBoard)
             Determine number of players - initally play with 2 for testing purposes 
             Create the required players in Game Logic class
              and initialize players for start of a game             
             loop  until game is finished           
                call PlayGame in Game Logic class to play one round
                Output each player's details at end of round
             end loop
             Determine if anyone has won
             Output each player's details at end of the game
           */

            PressEnter(); // Enter to terminate
            Console.Read();

        }//end Main


        /// <summary>
        /// Display a welcome message to the console
        /// Pre:    none.
        /// Post:   A welcome message is displayed to the console.
        /// </summary>
        static void DisplayIntroductionMessage()
        {
            Console.WriteLine("\n\tWelcome to Space Race.\n");
        } //end DisplayIntroductionMessage

        /// <summary>
        /// Displays a prompt and waits for a keypress.
        /// Pre:  none
        /// Post: a key has been pressed.
        /// </summary>
        static void PressEnter()
        {
            Console.Write("\nPress Enter to terminate program ...");
            Console.Read();
        } // end PressAny

        static void StartRound()
        {
            bool playerState = false;

            while (playerState == false) // while no one player has won yet
            {
                Console.WriteLine("\n\nPress Enter to play a round ...");
                Console.Read();
                SpaceRaceGame.PlayOneRound();
                for (int i = 0; i < SpaceRaceGame.Players.Count; i++)
                {
                    if (SpaceRaceGame.Players[i].AtFinish == true)
                    {
                        DisplayWinMessage(SpaceRaceGame.Players[i]);
                        playerState = true;
                        break; // end if any player wins
                    }

                    else if (SpaceRaceGame.AllPlayerFuel() == true)
                    {
                        playerState = true;
                        break; // end if all player has 0 fuel
                    }

                }

                if (playerState == false) DisplayCurrentPosition(); // to prevent repeated displays
                
                Console.Read();

            }
        } // End StartRound() 

        static string YesNoInput()
        {
            Console.Write("\n\n\n\n\tPlay again? (Y or N): ");
            string nextRound = Console.ReadLine();
            return nextRound;
        } // end YesNoInput() returns user's input


        static void NextGame()
        {
            SpaceRaceGame.NumberOfPlayers = NumberOfPlayersInput();
            for (int i = 0; i < SpaceRaceGame.NumberOfPlayers; i++)
            {
                SpaceRaceGame.Players.Clear(); // remove player for a new set
            }
            SpaceRaceGame.SetUpPlayers(); // sets up accordingly once cleared
            StartRound();

        } // End NextGame() 

        static void DisplayCurrentPosition()
        {
            for (int i = 0; i < SpaceRaceGame.Players.Count; i++)
            {
                if (SpaceRaceGame.Players[i].AtFinish == false)
                {
                    Console.WriteLine("\t{0} on square {1} with {2} unobtainium of power remaining", SpaceRaceGame.Players[i].Name, SpaceRaceGame.Players[i].Position, SpaceRaceGame.Players[i].RocketFuel);
                } // print information if not won yet
            }
        } // End DisplayCurrentPosition

        static int NumberOfPlayersInput()
        {
            Console.WriteLine("\n\tThis game is for 2 to 6 players.");
            Console.Write("\tHow many players? (2-6): ");
            int playerNum;

            while (int.TryParse(Console.ReadLine(), out playerNum) != true || playerNum < 2 || playerNum > 6)
            {
                Console.WriteLine("\n\nError: invalid number of players entered.");
                Console.WriteLine("\n\tThis game is for 2 to 6 players.");
                Console.Write("\tHow many players? (2-6): ");
            }
             
            return playerNum; // gets users' input on number of players
        } // End NumberOfPlayersInput() 

        static void DisplayWinMessage(Player player)
        {
            Console.WriteLine("\tThe following player(s) finished the game");
            Console.WriteLine("\n\t\t{0}\n\t", player.Name);
            Console.WriteLine("\tIndividual players finished at the locations specified\n");
            for (int i = 0; i < SpaceRaceGame.Players.Count; i++)
            {
                if (SpaceRaceGame.Players[i].AtFinish == false)
                {
                    Console.WriteLine("\t\t{0} on square {1} with {2} unobtainium of power remaining", SpaceRaceGame.Players[i].Name, SpaceRaceGame.Players[i].Position, SpaceRaceGame.Players[i].RocketFuel);
                }
            }
        } // End DisplayWinMessage() accepts an instance of Player and will display information of passed Player.
    }//end Console class
}
