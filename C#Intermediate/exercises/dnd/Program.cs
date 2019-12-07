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

                        int damageDealt = rollNumber + modifier;
            Console.WriteLine("The initial roll number is " + rollNumber + " and the modifier is " + modifier + ". Your total damage dealt is " + (modifier + rollNumber));
            Console.WriteLine("Your Armor Class is " + armorClass);

            if (damageDealt <= armorClass && rollNumber < 20)
            {
                Console.WriteLine("Critical Miss!!!");
                Console.ReadLine();
                return;
            }

            if (rollNumber == 20)
            {
                Console.WriteLine("Critical Hit!!!");
                Console.ReadLine();
                HitPoints(2);
            }

            else
            {
                HitPoints(1);
                Console.ReadLine();
            }
        private static void HitPoints(int numDice)
        {
            if (numDice == 1)
            {
                Console.WriteLine("Your armor was no match for that attack!");
            }
            List<int> damageDiceArr = new List<int>();
        }
    }
}