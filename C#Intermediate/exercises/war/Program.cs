using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{

    // deck is a property in the player object and don't need it here
    public class Game
    {
        private Player Player1;
        private Player Player2;
        public int TurnCount;

        public Game(string player1name, string player2name)
        {
            Player1 = new Player(player1name);
            Player2 = new Player(player2name);

            //Returns a shuffled set of cards
            var cards = DeckCreator.CreateCards(); 

            //Returns Player2's deck.  Player1 keeps his.
            var deck = Player1.Deal(cards); 
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
            int totalTurnCount = 0;
            int finiteGameCount = 0;
            for (int i = 0; i < 1000; i++)
            {
                //Create game
                Game game = new Game("John", "Smith");
                while (!game.IsEndOfGame())
                {
                    game.PlayTurn();
                }

                if (game.TurnCount < 1000)
                {
                    totalTurnCount += game.TurnCount;
                    finiteGameCount++;
                }
            }

            double avgTurn = (double)totalTurnCount / (double)finiteGameCount;

            Console.WriteLine(finiteGameCount + " finite games with an average of " + Math.Round(avgTurn, 2) + " turns per game.");

            Console.ReadLine();
        }
    }
}
