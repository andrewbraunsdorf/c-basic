using System;

namespace Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
            Console.ReadLine();
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
            Console.ReadLine();
        }
    }
}