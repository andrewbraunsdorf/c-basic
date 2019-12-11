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
