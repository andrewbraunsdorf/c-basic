using System;

namespace LoopsExercise
{
  class Program
  {
    static void Main(string[] args)
    {

      // ask user for number or "ok" to exit, add up numbers
      var sum = 0;
      while (true)
      {
        Console.WriteLine("Enter a number or 'ok' to exit");
        var result = Console.ReadLine();

        if (result == "ok")
        {
          break;
        }

        sum += Convert.ToInt32(result);
      }

      Console.WriteLine("The resulting sum of numbers is {0}", sum);
      Console.ReadLine();
    }
  }
}