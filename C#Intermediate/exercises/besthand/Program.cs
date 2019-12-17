using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Besthand
{
    class BestHandGame
    {
        Random rand;
        Player player1;
        Player player2;
        Deck firstDeck;

        public BestHandGame()
        {
            rand = new Random();
            player1 = new Player();
            player2 = new Player();
            firstDeck = new Deck(rand);
        }

        public void PlayBestHand()
        {
            List<Card> player1Hand = firstDeck.DrawHand(8);
            List<Card> player2Hand = firstDeck.DrawHand(8);

            Console.WriteLine("Suit\t" + "Card\t" + "Value");
            foreach (var item in player1Hand)
            {
                Console.WriteLine(item.Suit + "\t" + item.Face + "\t" + item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Player 1 Score: {0}", player1.Score);

            Console.WriteLine();
            foreach (var item in player2Hand)
            {
                Console.WriteLine(item.Suit + "\t" + item.Face + "\t" + item.Value);
            }
            Console.WriteLine();
            Console.WriteLine("Player 2 Score: {0}", player2.Score);

            // Remove Facecards if in both hands
            for (var counterPlayer1Hand = 0; counterPlayer1Hand < player1Hand.Count; counterPlayer1Hand++)
            {
                for (var counterPlayer2Hand = 0; counterPlayer2Hand < player2Hand.Count; counterPlayer2Hand++)
                {
                    if (counterPlayer2Hand < player1Hand.Count && player1Hand[counterPlayer1Hand].Value == 10 && player2Hand[counterPlayer2Hand].Value == 10 && player1Hand[counterPlayer1Hand].Face ==
                        player2Hand[counterPlayer2Hand].Face)
                    {
                        player1Hand.RemoveAt(counterPlayer1Hand);
                        player2Hand.RemoveAt(counterPlayer2Hand);
                        

                    }
                }
            }

            //Calculate Scores
            // Royal cards
            Console.WriteLine();
            int player1RoyalCards = 0;
            foreach (var item in player1Hand)
            {

                if (item.Face >= 10)
                    player1RoyalCards++;
            }
            if (player1RoyalCards >= 2)
            {
                player1.Score += (player1RoyalCards - 1) * 5;
            }
            int player2RoyalCards = 0;
            foreach (var item2 in player2Hand)
            {
                if (item2.Face >= 10)
                    player2RoyalCards++;
            }
            if (player2RoyalCards >= 2)
            {
                player2.Score += (player2RoyalCards - 1) * 5;
            }
            // Matches
            int player1Matches = 0;
            for (int i = 0; i < player1Hand.Count; i++)
            {
                for (int j = i + 1; j < player1Hand.Count; j++)
                {
                    if (j < player1Hand.Count && player1Hand[i].Face == player1Hand[j].Face)
                    {
                        player1Matches += 1;
                        player1Hand.RemoveAt(j);
                        continue;
                    }
                    else if (j < player2Hand.Count && player2Hand[i].Face == player2Hand[j].Face)
                    {
                        player2.Score += 2;

                        player2Hand.RemoveAt(j);
                        continue;
                    }
                    else
                        continue;
                }
            }

            player1.Score += (player1Matches *2);

            //// Straights
            // Ordered cards by Face Value
            List<Card> player1Straights = player1Hand.OrderBy(n => n.Face).ToList();

            int straightScorePlayer1 = 0;
            int counterForStraights = 0;
            for (int i = 1; i < player1Straights.Count; i++)
            {
                for (int j = i + 1; j < 14; j++)
                {
                    if (player1Straights[i].Face != 0)
                    {
                        counterForStraights++;

                    }
                    else
                    {
                        if (counterForStraights > 2)
                        {
                            while (counterForStraights > 3)
                            {
                                straightScorePlayer1 += 3;
                                counterForStraights--;
                            }
                        }

                        counterForStraights = 0;
                    }
                }
            }

            Console.WriteLine("Player 1 Cards in order");
            foreach (var item in player1Straights)
            {
                Console.WriteLine(item.Face);
            }
            Console.WriteLine();

            List<Card> player2Straights = player2Hand.OrderBy(n => n.Face).ToList();
            Console.WriteLine("Player 2 Cards in order");
            foreach (var item in player2Straights)
            {
                Console.WriteLine(item.Face);
            }
            Console.WriteLine();

            // reprinting values to see post removal
            Console.WriteLine("Suit\t" + "Card\t" + "Value");
            foreach (var item in player1Hand)
            {
                Console.WriteLine(item.Suit + "\t" + item.Face + "\t" + item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Player 1 Score: {0}", player1.Score);
            //Console.WriteLine("Player 1 Matches: {0}", player1Matches);

            Console.WriteLine();
            foreach (var item in player2Hand)
            {
                Console.WriteLine(item.Suit + "\t" + item.Face + "\t" + item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Player 2 Score: {0}", player2.Score);

        }

        
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            BestHandGame game = new BestHandGame();
            game.PlayBestHand();
            //int i = 1;
            //foreach (Card card in deck)
            //{
            //    Console.WriteLine("Card {0}: {1} of {2}. Value: {3}", i, card.Face, card.Suit, card.Value);
            //    i++;
            //}
            Console.ReadLine();
        }
    }
}
