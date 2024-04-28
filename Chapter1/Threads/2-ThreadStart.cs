using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.Threads
{
    // Not necessary but used in older program
    internal class _2_ThreadStart
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }

        //static void Main(string[] args)
        //{
        //    ThreadStart ts = new ThreadStart(ThreadHello);
        //    Thread thread = new Thread(ts);
        //    thread.Start();
        //}
    }
}
