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
            deck.Shuffle(rndNum, out int t_shfld);

            deck.Cards.ForEach(card => WriteLine($"{card.Face} \t| {card.Suit}"));

            WriteLine($"\n\t Times I shuffled: {t_shfld}");

            ReadKey();
        }

    }
}
