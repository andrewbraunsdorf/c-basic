using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Besthand
{
    public class Card
    {
        
        public int Suit { get; set; }
        public int Face { get; set; }
        public int Value { get; set; }

        //public Card(int suit, int value, int face)
        //{
        //    this.Suit = suit;
        //    this.Value = value;
        //    this.Face = face;
        //}
    }

    class Deck
    {
        public List<Card> DeckList;

        public Deck(Random rand)
        {
            DeckList = new List<Card>();
            CreateDeck();
            ShuffleDeck(rand);
        }

        public void CreateDeck()
        {
            for (var suitNumber = 0; suitNumber < 4; suitNumber++)
            {
                for (var valueNumber = 2; valueNumber < 15; valueNumber++)
                {
                    DeckList.Add(new Card() {Suit = suitNumber, Face = valueNumber });
                    if (valueNumber == 14)
                    {
                        DeckList[DeckList.Count - 1].Value = 11;
                    }
                    else if (valueNumber <= 9)
                    {
                        DeckList[DeckList.Count - 1].Value = valueNumber;
                    }
                    else
                    {
                        DeckList[DeckList.Count - 1].Value = 10;
                    }
                }
            }
        }

        public void ShuffleDeck(Random rand)
        {
            int n = DeckList.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card card = DeckList[k];
                DeckList[k] = DeckList[n];
                DeckList[n] = card;
            }
        }

        //public List<Card> DrawHand(Random rand, int numberOfCards)
        public List<Card> DrawHand(int numberOfCards)
        {
            List<Card> hand = new List<Card>();
            int counter = 0;
            while (counter < numberOfCards)
            {
                //int nextCardValue = DeckList[DeckList.Count - 1].Value;
                //int nextCard = DeckList[DeckList.Count - 1].Value;
                var nextIndex = DeckList[DeckList.Count - 1];
                if (nextIndex.Value != 0)
                {
                    //hand.Add(new Card( DeckList[DeckList.Count - 1].Value, DeckList[DeckList.Count - 1].Suit, DeckList[DeckList.Count - 1].Face));
                    hand.Add(DeckList[DeckList.Count - 1]);
                    DeckList.RemoveAt(DeckList.Count - 1);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Deck is out of cards!");
                }
            }

            return hand;
        }
    }

    class Player
    {
        public int Score { get; set; }

        public Player()
        {
            this.Score = 0;
        }

        public void ScoreCalculator(List<Card> playerHand)
        {
            foreach (var item in playerHand)
            {
                this.Score += item.Value;
            }
        }
    }

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

            //foreach (var item in player1Hand)
            //{
            //    player1.Score += item.Value;
            //}

            Console.WriteLine();
            Console.WriteLine("Player 1 Score: {0}", player1.Score);

            Console.WriteLine();
            foreach (var item in player2Hand)
            {
                Console.WriteLine(item.Suit + "\t" + item.Face + "\t" + item.Value);
            }
            //foreach (var item in player2Hand)
            //{
            //    player2.Score += item.Value;
            //}

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
                //player1.Score += player1RoyalCards - 1;
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
