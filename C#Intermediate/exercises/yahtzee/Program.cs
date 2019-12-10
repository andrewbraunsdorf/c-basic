using System;
using System.Collections.Generic;

namespace Yahtzee
{
    class RollingDie
    {
        static readonly Random random = new Random();
        private readonly int sidesCount;
        public int value;

        public RollingDie()
        {
            sidesCount = 6;
            this.value = 1;
        }

        public RollingDie(int sidesCount)
        {
            this.sidesCount = sidesCount;
            this.value = 1;
        }

        public void Roll()
        {
            this.value = random.Next(1, sidesCount + 1);
        }
    }

    class Game
    {
        public List<RollingDie> PlayersDice = new List<RollingDie>();

        public void Play()
        {
            for (int rollDice = 0; rollDice < 5; rollDice++)
            {
                PlayersDice.Add(new RollingDie());
                PlayersDice[rollDice].Roll();

            }

            
            Output();
        }

        public void Output()
        {
            Console.WriteLine("Roll: ");

            foreach (var die in PlayersDice)
            {
                Console.WriteLine("{0} ", die.value);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Game game = new Game();
            game.Play();

            Console.ReadLine();
        }
    }
}