using system;

namespace CSharpFundamentals
{
    public class Person
    {
      public string FirstName;
      public string LastName;

      public void Introduce()
      {
        System.Console.WriteLine("My name is " + FirstName + " " + LastName);
      }
    }
    class Program
    {
        public static Main (string[] args)
        {
          var hugo = new Person();
          hugo.FirstName = "Hugo";
          hugo.LastName = "James";
          hugo.Introduce()
        }
    }

}