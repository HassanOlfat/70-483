namespace L1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on Thread from Threadpool");
            });
            Console.ReadLine();
        }
    }
}