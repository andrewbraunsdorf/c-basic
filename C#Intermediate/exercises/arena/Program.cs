using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    class RollingDie
    {
        //Random Number
        private Random random;
        // # of sides on dice
        private int sidesCount;

        
        
        // Constructor
        public RollingDie()
        {
            sidesCount = 6;
            random = new Random();
        }

        public RollingDie(int sidesCount)
        {
            this.sidesCount = sidesCount;
            random = new Random();
        }

        // returns number of sides die has
        public int GetSidesCount()
        {
            return sidesCount;
        }
        // Rolls a die
        public int Roll()
        {
            // dont create a random number generator in the method returning the random number.
            // it creates a a new generator for every random number and #s would never be random
            // .Next( first int is inclusive, second parameter is exclusive. 
            return random.Next(1, sidesCount + 1);
        }

        public override string ToString()
        {
            return String.Format("Rolling a die with {0} sides", sidesCount);
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            RollingDie die = new RollingDie();
            RollingDie die2 = new RollingDie(10);
            Console.WriteLine(die);
            for (int i = 0; i <10; i++)
                Console.WriteLine(die.Roll() + " ");
            //Console.WriteLine(die.GetSidesCount());
            //Console.WriteLine(die.Roll());
            //Console.WriteLine(die.Roll());

            Console.WriteLine(die2);
            for (int i = 0; i < 10; i++)
                Console.WriteLine(die2.Roll() + " ");
            //Console.WriteLine(die2.GetSidesCount());
            //Console.WriteLine(die2.Roll());
            //Console.WriteLine(die2.Roll());


            Console.ReadLine();
        }
    }
}
