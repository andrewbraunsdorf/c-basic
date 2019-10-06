using System;

namespace Bulldozer
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            var result = worker.AddNumbers(2, 3);

            Console.WriteLine(result.ToString());
        }
    }

    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }

        public int AddNumbers(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
    }
}
