using System;

namespace Bulldozer
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);

            worker.Count(4.5f);
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        public void Count(int number)
        {
            if (Total == null)
                Total = 0;

            Total = Total + Convert.ToSingle(number);
            Console.WriteLine( (Total.ToString()));
        }

        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine((Total.ToString()));
        }

        public float Total { get; set; }
    }
}
