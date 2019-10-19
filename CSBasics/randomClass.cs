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

      const int passwordLength = 10;

      char[] buffer = new char[passwordLength];
      for (var i = 0; i < passwordLength; i++)
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
