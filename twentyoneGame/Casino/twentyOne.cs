using Casino.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Casino.twentyoneGame
{
    public class twentyOne : game, IWalkAway
    {
        public _21dealer Dealer { get; set; }

        public override void play()
        {
            //starting dealer and players off with new hand, fresh deck
            Dealer = new _21dealer();
            Dealer.Hand = new List<card>();
            Dealer.Deck = new deck();
            Dealer.Stay = false;
            foreach (player player in Players)
            {
                player.Hand = new List<card>();
                player.Stay = false;
            }
            foreach (player player in Players)
            {
                bool validAnswer = false; //variable to check upcoming user input
                int bet = 0; //variable that will eventually store betting amount
                while (!validAnswer) //this loop will run until valid answer is true
                {
                    Console.WriteLine("Place your bet!"); //asking for user input
                    //tryparse will attempt to convert string input to int, if it succeeds then bool will be true, loop will end, bet will be stored
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter numeric digits only and no decimals.");
                }
                if (bet < 0)
                {
                    throw new fraudException();
                }
                bool successfulBet = player.Bet(bet);
                if (!successfulBet) //if player places bet that is too high, they will be asked to place another bet
                {
                    return; 
                }
                Bets[player] = bet; //adding players bet to dictionary
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing cards...");
                foreach (player player in Players)
                {
                    Console.Write("{0}: ", player.Name); 
                    Dealer.deal(player.Hand);
                    if (i == 1) //when players have their 2 cards, check for blackjack
                    {
                        bool blackjack = _21rules.blackjack(player.Hand);
                        if (blackjack)
                        {
                            Console.WriteLine("Blackjack! {0} wins ${1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            Bets.Remove(player);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackjack = _21rules.blackjack(Dealer.Hand);
                    if (blackjack)
                    {
                        Console.WriteLine("Blackjack! Dealer wins. Everyone loses.");
                        foreach (KeyValuePair<player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are:");
                    foreach(card card in player.Hand)
                    {
                        Console.Write("{0}\n", card.ToString());
                    }
                    Console.WriteLine("\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.deal(player.Hand);
                    }
                    bool busted = _21rules.isBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Would you like to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya")
                        {
                            player.isActivelyPlaying = true;
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                        }
                        return;
                    }
                }
            }
            Dealer.isBusted = _21rules.isBusted(Dealer.Hand);
            Dealer.Stay = _21rules.shouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.deal(Dealer.Hand);
                Dealer.isBusted = _21rules.isBusted(Dealer.Hand);
                Dealer.Stay = _21rules.shouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach(KeyValuePair<player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won ${1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            foreach (player player in Players)
            {
                bool? playerWon = _21rules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player];
                }
                if (playerWon == true)
                {
                    Console.WriteLine("{0} won ${1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2);
                    Dealer.Balance -= Bets[player];
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y" || answer == "yeah" || answer == "ya")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        
        //overriding this function from inherited abstract class
        public override void listPlayers()
        {
            Console.WriteLine("21 players: ");
            base.listPlayers();
        }

        public void WalkAway(player player)
        {
            throw new NotImplementedException();
        }
    }
}
