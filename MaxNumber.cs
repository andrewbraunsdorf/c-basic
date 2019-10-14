using System;

namespace EnterNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Enter a number between 1 and 10.");
      //var input = Console.ReadLine();
      //var number = Convert.ToInt32(input);
      //if (number > 0 && number < 11)
      //    Console.WriteLine("Valid");
      //else
      //    Console.WriteLine("Invalid input entered.");
      //Console.ReadLine();

      Console.WriteLine("Enter a number");
      var number1 = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter a second number");
      var number2 = Convert.ToInt32(Console.ReadLine());

      var maxNumber = (number1 > number2) ? number1 : number2;
      Console.WriteLine(maxNumber);
      Console.ReadLine();
    }
  }
}
