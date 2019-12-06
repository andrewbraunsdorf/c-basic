using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Die
    {
        private int rollNum;
        public Die(int sides)
        {
            rollNum = new Random().Next(1, sides);
        }

        public int GetRollnum()
        {
            return rollNum;
        }
    }

    class Program
    {
      private static void StartGame()
        {
            int modifier = 10;
            int armorClass = 20;

            Die die1 = new Die(20);

            int rollNumber = die1.GetRollnum();
            Console.WriteLine("Initial Roll: " + rollNumber);

            if (rollNumber == 1)
            {
                Console.WriteLine("Critical Miss!!!");
                Console.ReadLine();
                return;
            }
        static void Main(string[] args)
        {

        }
    }
}