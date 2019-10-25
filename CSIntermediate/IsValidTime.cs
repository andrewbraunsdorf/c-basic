using System;
using System.Collections.Generic;

namespace Exercises
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter time in 24-hour time format (ie. 19:00): ");
      var input = Console.ReadLine();

      if (String.IsNullOrWhiteSpace(input))
      {
        Console.WriteLine("Invalid Time");
        return;
      }

      var compareTime = input.Split(':');
      if (compareTime.Length != 2)
      {
        Console.WriteLine("Invalid Time");
        return;
      }


      Console.ReadLine();
    }
  }
}
