using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.Threads
{
    /// <summary>
    /// When different threads use the value of their generator, it will prpduce the same exact number
    /// </summary>
    internal class _9_ThreadLocal
    {
        public static ThreadLocal<Random> RandomGenerator =
            new ThreadLocal<Random>(() =>
            {
                return new Random(2);
            });

        //static void Main(string[] args)
        //{
        //    Thread t1 = new Thread(() =>
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("t1: {0}", RandomGenerator.Value.Next(10));
        //            Thread.Sleep(500);
        //        }
        //    });

        //    Thread t2 = new Thread(() =>
        //    {
        //        for (int i = 0; i < 5; i++)
        //        {
        //            Console.WriteLine("t2: {0}", RandomGenerator.Value.Next(10));
        //            Thread.Sleep(500);
        //        }
        //    });

        //    t1.Start();
        //    t2.Start();

        //    Console.ReadKey();
        //}
    }
}
