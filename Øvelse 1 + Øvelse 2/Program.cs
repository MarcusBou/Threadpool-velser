using System;
using System.Diagnostics;

namespace Øvelse_1___Øvelse_2
{
    class Program
    {
        static void Main(string[] args)
        {
            proccessess p = new proccessess();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            p.ProcessWithPool();
            stopwatch.Stop();
            Console.WriteLine("With pools time it took: " + stopwatch.ElapsedTicks);// writes time it took
            stopwatch.Restart();
            stopwatch.Start();
            p.ProcessWithoutPool();
            stopwatch.Stop();
            Console.WriteLine("Without pools time it took: " + stopwatch.ElapsedTicks);// writes time it took

            Console.ReadKey();
        }
    }
}
