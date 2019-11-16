using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{

    public class Shape
    {
      public int Width { get; set; }
      public int Height { get; set; }
      public int X { get; set; }
      public int Y { get; set; }

      public void Draw()
      {

      }
    }

    public class Text : Shape
    {
      public int FontSize { get; set; }
      public string FontName { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
          Text text = new Text();
          Shape shape = text;

          text.Width = 200;
          shape.Width = 100;

          Console.WriteLine(text.Width);

        }
    }
}

