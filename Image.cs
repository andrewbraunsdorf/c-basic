////Image Portrait or Landscape
            Console.WriteLine("Enter a height");
            var height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number");
            var width = Convert.ToInt32(Console.ReadLine());

var orientation = (height > width) ? "Image Orientation is Portrait." : "Image Orientation is Landscape.";
Console.WriteLine(orientation);
            Console.ReadLine();