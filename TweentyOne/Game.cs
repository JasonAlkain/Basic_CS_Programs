﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        public void ListPlayers() => Players.ForEach(player => Console.WriteLine($"Player #{Players.IndexOf(player)}: {player}"));

    }
}
