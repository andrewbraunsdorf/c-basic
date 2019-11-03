using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                //point.Move(new Point(40, 60));
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
                Console.ReadLine();

            }

        }
    }
}
