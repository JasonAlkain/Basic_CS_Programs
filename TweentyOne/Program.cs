using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simplifiers for Console 'I/O'
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(String s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static void Main(string[] args)
        {
            Intro(out string playerName, out int bank, out string userIn);
            MainGameLoop(playerName, bank, userIn);

            // Best to put it here so I know where it is...
            ReadKey();
        }

        public static void Intro(out string playerName, out int bank, out string userIn)
        {

            // entrance point
            // Print a welcome message
            WriteLine("Welcome to the Grand Hotel and Casino of CA.");
            Write("What is your name?\n>>: ");
            playerName = ReadLine();
            Clear();


            Write("And how much money did you bring?\n>>: ");
            int.TryParse(ReadLine(), out bank);
            Clear();


            WriteLine($"Hello, {playerName}.");
            WriteLine("Would you like to join a game of 21 right now?");
            Write("[ Yes | No ]\n>>: ");
            userIn = ReadLine().ToLower();
            Clear();

        }

        private static void MainGameLoop(string playerName, int bank, string userIn)
        {
            if (userIn == "yes" || userIn == "yeah" || userIn == "ya" || userIn == "y")
            {
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                //Initialize player
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Create the new player
                Player player = new Player(playerName, bank);
                // Set player to active player
                player.IsActivePlayer = true;

                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Initialize game
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Create a new game
                Game game = new TwentyOneGame();
                // add player to game.
                game += player;

                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Main loop for the game
                //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                while (player.IsActivePlayer && player.Balance > 0)
                {
                    game.Play();
                    Clear();
                }

                // Remove player from game
                game -= player;

                WriteLine($"Your ending balance was: {player.Balance.ToString("C")}");
                WriteLine("Thank you for playing!");
            }

            WriteLine("Feel free to look around the casino.");
            WriteLine("Until next time.");
        }

    }
}
