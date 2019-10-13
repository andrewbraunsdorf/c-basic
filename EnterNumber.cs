using System;

namespace EnterNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Write a program and ask the user to enter a number. The number should be between 1 to 10
      Console.WriteLine("Enter a number between 1 and 10.");
      var input = Console.ReadLine();
      var number = Convert.ToInt32(input);
      if (number > 0 && number < 11)
        Console.WriteLine("Valid");
      else
        Console.WriteLine("Invalid input entered.");
      Console.ReadLine();
    }
  }
}
