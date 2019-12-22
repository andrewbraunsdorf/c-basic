using System.Collections.Generic;

namespace War
{
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
}