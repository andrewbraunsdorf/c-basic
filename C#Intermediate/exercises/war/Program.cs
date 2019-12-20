using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Player() { }

        public Player(string name)
        {
            Name = name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1cards = new Queue<Card>();
            Queue<Card> player2cards = new Queue<Card>();

            int counter = 2;
            while (cards.Any())
            {
                if (counter % 2 == 0) //Card etiquette says the player who is NOT the dealer gets first card
                {
                    player2cards.Enqueue(cards.Dequeue());
                }
                else
                {
                    player1cards.Enqueue(cards.Dequeue());
                }

                counter++;
            }
        }

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
        public static Queue<Card> CreateCards()
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
    public class Game
    {
        private Player Player1;
        private Player Player2;
        private int TurnCount;

        public Game(string player1name, string player2name)
        {
            Player1 = new Player(player1name);
            Player2 = new Player(player2name);

            var cards = DeckCreator.CreateCards(); //Returns a shuffled set of cards

            var deck = Player1.Deal(cards); //Returns Player2's deck.  Player1 keeps his.
            Player2.Deck = deck;
        }

        public bool IsEndOfGame()
        {
            if (!Player1.Deck.Any())
            {
                Console.WriteLine(Player1.Name + " is out of cards!  " + Player2.Name + " WINS!");
                return true;
            }
            else if (!Player2.Deck.Any())
            {
                Console.WriteLine(Player2.Name + " is out of cards!  " + Player1.Name + " WINS!");
                return true;
            }
            else if (TurnCount > 1000)
            {
                Console.WriteLine("Infinite game!  Let's call the whole thing off.");
                return true;
            }
            return false;
        }
        public void PlayTurn()
        {
            Queue<Card> pool = new Queue<Card>();

            var player1card = Player1.Deck.Dequeue();
            var player2card = Player2.Deck.Dequeue();

            pool.Enqueue(player1card);
            pool.Enqueue(player2card);

            Console.WriteLine(Player1.Name + " plays " + player1card.DisplayName + ", " + Player2.Name + " plays " + player2card.DisplayName);

            while (player1card.Value == player2card.Value)
            {
                Console.WriteLine("WAR!");
                if (Player1.Deck.Count < 4)
                {
                    Player1.Deck.Clear();
                    return;
                }
                if (Player2.Deck.Count < 4)
                {
                    Player2.Deck.Clear();
                    return;
                }

                pool.Enqueue(Player1.Deck.Dequeue());
                pool.Enqueue(Player1.Deck.Dequeue());
                pool.Enqueue(Player1.Deck.Dequeue());
                pool.Enqueue(Player2.Deck.Dequeue());
                pool.Enqueue(Player2.Deck.Dequeue());
                pool.Enqueue(Player2.Deck.Dequeue());

                player1card = Player1.Deck.Dequeue();
                player2card = Player2.Deck.Dequeue();

                pool.Enqueue(player1card);
                pool.Enqueue(player2card);

                Console.WriteLine(Player1.Name + " plays " + player1card.DisplayName + ", " + Player2.Name + " plays " + player2card.DisplayName);
            }

            if (player1card.Value < player2card.Value)
            {
                Player2.Deck.Enqueue(pool);
                Console.WriteLine(Player2.Name + " takes the hand!");
            }
            else
            {
                Player1.Deck.Enqueue(pool);
                Console.WriteLine(Player1.Name + " takes the hand!");
            }

            TurnCount++;
        }

        
    }




    class Program
    {
        static void Main(string[] args)
        {
            //DeckCreator deckCreator = new DeckCreator();
            //deckCreator.CreateCards();
            Console.ReadLine();
        }
    }
}
