using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGameApp
{
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
}