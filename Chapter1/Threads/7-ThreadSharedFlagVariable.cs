using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.Threads
{
    internal class _7_ThreadSharedFlagVariable
    {
        static bool tickRunning = true;  // flag variable 

        //static void Main(string[] args)
        //{
        //    tickRunning = true;

        //    Thread tickThread = new Thread(() =>
        //    {
        //        while (tickRunning)
        //        {
        //            Console.WriteLine("Tick");
        //            Thread.Sleep(1000);
        //        }
        //    });

        //    tickThread.Start();

        //    Console.WriteLine("Press a key to stop the clock");
        //    Console.ReadKey();
        //    tickRunning = false;
        //    Console.WriteLine("Press a key to exit");
        //    Console.ReadKey();
        //}
    }
}
