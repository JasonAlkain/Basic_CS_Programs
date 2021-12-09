using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TweentyOne
{
    public class TwentyOneDealer : Dealer
    {
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        private List<Card> _hand = new List<Card>();
        public bool IsStay { get; set; }
        public bool IsBusted { get; set; }
    }
}
