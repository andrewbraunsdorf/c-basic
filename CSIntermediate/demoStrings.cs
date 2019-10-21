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

      var names = fullName.Split(' ');
      Console.WriteLine("First name: " + names[0]);
      Console.WriteLine("Last name: " + names[1]);

      Console.WriteLine(fullName.Replace("Hugo", "Hue"));

      if (String.IsNullOrEmpty(null))
        Console.WriteLine("Invalid");

      if (String.IsNullOrEmpty(""))
        Console.WriteLine("Invalid");

      if (String.IsNullOrEmpty(" "))
        Console.WriteLine("Invalid");
      if (String.IsNullOrEmpty(" ".Trim()))
        Console.WriteLine("Invalid");

      Console.ReadLine();
    }
  }
}
