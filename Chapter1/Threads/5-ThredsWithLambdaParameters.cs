using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.Threads
{
    internal class _5_ThredsWithLambdaParameters
    {
        static void WorkOnData(object data)
        {
            Console.WriteLine("Working on: {0}", data);
            Thread.Sleep(1000);
        }
        //static void Main(string[] args)
        //{
        //    Thread thread = new Thread((data) =>
        //    {
        //        WorkOnData(data);
        //    });
        //    thread.Start(99);
        //}
    }
}
