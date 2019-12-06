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
        static void Main(string[] args)
        {
          
        }
    }
}