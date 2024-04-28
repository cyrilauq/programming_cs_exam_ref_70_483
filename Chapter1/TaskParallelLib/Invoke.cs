using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    internal class Invoke
    {
        public static void Task1()
        {
            Console.WriteLine("Task 1 is starting");
            Thread.Sleep(2000);
            Console.WriteLine("Task 1 is ending");
        }

        public static void Task2()
        {
            Console.WriteLine("Task 2 is starting");
            Thread.Sleep(1000);
            Console.WriteLine("Task 2 is ending");
        }

        //static void Main(string[] args)
        //{
        //    Parallel.Invoke(() => Task1(), () => Task2());
        //    Console.WriteLine("Finished prossessing. Press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
