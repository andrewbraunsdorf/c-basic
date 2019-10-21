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
      var fullName = "Hugo James ";

      Console.WriteLine("Trim: '{0}'", fullName.Trim());
      Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

      var index = fullName.IndexOf(' ');
      var firstName = fullName.Substring(0, index);
      var lastName = fullName.Substring(index + 1);

      Console.WriteLine("First name: " + firstName);
      Console.WriteLine("Last name: " + lastName);

      Console.ReadLine();
    }
  }
}
