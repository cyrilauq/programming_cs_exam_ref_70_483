using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.Threads
{
    internal class _11_ThreadPool
    {
        [ThreadStatic]
        static int LocalState;

        static void DoWork(object state)
        {
            Console.WriteLine("Doing work: {0}", state);
            LocalState = LocalState + 1;
            Console.WriteLine("Local state: {0}", LocalState);
            Thread.Sleep(500);
            Console.WriteLine("Work finished: {0}", state);
        }

        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        int stateNumber = i;
        //        ThreadPool.QueueUserWorkItem(state => DoWork(stateNumber));
        //    }
        //    Console.ReadKey();
        //}
    }
}
