using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Text and Shape are both references to same object in memory with different views
            Text text = new Text();
            // Upcasting
            Shape shape = text;

            
            text.Width = 200;
            shape.Width = 100;


            // 100 because both reference same object, just different views
            Console.WriteLine(text.Width);
            Console.WriteLine(shape.Width);
            Console.ReadLine();

        }
    }
}