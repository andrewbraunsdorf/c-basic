using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class RollingDie
    {
        private readonly Random random = new Random();
        private int sidesCount;
        public int value;

        public RollingDie()
        {
            sidesCount = 6;
            this.value = this.Roll();
        }

        public RollingDie(int sidesCount)
        {
            this.sidesCount = sidesCount;
            this.value = this.Roll();
            //random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, sidesCount + 1);
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

            }
            // string choice = UserInput();
            PlayersDice[0].Roll();
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

            //RollingDie die = new RollingDie();

            //for (int i = 0; i < 10; i++)
            //    Console.WriteLine(die.Roll());


            //Console.ReadLine();


        }
    }
}