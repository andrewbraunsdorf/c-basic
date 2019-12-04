using System;
using System.Collections.Generic;

namespace CardGameApp
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }

        public Player(string name)
        {
            Name = name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1cards = new Queue<Card>();
            Queue<Card> player2cards = new Queue<Card>();

            int counter = 2;

            while (player1cards.Count <= 5 && player2cards.Count <= 5)
            {
                if (counter % 2 == 0)
                {
                    player2cards.Enqueue(cards.Dequeue());
                    Console.WriteLine(cards);
                }
                else
                {
                    player1cards.Enqueue(cards.Dequeue());
                    Console.WriteLine(cards);
                }

                counter++;
            }

            Deck = player2cards;
            return player1cards;
        }
    }
}