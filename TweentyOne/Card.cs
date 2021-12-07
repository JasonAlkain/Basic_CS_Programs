using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Card
    {

        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public Card()
        {

        }

        public Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;
        }
    }

    public enum Suit
    {
        Clubs,
        Daimonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        King,
        Queen,
        Ace
    }
}
