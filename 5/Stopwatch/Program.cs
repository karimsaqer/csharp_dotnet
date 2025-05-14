using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _isRunning = false;

        public TimeSpan Duration
        {
            get 
            {
                if (_isRunning)
                    throw new InvalidOperationException("Stopwatch is counting");
                return (_endTime - _startTime); 
            }
        }

        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("Stopwatch is running");
            _startTime = DateTime.Now;
            _isRunning = true;
            Console.WriteLine("Stopwatch started at: " + _startTime);
        }
        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is stopped");
            _isRunning = false;
            _endTime = DateTime.Now;
            Console.WriteLine("Stopwatch stopped at: " + _endTime);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("To Start press 0");
            Console.WriteLine("To Stop press 1");
            Console.WriteLine("To Show interval press 2");
            Console.WriteLine("To Exit press 3");
            while (true)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 0)
                {
                    stopwatch.Start();
                }
                else if (x == 1)
                {
                    stopwatch.Stop();
                }
                else if (x == 2)
                {
                    Console.WriteLine("Interval: " + stopwatch.Duration);
                }
                else if (x == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }

        }
    }
}
