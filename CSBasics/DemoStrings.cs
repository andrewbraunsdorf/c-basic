using System;

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        { 
            var firstName = "Hugo";
            var lastName = "James";
            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Jack", "John", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John\nLook into the following path \nc:\\folder1\\folder2";
            var texts = @"Hi John
Look into the following path 
c:\folder1\folder2";

            Console.WriteLine(text);
            Console.WriteLine(texts);

            Console.ReadLine();
        }
    }
}
