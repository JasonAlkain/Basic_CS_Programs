using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play()
        {
            throw new NotImplementedException();
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Welcome Twenty One Players!\n");
            base.ListPlayers();
        }

        public void WalkAway(Player player) => Players.Remove(player);
    }
}
