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

      var hour = Convert.ToInt32(compareTime[0]);
      var minute = Convert.ToInt32(compareTime[1]);

      if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
      {
        Console.WriteLine("Valid Time");
      }
      else
      {
        Console.WriteLine("Invalid Time");
      }
      Console.ReadLine();
    }
  }
}
