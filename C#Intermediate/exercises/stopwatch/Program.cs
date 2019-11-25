using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private bool running = false;

        public void Start(DateTime start)
        {
            if (!running)
            {
                StartTime = start;
                running = true;
            }
            else
            {
                {
                    throw new InvalidOperationException("Stopwatch is already running!");
                }
            }
        }
        public void Stop(DateTime stop)
        {
            if (running)
            {
                EndTime = stop;
                running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var duration = EndTime - StartTime;

            return duration;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start(DateTime.Now);

                for (var j = 0; j <= 1000; j++)
                {
                    Thread.Sleep(1);
                }

                stopwatch.Stop(DateTime.Now);

            }

            Console.ReadLine();
        }
    }
}
