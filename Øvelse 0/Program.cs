using System;
using System.Threading;

namespace Øvelse_1
{
    class Program
    {
        public void task1(object obj)
        {
            for (int i = 0; i <= 2; i++)//runs 3 times
            {
                Console.WriteLine("Task 1 is being executed");//writes task 1
            }
        }
        public void task2(object obj)
        {
            for (int i = 0; i <= 2; i++)//runs 3 times
            {
                Console.WriteLine("Task 2 is being executed");//writes task 2
            }
        }
    }
    class threadProg
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            for (int i = 0; i < 2; i++)
            {
                ThreadPool.QueueUserWorkItem(p.task1);//queue threadpool with task1
                ThreadPool.QueueUserWorkItem(p.task2);//queue threadpool with task1
            }
            Console.Read();
        }
    }
}

