using System;


namespace Classes
{
    public class Person
    {
      public string Name;

      public void Introduce(string to)
      {
        System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
      }

      public static Person Parse(string str)
      {
        var person = new Person();
        person.Name = str;

        return person;
      }
    }
    class Program
    {
        public static void Main(string[] args)
        {
 
           // Call parse method to return person
           var p = Person.Parse("John");
           person.Introduce("Hugo");
        }

    }
}
