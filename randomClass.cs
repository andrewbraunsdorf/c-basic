using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      var random = new Random();
      for (var i = 0; i < 10; i++)
      {
        Console.WriteLine(random.Next());
        Console.WriteLine((char)random.Next(1, 10));
      }

      Console.WriteLine((int)'a');

      Console.ReadLine();
    }
  }
}
