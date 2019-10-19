using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      var numberdDivisibleBy3 = 0;
      for (var i = 0; i < 100; i++)
      {
        if (i % 3 == 0)
        {
          numberdDivisibleBy3++;
        }
      }

      Console.WriteLine("There are {0} divisible by 3 between 1 and 100.", numberdDivisibleBy3);
    }
  }
}
