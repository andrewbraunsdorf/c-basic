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
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
