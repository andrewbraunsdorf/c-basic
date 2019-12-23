using System;
using System.Collections.Generic;

namespace HIorLow
{
    class Program
    {
        public class Deck
        {
            List<int> cards = new List<int>();

            public void CreateDeck()
            {

                for (var card = 0; card <= 4; card++)
                {
                    for (var i = 0; i <= 13; i++)
                    {
                        cards.Add(i);
                    }
                }
                LogDeck();
            }

            public void LogDeck()
            {
                foreach (var card in cards)
                {
                    Console.WriteLine(card);
                }
            }
            public int getRandomCard()
            {
                var random = new Random();
                int index = random.Next(cards.Count);
                return cards[index];
            }
            }
        }


        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.CreateDeck();
            deck.playGame();
        }
    }


