using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _CardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 2,
            [Face.Five] = 2,
            [Face.Six] = 2,
            [Face.Seven] = 2,
            [Face.Eight] = 2,
            [Face.Nine] = 2,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 11,
            [Face.King] = 12,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(c => c.Face == Face.Ace);
            int[] result = new int[aceCount+1];
            int value = Hand.Sum(c => _CardValues[c.Face]);

            result[0] = value;

            if (result.Length == 1)
                return result;

            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }

            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] phv = GetAllPossibleHandValues(Hand);
            int value = phv.Max();
            bool isBlackJack = (value == 21) ? true : false;
            return isBlackJack;
        }

        public static bool CheckForBust(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            bool isBusted = (value > 21) ? true : false;
            return isBusted;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            bool result = false;

            int[] phv = GetAllPossibleHandValues(Hand);
            foreach (int val in phv)
            {
                if(val > 16 && val < 22)
                    result = true;
            }

            return result;
        }


        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            bool? result = false;

            int[] phv_player = GetAllPossibleHandValues(PlayerHand);
            int[] phv_dealer = GetAllPossibleHandValues(DealerHand);

            int playerScore = phv_player.Where(val => val < 22).Max();
            int dealerScore = phv_dealer.Where(val => val < 22).Max();

            if (playerScore > dealerScore) result = false;
            else if (playerScore < dealerScore) result = true;
            else result = null;

            return result;
        }
    }
}
