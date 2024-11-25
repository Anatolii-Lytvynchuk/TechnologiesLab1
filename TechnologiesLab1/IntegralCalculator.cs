using System.Collections.Generic;
using System.Threading;

namespace TechnologiesLab1
{
    public class IntegralCalculator
    {

        public double Calculate(double a, double b, long countOfIntervals, Function function, int countThreads)
        {
            double sum = 0.0;
            object lockObj = new object();
            var threadList = new List<Thread>();
            for (int thread = 0; thread < countThreads; thread++)
            {
                int currentThread = thread;
                Thread t = new Thread(() =>
                {
                    double localSum = CalculationTrapeziumMethod(a, b, countOfIntervals, function, countThreads, currentThread);
                    lock (lockObj)
                    {
                        sum += localSum;
                    }
                });
                threadList.Add(t);
                t.Start();
            }
            threadList.ForEach( t => t.Join());
            return sum;
        }

        private double CalculationTrapeziumMethod(double a, double b, long countOfIntervals, Function function, int countThreads, int thread)
        {
            var h = (b - a) / countOfIntervals;
            var start = thread * countOfIntervals / countThreads;
            var end = (thread + 1) * countOfIntervals / countThreads;
            double sum = 0.0;
            for (long i = start; i < end; i++)
                sum += CalculateTrapezoidArea(a, h, i, function);
            return sum;
        }

        private double CalculateTrapezoidArea(double a, double h, long i, Function function) =>
            0.5 * h * (function.Calculate(a + i * h) + function.Calculate(a + (i + 1) * h));
    }
}
