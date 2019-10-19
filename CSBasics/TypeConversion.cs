using System;


namespace TypeConversion
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        string str = "true";
        bool b = Convert.ToBoolean(str);
        Console.WriteLine(b);
        Console.ReadLine();

      }
      catch (Exception)
      {
        Console.WriteLine("The number could not be converted to a byte.");
        Console.ReadLine();
      }

    }
  }
}
