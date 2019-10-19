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

      //Console.WriteLine("Enter a number");
      //var number1 = Convert.ToInt32(Console.ReadLine());

      //Console.WriteLine("Enter a second number");
      //var number2 = Convert.ToInt32(Console.ReadLine());

      //var maxNumber = (number1 > number2) ? number1 : number2;
      //Console.WriteLine(maxNumber);
      //Console.ReadLine();

      ////Image Portrait or Landscape
      //Console.WriteLine("Enter a height");
      //var height = Convert.ToInt32(Console.ReadLine());

      //Console.WriteLine("Enter a second number");
      //var width = Convert.ToInt32(Console.ReadLine());

      //var orientation = (height > width) ? "Image Orientation is Portrait." : "Image Orientation is Landscape.";
      //Console.WriteLine(orientation);
      //Console.ReadLine();


      Console.WriteLine("Enter speed limit.");
      var speedLimit = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter car's speed'");
      var carsSpeed = Convert.ToInt32(Console.ReadLine());

      if (speedLimit > carsSpeed)
        Console.WriteLine("Ok.");
      else
      {
        const int demeritPointPerKM = 5;
        var demeritPoints = (carsSpeed - speedLimit) / demeritPointPerKM;
        if (demeritPoints > 12)
          Console.WriteLine("License Suspended");
        else
          Console.WriteLine("You received " + demeritPoints + " demerit points on your license.");

      }
      Console.ReadLine();
    }
  }
}
