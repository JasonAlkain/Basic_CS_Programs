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

            Deck deck = new Deck();
            Player player = new Player() { Name = "Jason" };
            Game game = new TwentyOneGame
            {
                Title = "Twenty One",
                Players = new List<Player>() {
                    new Player() { Name = "Zach" },
                    new Player() { Name = "Paul" },
                    new Player() { Name = "Jude" },
                    new Player() { Name = "Dillan" }
                }
            };

            game += player;
            game.ListPlayers();

            WriteLine("");

            deck.Cards.ForEach(card => WriteLine($" {card.Face}\t| {card.Suit}"));

            ReadKey();
        }

    }
}
