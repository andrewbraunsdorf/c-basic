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
      char[] buffer = new char[10];

      var random = new Random();
      for (var i = 0; i < 10; i++)
      {
        buffer[i] = (char)('a' + random.Next(0, 26));
      }

      var password = new string(buffer);

      // strings are immutable

      Console.WriteLine(password);
      //Console.WriteLine((int)'a');

      Console.ReadLine();
    }
  }
}
