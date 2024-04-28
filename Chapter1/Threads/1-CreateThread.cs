namespace Skills1_1.Threads
{
    internal class _1_CreateThread
    {
        static void ThreadHello()
        {
            Console.WriteLine("Hello from the thread");
            Thread.Sleep(2000);
        }

        //static void Main(string[] args)
        //{
        //    Thread thread = new Thread(ThreadHello);
        //    thread.Start();
        //}
    }
}
