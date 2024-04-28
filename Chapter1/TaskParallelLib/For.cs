using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    internal class For
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
        //    Parallel.For(0, items.Length, i => WorkOnItem(items[i]));

        //    Console.WriteLine("Finished Porcessing. Press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
