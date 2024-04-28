using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    internal class ForEach
    {
        static void WorkOnItem(object item)
        {
            Console.WriteLine("Start working on item: " + item);
            Thread.Sleep(2000);
            Console.WriteLine("Finished working on item: " + item);
        }

        //static void Main(string[] strings)
        //{
        //    var items = Enumerable.Range(0, 500);
        //    Parallel.ForEach(items, item => WorkOnItem(item));

        //    Console.WriteLine("Finished Porcessing. Press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
