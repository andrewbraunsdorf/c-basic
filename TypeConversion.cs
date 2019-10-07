using System;


namespace TypeConversion
{
  class Program
  {
    static void Main(string[] args)
    {
      // works
      var number = "1234";
      var i = Convert.ToInt32(number);

      // doesn't work
      var number = "1234";
      byte b = Convert.ToByte(number);

      Console.WriteLine(i);
      Console.ReadLine();
    }
  }
}
