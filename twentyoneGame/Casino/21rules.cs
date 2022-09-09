using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Casino.twentyoneGame
{
    public class _21rules
    {
        //private dictionary because it will only be used in this class
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] getAllPossibleHandValues (List<card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            //one possibility is when ace = 1, another is when ace = 10
            //if there's no ace, there will only be one possible value for that hand
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
                //adding ten to "base" value, adding to next spot in array
            }
            return result;
        }

        public static bool blackjack (List<card> Hand)
        {
            int[] possibleValues = getAllPossibleHandValues(Hand);
            int value = possibleValues.Max(); //get highest value in array
            if (value == 21) return true;
            else return false;
        }

        public static bool isBusted(List<card> Hand)
        {
            int value = getAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool shouldDealerStay(List<card> Hand)
        {
            int[] possibleHandValues = getAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<card> playerHand, List<card> dealerHand)
        {
            int[] playerResults = getAllPossibleHandValues(playerHand);
            int[] dealerResults = getAllPossibleHandValues(dealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); //checking for highest score that is less than 22
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
