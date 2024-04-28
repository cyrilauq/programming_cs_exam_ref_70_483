using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    internal class ParallelLoopStateEx
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Start working on item: " + item);
            Thread.Sleep(2000);
            Console.WriteLine("Finished working on item: " + item);
        }

        //static void Main(string[] strings)
        //{
        //    var items = Enumerable.Range(0, 500).ToArray();
        //    ParallelLoopResult result = Parallel.For(0, items.Length, (int i, ParallelLoopState loopState) =>
        //    {
        //        if (i == 200) loopState.Stop();

        //        WorkOnItem(items[i]);
        //    });

        //    Console.WriteLine("Completed: " + result.IsCompleted);
        //    Console.WriteLine("Items: " + result.LowestBreakIteration); // Will be used if we use Break instead of Stop

        //    Console.WriteLine("finished porcessing. press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
