using System;
using System.Collections.Generic;

namespace Exercises
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter numbers seperated by hyphen (ex. 9-10-11-12");
      var input = Console.ReadLine();

      var numbers = new List<int>();
      foreach (var number in input.Split('-'))
      {
        numbers.Add(Convert.ToInt32(number));
      }

      numbers.Sort();

      for (var i = 1; i < numbers.Count; i++)
      {
        if (numbers[i] != numbers[i - 1] + 1)
        {
          Console.WriteLine("Not Consecutive");
          Console.ReadLine();
          break;
        }
      }

      Console.WriteLine("Consecutive");
      Console.ReadLine();

    }
  }
}
