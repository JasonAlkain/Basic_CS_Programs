using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Simplifiers for Console 'I/O'
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        static string ReadLine() => Console.ReadLine();
        static ConsoleKeyInfo ReadKey() => Console.ReadKey();
        static void WriteLine(String s) => Console.WriteLine(s);
        static void Write(string s) => Console.Write(s);
        static void Clear() => Console.Clear();


        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Properties
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public TwentyOneDealer Dealer { get; set; }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Constuctor
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public override void Play()
        {
            string userIn = string.Empty;
            Dealer = new TwentyOneDealer();
            Bets = new Dictionary<Player, int>();

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Set up player hands and stay
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.IsStay = false;
            }
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [ end foreach ]
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            Dealer.Hand = new List<Card>();
            Dealer.IsStay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            int playerBet = 0;
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Get player bets
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            foreach (Player player in Players)
            {
                bool isValid = false;
                while (!isValid)
                {
                    WriteLine("Place your bets!");
                    Write(">>: ");
                    isValid = int.TryParse(ReadLine(), out playerBet);
                    if (!isValid)
                    {
                        WriteLine("Please enter digits and no decimals.");
                        ReadKey();
                    }
                    Clear();
                }

                bool CanBet = player.Bet(playerBet);
                if (!CanBet)
                    return;

                Bets.Add(player, playerBet);
            }
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [ end foreach ]
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Clear();


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Deal cards
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            WriteLine("Dealing...");
            for (int i = 0; i < 2; i++)
            {
                WriteLine($"Card deal # {i+1}");
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Deal cards to player
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                foreach (Player player in Players)
                {
                    WriteLine($"{player.Name}:");
                    Dealer.Deal(player.Hand);
                    if(i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            WriteLine($"Blackjack!! {player.Name} wins {Bets[player]}");
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5));
                            return;
                        }
                    }
                }
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // [ end foreach ]
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Deal cards to Dealer
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                WriteLine($"Dealer:");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        WriteLine($"Dealer has Blackjack!!");
                        Bets.Sum(entry => Dealer.Balance += entry.Value);
                        return;
                    }
                }
            }
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Finished dealing cards
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // After getting delt cards
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            foreach (Player player in Players)
            {
                while (!player.IsStay)
                {
                    WriteLine("Your cards are");
                    foreach (Card card in player.Hand)
                    {
                        WriteLine($"{card.ToString()}");
                    }
                    
                    WriteLine("\n");
                    WriteLine("Hit or Stay?");
                    Write(">>:");
                    userIn = ReadLine().ToLower();

                    if (userIn == "stay")
                    {
                        player.IsStay = true;
                        break;
                    }
                    else if (userIn == "hit")
                    {
                        Dealer.Deal(player.Hand);
                    }
                    Clear();

                    // Check if player is busted
                    bool isBusted = TwentyOneRules.CheckForBust(player.Hand);
                    if (isBusted)
                    {
                        Dealer.Balance += Bets[player];
                        WriteLine($"Oh no! It seems {player.Name} busted...");
                        WriteLine($"{player.Name} lost {Bets[player]}.");
                        WriteLine($"{player.Name} now has {player.Balance} left.");
                        WriteLine($"{player.Name} would you like to play again?");
                        Write(">>: ");
                        userIn = ReadLine().ToLower();

                        player.IsActivePlayer = userIn == "yes" || userIn == "yeah";

                    }
                }
            }
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [ end foreach ]
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Dealer things happen...
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Dealer.IsBusted = TwentyOneRules.CheckForBust(Dealer.Hand);
            Dealer.IsStay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.IsStay && !Dealer.IsBusted)
            {
                WriteLine($"Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.CheckForBust(Dealer.Hand);
                Dealer.IsStay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.IsStay)
            {
                WriteLine($"Dealer is staying.");

            }
            if (Dealer.IsBusted)
            {
                WriteLine($"Dealer has busted!!");
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // Dealer things happen...
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                foreach (KeyValuePair<Player, int> bet in Bets)
                {
                    WriteLine($"{bet.Key.Name} won {bet.Value}!");
                    Players.Where(p => p.Name == bet.Key.Name).First().Balance += (bet.Value * 2);
                    Dealer.Balance -= bet.Value;
                }
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
                // [ end foreach ]
                // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            }
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [ end ]
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // Counting the cards
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                switch (playerWon)
                {
                    case true:
                        WriteLine($"{player.Name} has won {Bets[player]}!!");
                        WriteLine($"Your new balance is: {player.Balance.ToString("C")}!!");
                        player.Balance += (Bets[player] * 2);
                        break;
                    case false:
                        WriteLine($"Dealer has wins {Bets[player]}!!");
                        Dealer.Balance += Bets[player];
                        break;
                    case null:
                        WriteLine("Push!! There are no winners.");
                        break;
                }

                WriteLine($"{player.Name} would you like to play again?");
                Write(">>: ");
                userIn = ReadLine().ToLower();

                player.IsActivePlayer = userIn == "yes" || userIn == "yeah";
                return;
            }

            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            // [ end ]
            // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

        }

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Methods
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        public override void ListPlayers()
        {
            Console.WriteLine("Welcome Twenty One Players!\n");
            base.ListPlayers();
        }

        public void WalkAway(Player player) => Players.Remove(player);
    }
}
