using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
  public class Person
  {
    public int Age;
  }
  class Program
  {
    static void Main(string[] args)
    {
      var number = 1;
      Increment(number);
      // number is 1 as scope is only local to main so it is not put in another place
      Console.WriteLine(number);

      var person = new Person() { Age = 20 };
      MakeOld(person);
      Console.WriteLine(person.Age);
      // person returns 30 as we call the method here and below
      Console.ReadLine();

    }

    public static void Increment(int number)
    {
      number += 10;
    }

    public static void MakeOld(Person person)
    {
      person.Age += 10;
    }
  }
}
