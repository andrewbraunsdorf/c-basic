using System;
using System.Collections.Generic;
using System.Linq;
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

        // returns number of sides die has
        public int GetSidesCount()
        {
            return sidesCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RollingDie die = new RollingDie();

            Console.WriteLine(die.GetSidesCount());
            Console.ReadLine();
        }
    }
}
