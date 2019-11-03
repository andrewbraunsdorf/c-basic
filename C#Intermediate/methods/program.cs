using System;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // throws an exception... format exception, then you have to use try catch block
            var number = int.Parse("abc");
            //int number;
            // TryParse does not throw an exception
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion Failed");
            }

            Console.ReadLine();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
            Console.Read();
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
