using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills1_1.TaskParallelLib
{
    public class CreateClass
    {
        public static void DoWork()
        {
            Console.WriteLine("Work starting");
            Thread.Sleep(2000);
            Console.WriteLine("Work finished");
        }

        //static void Main(string[] args)
        //{
        //    Task newTask = new Task(() => DoWork());
        //    newTask.Start();
        //    newTask.Wait();
        //    // OR
        //    Task newTask2 = Task.Run(() => DoWork());
        //    newTask2.Wait();
        //}
    }
}
