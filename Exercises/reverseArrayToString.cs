using System;
using System.Collections.Generic;

namespace ExercisesArraysAndLists
{
  class Program
  {
    static void Main(string[] args)
    {
      // ask user to enter name, use array to reverse the name and then store in new string.
      Console.Write("Enter your name: ");
      var name = Console.ReadLine();

      var array = new char[name.Length];

      for (var i = name.Length; i > 0; i--)
      {
        array[name.Length - i] = name[i - 1];
      }
      var reversed = new string(array);
      Console.WriteLine("Your name reversed is: " + reversed);
      Console.ReadLine();

    }
  }
}
