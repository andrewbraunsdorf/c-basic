using System;

namespace LoopsExercise
{
  class Program
  {
    static void Main(string[] args)
    {
      // guess a given number between 1 and 10
      Random random = new Random();
      int randomNumber = random.Next(1, 11);

      for (var i = 0; i < 4; i++)
      {
        Console.WriteLine("Guess the chosen number between 1 and 10");
        var enteredNumber = Convert.ToInt32(Console.ReadLine());
        if (enteredNumber == randomNumber)
        {
          Console.WriteLine("You won");
          Console.ReadLine();

          return;
        }
      }
      Console.WriteLine("You Lost");
      Console.ReadLine();

    }
  }
}
