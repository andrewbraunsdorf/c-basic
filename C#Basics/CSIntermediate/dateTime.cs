using System;

namespace CSharpFundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      var dateTime = new DateTime(2019, 1, 1);
      var now = DateTime.Now;
      var today = DateTime.Today;

      Console.WriteLine("Hour: " + now.Hour);
      Console.WriteLine("Minute: " + now.Minute);

      var tomorrow = now.AddDays(1);
      var yesterday = now.AddDays(-1);

      // long time
      Console.WriteLine(now.ToLongDateString());
      // short date
      Console.WriteLine(now.ToShortDateString());
      // long time
      Console.WriteLine(now.ToLongTimeString());
      // short time
      Console.WriteLine(now.ToShortTimeString());
      // date and time
      Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));


      Console.ReadLine();
    }
  }
}
