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
            public int GetRandomCard()
            {
                var random = new Random();
                int index = random.Next(cards.Count);
                return cards[index];
            }
            public void playGame()
            {
                var score = 0;

                var currentCard = GetRandomCard();

                var guessStatus = true;
                while (guessStatus)
                {

                    var nextCard = GetRandomCard();
                    while (nextCard == currentCard)
                    {
                        nextCard = GetRandomCard();
                    }

                    Console.WriteLine(currentCard);
                    Console.WriteLine(nextCard);

                    Console.WriteLine("Is the next card going to be higher or lower than the current card: " + currentCard);

                }
                Console.WriteLine("Sorry you guessed wrong, please play again. Your score was: " + score);

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


