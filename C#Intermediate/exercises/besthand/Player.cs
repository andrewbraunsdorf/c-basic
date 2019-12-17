using System.Collections.Generic;

namespace Besthand
{
    class Player
    {
        public int Score { get; set; }

        public Player()
        {
            this.Score = 0;
        }

        public void ScoreCalculator(List<Card> playerHand)
        {
            foreach (var item in playerHand)
            {
                this.Score += item.Value;
            }
        }
    }
}