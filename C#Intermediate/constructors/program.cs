using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();
            // better way is to use var
            var customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }
    }
}
