using System;
using System.Collections.Generic;

namespace Besthand
{
    class Deck
    {
        public List<Card> DeckList;

        public Deck(Random rand)
        {
            DeckList = new List<Card>();
            CreateDeck();
            ShuffleDeck(rand);
        }

        public void CreateDeck()
        {
            for (var suitNumber = 0; suitNumber < 4; suitNumber++)
            {
                for (var valueNumber = 2; valueNumber < 15; valueNumber++)
                {
                    DeckList.Add(new Card() {Suit = suitNumber, Face = valueNumber });
                    if (valueNumber == 14)
                    {
                        DeckList[DeckList.Count - 1].Value = 11;
                    }
                    else if (valueNumber <= 9)
                    {
                        DeckList[DeckList.Count - 1].Value = valueNumber;
                    }
                    else
                    {
                        DeckList[DeckList.Count - 1].Value = 10;
                    }
                }
            }
        }

        public void ShuffleDeck(Random rand)
        {
            int n = DeckList.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card card = DeckList[k];
                DeckList[k] = DeckList[n];
                DeckList[n] = card;
            }
        }

        public List<Card> DrawHand(int numberOfCards)
        {
            List<Card> hand = new List<Card>();
            int counter = 0;
            while (counter < numberOfCards)
            {

                // Top of deck
                var nextIndex = DeckList[0];
                if (nextIndex.Value != 0)
                {
                    
                    hand.Add(DeckList[DeckList.Count - 1]);
                    DeckList.RemoveAt(DeckList.Count - 1);
                    counter++;
                }
                else
                {
                    Console.WriteLine("Deck is out of cards!");
                    return hand;
                }
            }

            return hand;
        }
    }
}