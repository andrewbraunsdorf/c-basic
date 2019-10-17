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
        // casting to character which allows users to pick a character
        Console.Write((char)random.Next(97, 122));

        Console.Write((char)('a' + random.Next(0, 26)));
      }

      Console.WriteLine();
      Console.WriteLine((int)'a');

      Console.ReadLine();
    }
  }
}
