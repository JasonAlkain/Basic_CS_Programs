using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Deck
    {
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

        public List<Card> Cards { get; set; }
    }
}
