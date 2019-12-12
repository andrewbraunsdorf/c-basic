using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Besthand
{
    public class Card
    {
        
        public int Suit { get; set; }
        public int Face { get; set; }
        public int Value { get; set; }

        //public Card(int suit, int value)
        //{
        //    this.suit = suit;
        //    this.value = value;
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
                for (var valueNumber = 1; valueNumber < 14; valueNumber++)
                {
                    DeckList.Add(new Card() {Suit = suitNumber, Face = valueNumber });
                    if (valueNumber <= 9)
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
                    continue;
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

            Console.WriteLine();
            foreach (var item in player2Hand)
            {
                Console.WriteLine(item.Suit + "\t" + item.Face + "\t" + item.Value);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();
            //Deck deck = new Deck(rand);

            Console.ReadLine();
        }
    }
}
