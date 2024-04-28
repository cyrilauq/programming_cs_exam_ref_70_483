using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    public class ReturnValueFromTask
    {
        public static int CalculateResult()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
            return 99;
        }

        //static void Main(string[] args)
        //{
        //    Task<int> task = Task.Run(() => CalculateResult());

        //    Console.WriteLine(task.Result);

        //    Console.WriteLine("Finished processing. Press a key to end.");
        //    Console.ReadKey();
        //}
    }
}
