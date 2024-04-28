using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.Threads
{
    internal class _4_ParameterizedThread
    {
        static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }
        //static void Main(string[] args)
        //{
        //    ParameterizedThreadStart ps = new ParameterizedThreadStart(WorkOnData);

        //    Thread thread = new Thread(ps);

        //    thread.Start(99);
        //}
    }
}
