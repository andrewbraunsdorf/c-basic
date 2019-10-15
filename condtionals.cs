using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
  class Program
  {
    static void Main(string[] args)
    {
      int hour = 10;

      if (hour > 0 && hour < 12)
      {
        Console.WriteLine("It's morning.");

      }
      else if (hour >= 12 && hour < 18)
      {
        Console.WriteLine("It's afternoon.");
      }
      else
      {
        Console.WriteLine("It's evening.");
      }
      bool isGoldCustomer = true;

      //float price;
      //if (isGoldCustomer)
      //    price = 19.95f;
      //else
      //    price = 29.95f;

      float price = (isGoldCustomer) ? 19.95f : 29.95f;

      Console.WriteLine(price);
      Console.ReadLine();
      Console.ReadLine();

      switch (season)
      {
        case Season.Fall:
          Console.WriteLine("It's fall and beautiful!'");
          break;

        case Season.Summer:
          Console.WriteLine("It's the perfect time to go to the beach!");
          break;

        default:
          Console.WriteLine("I don't understand that season!");
          break;


      }
      Console.ReadLine();

      //    // if we have duplicate code
      //    case Season.Fall:
      //    case Season.Summer:
      //    Console.WriteLine("It's beautiful!'");
      //    break;
      //
    }
  }
}

