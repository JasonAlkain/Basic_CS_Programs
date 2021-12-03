using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Deck
    {

        public List<Card> Cards { get; set; }


        public Deck()
        {
            List<string> Suits = new List<string>()
            {
                "Clubs",
                "Hearts",
                "Diamonds",
                "Spades"
            };

            List<string> Faces = new List<string>() 
            {
                "Two", "Three", "Four", "Five",
                "Six","Seven","Eight","Nine","Ten",
                "Jack","King","Queen", "Ace"
            };

            Cards = new List<Card>();

            foreach (string face in Faces)
                foreach (string suit in Suits)
                    Cards.Add(new Card(suit, face));
        }


        public void Shuffle(int times, out int timesShuffled)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                Shuffle();
                timesShuffled++;
            }
        }


        public void Shuffle(int times)
        {
            for (int i = 0; i < times; i++)
                Shuffle();
        }

        public void Shuffle()
        {
            List<Card> tCards = new List<Card>();
            Random rnd = new Random();

            while (this.Cards.Count > 0)
            {
                int rndInx = rnd.Next(0, this.Cards.Count);
                tCards.Add(this.Cards[rndInx]);
                this.Cards.RemoveAt(rndInx);
            }
            this.Cards = tCards;
        }
    }
}
