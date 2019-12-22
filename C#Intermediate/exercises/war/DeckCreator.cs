using System;
using System.Collections.Generic;
using System.Linq;

namespace War
{
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
}