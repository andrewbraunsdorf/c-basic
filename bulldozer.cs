using system;

namespace Bulldozer
{
    class MainClass
    {
        public static Main (string[] args)
        {
          var dozer = new Bulldozer ();
          Console.WriteLine ("Hello World");
        }
    }

    public class Bulldozer
    {
      public string color { get; set; }
      public string size { get; set; }
    }
}