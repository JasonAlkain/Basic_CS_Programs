﻿using System;
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
            deck = Shuffle(deck, out int shuffledTimes, rndNum);

            deck.Cards.ForEach(card => WriteLine($"{card.Face} \t| {card.Suit}"));

            WriteLine($"\n\t Times I shuffled: {shuffledTimes}");

            ReadKey();
        }


        public static Deck Shuffle(Deck deck, out int timesShuffled, int times)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                deck = Shuffle(deck);
                timesShuffled++;
            }
            return deck;
        }


        public static Deck Shuffle(Deck deck, int times)
        {
            for (int i = 0; i < times; i++)
                deck = Shuffle(deck);

            return deck;
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
