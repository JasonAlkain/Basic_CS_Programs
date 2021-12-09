using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public abstract class Game
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Variables
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public string Title { get; set; }

        public List<Player> Players { get { return _players; } set { _players = value; } }
        private List<Player> _players = new List<Player>();

        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public abstract void Play();
        public virtual void ListPlayers() =>
            Players.ForEach(player =>
                Console.WriteLine($"Player #{Players.IndexOf(player)+1}: {player.Name}")
            );

    }
}
