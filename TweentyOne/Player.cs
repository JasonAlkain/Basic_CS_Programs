using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Player
    {
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        private List<Card> _hand = new List<Card>();
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivePlayer { get; set; }
        public bool IsStay { get; set; }

        public Player(string name, int initialBalance)
        {
            Hand = new List<Card>();
            Name = name;
            Balance = initialBalance;
        }

        public bool Bet(int amount)
        {
            bool _ = false;

            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place that bet.");
                _ = false;
            }
            else
            {
                Balance -= amount;
                _ = true;
            }

            return _;
        }


        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
