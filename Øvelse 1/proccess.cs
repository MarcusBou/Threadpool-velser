using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Øvelse_1
{
    class proccess
    {
        public void ProcessWithPool()
        {
            for (int i = 0; i <= 10; i++)
            {
                ThreadPool.QueueUserWorkItem(TheProcess);
            }
        }

        public void ProcessWithoutPool()
        {
            for (int i = 0; i <= 10; i++)
            {
                Thread t = new Thread(TheProcess);
                t.Start();
            }
        }

        private void TheProcess(object obj)
        {

        }
    }
}
}
