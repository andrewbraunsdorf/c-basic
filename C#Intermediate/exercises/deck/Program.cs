using System;
using System.Collections.Generic;

namespace CardGameApp
{
    public enum Suit
    {
        Spades,
        Diamonds,
        Clubs,
        Hearts
    }

    public class Card
    {
        public string DisplayName { get; set; }
        public Suit Suit { get; set; }
        public int Value { get; set; }
    }

    public class Deck
    {
        public Queue<Card> CreateCards()
        {
            Queue<Card> cards = new Queue<Card>();
            for (var i = 2; i <= 14; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card()
                    {
                        Suit = suit,
                        Value = i,
                        DisplayName = GetShortName(i, suit)
                    });
                }

            }

            foreach (var card in cards)
            {
                Console.WriteLine(card.DisplayName);
                //Console.WriteLine(" {0} {1}", card.Suit, card.Value);
            }
            return cards;
        }
         private static Queue<Card> Shuffle(Queue<Card> cards)
        {
            List<Card> transformedCards = cards.ToList();
            Random r = new Random();

            for (int i = 0; i < transformedCards.Count; i++)
            {
                int k = r.Next(i, transformedCards.Count);
                Card temp = transformedCards[k];
                transformedCards[k] = transformedCards[i];
                transformedCards[i] = temp;
            }

            Queue<Card> shuffleCards = new Queue<Card>();
            foreach (var card in transformedCards)
            {
                shuffleCards.Enqueue(card);
                Console.WriteLine(card.DisplayName);
            }
            return shuffleCards;
        }

        private string GetShortName(int value, Suit suit)
        {
            string valueDisplay = "";
            switch (value)
            {
                case 11:
                    valueDisplay = "J";
                    break;
                case 12:
                    valueDisplay = "Q";
                    break;
                case 13:
                    valueDisplay = "K";
                    break;
                case 14:
                    valueDisplay = "Ace";
                    break;
                default:
                    valueDisplay = value.ToString();
                    break;
            }
            return valueDisplay + " " + Enum.GetName(typeof(Suit), suit);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.CreateCards();
            Console.ReadLine();
        }
    }
}
