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
            Deck deck = new Deck();
            deck = Shuffle(deck);
            deck.Cards.ForEach(card => WriteLine($"{card.Face} \t| {card.Suit}"));
            

            ReadKey();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> tCards = new List<Card>();
            Random rnd = new Random();

            while (deck.Cards.Count > 0)
            {
                int rndInx = rnd.Next(0, deck.Cards.Count);
                tCards.Add(deck.Cards[rndInx]);
                deck.Cards.RemoveAt(rndInx);
            }
            deck.Cards = tCards;

            return deck;
        }
    }
}
