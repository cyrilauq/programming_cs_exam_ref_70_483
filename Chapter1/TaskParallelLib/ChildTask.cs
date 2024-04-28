using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    internal class ChildTask
    {
        public static void DoChild(object state)
        {
            Console.WriteLine("Child {0} starting", state);
            Thread.Sleep(2000);
            Console.WriteLine("Child {0} finished", state);
        }

        //static void Main(string[] args)
        //{
        //    var parent = Task.Factory.StartNew(() => {
        //        Console.WriteLine("Parent starts");
        //        for (int i = 0; i < 10; i++)
        //        {
        //            int taskNo = i;
        //            Task.Factory.StartNew(
        //                (x) => DoChild(x),  // lambda function
        //                taskNo, // state object
        //                TaskCreationOptions.AttachedToParent);
        //        }
        //    });

        //    parent.Wait(); // will wait for all the attached children to complete

        //    Console.WriteLine("Parent finished. Press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
