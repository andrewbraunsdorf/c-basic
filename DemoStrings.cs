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
        }
    }
}
