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
            Console.WriteLine("\nThis game is for 2 to 6 players.");
            Console.WriteLine("How many players? (2-6): ");
            // enter playerinput logic here

            SpaceRaceGame.SetUpPlayers();
            Console.WriteLine("\n\nPress Enter to play a round ...");
            Console.Read();
            SpaceRaceGame.PlayOneRound(); 
            Console.WriteLine("{0} on square {1} with {2} yottawatt of power remaining", SpaceRaceGame.Players[0].Name, SpaceRaceGame.Players[0].Position, SpaceRaceGame.Players[0].RocketFuel);

            Console.WriteLine("{0}", SpaceRaceGame.Players.Count);
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
           
                
            PressEnter();
            Console.Read();

        }//end Main


        /// <summary>
        /// Display a welcome message to the console
        /// Pre:    none.
        /// Post:   A welcome message is displayed to the console.
        /// </summary>
        static void DisplayIntroductionMessage()
        {
            Console.WriteLine("Welcome to Space Race.\n");
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



    }//end Console class
}
