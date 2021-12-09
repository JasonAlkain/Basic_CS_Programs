using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Deck
    {
        private List<Card> _cards = new List<Card>();

        public List<Card> Cards { get { return _cards; } set { _cards = value; } }


        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)j;
                    card.Suit = (Suit)i;
                    Cards.Add(card);
                }
            }
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
