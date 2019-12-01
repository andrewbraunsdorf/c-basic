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
                    });
                }

            }

            foreach (var card in cards)
            {
                Console.WriteLine(card.Suit + card.Value);
            }

            return cards;

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
