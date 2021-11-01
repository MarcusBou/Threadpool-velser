using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_1___Øvelse_2
{
    class proccessess
    {
        public void ProcessWithPool()
        {
            for (int i = 0; i <= 10; i++)// starts threadpools executing theProcess 10 times
            {
                ThreadPool.QueueUserWorkItem(TheProcess);
            }
        }

        public void ProcessWithoutPool()
        {
            for (int i = 0; i <= 10; i++)//starts 10 threads executing the process
            {
                Thread t = new Thread(TheProcess);
                t.Start();
            }
        }

        private void TheProcess(object obj)
        {
            for (int i = 0; i < 100000; i++)// loops 100000 * 100000
            {
                for (int j = 0; j < 100000; j++)
                {

                }
            }
        }
    }
}
