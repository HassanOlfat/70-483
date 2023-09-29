namespace L1_2
{
    internal class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc : {0}", i);
                Thread.Sleep(10000);
            }
        }
        static void Main(string[] args)
        {
            Thread t=new Thread(new ThreadStart( ThreadMethod));
            t.IsBackground = true;
            t.Start();
        }
    }
}