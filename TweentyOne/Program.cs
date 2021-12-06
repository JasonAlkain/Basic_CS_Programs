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
        // Fun lambda experiments to reduce some code
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(string s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();


        static void Main(string[] args)
        {
            int rndNum = new Random().Next(5, 10);
            Deck deck = new Deck();

            TwentyOneGame game = new TwentyOneGame
            {
                Title = "Twenty One",
                Players = new List<Player>() {
                    new Player() { Name = "Zach" },
                    new Player() { Name = "Paul" },
                    new Player() { Name = "Dillan" },
                    new Player() { Name = "Jude" }
                }
            };

            
            game.ListPlayers();
            

            ReadKey();
        }

    }
}
