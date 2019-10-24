using System;
using System.Collections.Generic;

namespace Exercises
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter numbers separated by hyphen (ex. 9-10-11-12)");
      var input = Console.ReadLine();

      if (String.IsNullOrEmpty(input))
        return;

      var numbers = new List<int>();
      foreach (var number in input.Split('-'))
      {
        numbers.Add(Convert.ToInt32(number));
      }

      var uniqueNumbers = new List<int>();
      var includesDuplicates = false;

      foreach (int number in numbers)
      {
        if (!uniqueNumbers.Contains(number))
        {
          uniqueNumbers.Add(number);
        }
        else
        {
          includesDuplicates = true;
          break;
        }
      }
      if (includesDuplicates)
        Console.WriteLine("Duplicate");
      Console.ReadLine();
    }
  }
}
