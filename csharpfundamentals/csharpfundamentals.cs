using system;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        public static Main (string[] args)
        {
          var hugo = new Person();
          hugo.FirstName = "Hugo";
          hugo.LastName = "James";
          hugo.Introduce();

          Calculator calculator = new Calculator();
          var result = calculator.Add(1, 2);
          System.Console.WriteLine(result);
        }
    }

}