using System;
using System.Collections.Generic;
using System.Linq;


namespace GoFish
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

    public class DeckCreator
    {
        public Queue<Card> CreateCards()
        {
            Queue<Card> cards = new Queue<Card>();
            for (int i = 2; i <= 14; i++)
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

            return Shuffle(cards);
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


        private static string GetShortName(int value, Suit suit)
        {
            string valueDisplay = "";
            if (value >= 2 && value <= 10)
            {
                valueDisplay = value.ToString();
            }
            else if (value == 11)
            {
                valueDisplay = "J";
            }
            else if (value == 12)
            {
                valueDisplay = "Q";
            }
            else if (value == 13)
            {
                valueDisplay = "K";
            }
            else if (value == 14)
            {
                valueDisplay = "A";
            }

            return valueDisplay + Enum.GetName(typeof(Suit), suit);
        }
    }

    // deck is a property in the player object and don't need it here
    //public class Game
    //{
    //    private Player Player1;
    //    private Player Player2;

    //    public Game(string player1name, string player2name)
    //    {
    //        Player1 = new Player(player1name);
    //        Player2 = new Player(player2name);

    //        var cards = DeckCreator.CreateCards(); //Returns a shuffled set of cards

    //        var deck = Player1.Deal(cards); //Returns Player2's deck.  Player1 keeps his.
    //        Player2.Deck = deck;
    //    }
    //}




    class Program
    {
        static void Main(string[] args)
        {
            DeckCreator deckCreator = new DeckCreator();
            deckCreator.CreateCards();
            Console.ReadLine();
        }
    }
}
