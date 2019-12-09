using System.Collections.Generic;

namespace War
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }

    public class Card
    {
        public string DisplayName { get; set; }
        public Suit Suit { get; set; }
        public int Value { get; set; }
    }

    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }
    }

    // implement a deck of cards using the built-in Queue<> object
    public static class Extensions
    {
        public static void Enqueue(this Queue<Card> cards, Queue<Card> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
