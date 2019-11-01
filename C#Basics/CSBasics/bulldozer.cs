using system;

namespace Bulldozer
{
    class MainClass
    {
        public static Main (string[] args)
        {
          var dozer = new Bulldozer ("Yellow", "Mini");
          var dozer2 = new Bulldozer ("Red", "Large");
          
          Console.WriteLine ("Bulldozer is:" + dozer.color);
        }
    }

    public class Bulldozer
    {
      public Bulldozer (string _color, string _size) {
        this.color = _color;
        this.size = _size;
      }

      public string color { get; set; }
      public string size { get; set; }
    }
}
