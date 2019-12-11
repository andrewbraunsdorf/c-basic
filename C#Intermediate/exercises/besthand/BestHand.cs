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
        }

        public void CreateDeck()
        {
            for (int suitNumber = 0; suitNumber < 4; suitNumber++)
            {
                for (int valueNumber = 1; valueNumber < 14; valueNumber++)
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
