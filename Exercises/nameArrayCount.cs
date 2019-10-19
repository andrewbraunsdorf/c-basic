using System;
using System.Collections.Generic;

namespace ExercisesArraysAndLists
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string>();

      while (true)
      {
        Console.Write("Enter name and hit enter (or hit enter to leave).");

        var input = Console.ReadLine();
        // always will be true if IsNullOrWhiteSpace is not added it will always be true
        if (String.IsNullOrWhiteSpace(input))
          break;

        names.Add(input);
      }

      if (names.Count > 2)
        Console.WriteLine("{0}, {1} and {2} other people like your post.", names[0], names[1], names.Count - 2);
      else if (names.Count == 2)
        Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
      else if (names.Count == 1)
        Console.WriteLine("{0} likes your post.", names[0]);
      else
        Console.WriteLine();

      Console.WriteLine(names);
      Console.ReadLine();

    }
  }
}
