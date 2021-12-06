using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class TwentyOneGame : Game
    {
        public override void Play()
        {
            
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Welcome Twenty One Players!\n");
            base.ListPlayers();
        }
    }
}
