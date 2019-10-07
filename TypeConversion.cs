using System;


namespace TypeConversion
{
  class Program
  {
    static void Main(string[] args)
    {
      byte b = 1;
      int i = b;

      int i = 1;
      byte b = i;
      Console.WriteLine(i);
      Console.ReadLine();
    }
  }
}
