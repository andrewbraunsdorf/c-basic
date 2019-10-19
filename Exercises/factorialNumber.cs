using System;

namespace LoopsExercise
{
  class Program
  {
    static void Main(string[] args)
    {

      // ask user for number and show factorial
      var factorial = 1;

      Console.WriteLine("Enter a number to get the factorial");
      var numberEntered = Console.ReadLine();

      for (var i = Convert.ToInt32(numberEntered); i > 0; i--)
      {
        factorial *= i;
      }
      Console.WriteLine("The resulting sum factorial number of {0} is {1}", numberEntered, factorial);
      Console.ReadLine();
    }
  }
}
