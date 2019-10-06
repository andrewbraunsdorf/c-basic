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

            Total = Total + number;
            Console.WriteLine( (Total.ToString()));
        }

        public int Total { get; set; }
    }
}
