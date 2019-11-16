using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            // 1 is int, value type, boxing happens
            list.Add(1);
            // string is a reference and boxing wont happen
            list.Add("James");
            // datetime is a structure, which is also a value type, boxing occurs
            list.Add(DateTime.Today);

            var number = (int) list[1];

            // boxing will not happen, interally stored as integers not objects. There is type safety
            var anotherList = new List<int>();
            anotherList.Add();

            // There is type safety, no boxing, 
            var names = new List<string>();
            names.Add();

            // working with a class and call method and that method gets an argument, of a type object, boxing will happen.
            // better to use a generic implementation if it exists

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
