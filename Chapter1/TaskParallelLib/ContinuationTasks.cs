using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    public class ContinuationTasks
    {
        public static void HelloTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello");
        }

        public static void WorldTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("World");
        }

        //public static void Main(string[] args)
        //{
        //    // Without option
        //    Task task = Task.Run(() => HelloTask());
        //    task.ContinueWith(prevTask => WorldTask());

        //    // With option
        //    Task task2 = Task.Run(() => HelloTask());
            
        //    task2.ContinueWith(prevTask => WorldTask(), TaskContinuationOptions.OnlyOnRanToCompletion);
        //    task2.ContinueWith(prevTask => ExceptionTask(), TaskContinuationOptions.OnlyOnFaulted);


        //    Console.WriteLine("Finished processing. Press a key to end.");
        //    Console.ReadKey();
        //}

        private static void ExceptionTask()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Exception");
        }
    }
}
