using System;

namespace LoopsExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      // Enter a series of numbers separated by commas.  Find max number
      Console.WriteLine("Enter a series of numbers separated by a comma");
      var input = Console.ReadLine();
      var numbers = input.Split(',');

      var maxNumber = Convert.ToInt32(numbers[0]);

      foreach (var str in numbers)
      {
        var number = Convert.ToInt32(str);
        if (number > maxNumber)
        {
          maxNumber = number;
        }
      }
      Console.WriteLine("Max is " + maxNumber);
      Console.ReadLine();
    }
  }
}
