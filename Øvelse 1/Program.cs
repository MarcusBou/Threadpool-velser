using System;
using System.Diagnostics;

namespace Øvelse_1
{
    class Program
    {
        static void Main(string[] args)
        {
            proccess p = new proccess();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            p.ProcessWithPool();
            stopwatch.Stop();
            Console.WriteLine("With pools time it took: " + stopwatch.ElapsedTicks);
            stopwatch.Restart();
            stopwatch.Start();
            p.ProcessWithoutPool();
            stopwatch.Stop();
            Console.WriteLine("Without pools time it took: " + stopwatch.ElapsedTicks);

            Console.ReadLine();
        }
    }
}
