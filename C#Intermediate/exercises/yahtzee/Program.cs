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

    class Program
    {
        static void Main(string[] args)
        {


            RollingDie die = new RollingDie();

            for (int i = 0; i < 10; i++)
               Console.WriteLine(die.Roll());


            Console.ReadLine();


        }
    }
}
