namespace L1_1
{
    internal class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc : {0}", i);
                Thread.Sleep(0);
            }
        }
        static void Main(string[] args)
        {
            
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do Some Work.");
                Thread.Sleep(0);
            }
            t.Join();
             
        }
    }
}