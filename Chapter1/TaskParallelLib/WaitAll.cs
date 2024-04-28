using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    public class WaitAll
    {
        public static void DoWork(int i)
        {
            Console.WriteLine("Task {0} starting", i);
            Thread.Sleep(000);
            Console.WriteLine("Task {0} ending", i);
        }

        //public static void Main(string[] args)
        //{
        //    Task[] Tasks = new Task[10];

        //    for (int i = 0; i < 10; i++)
        //    {
        //        int taskNum = i;

        //        Tasks[i] = Task.Run(() => DoWork(taskNum));
        //    }
        //    Task.WaitAll(Tasks);

        //    Console.WriteLine("Finished processing. Press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
