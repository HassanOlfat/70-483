namespace L1_6
{
    internal class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            
            return Thread.CurrentThread.ManagedThreadId;
        });
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Theard A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Theard B: {0}", i);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}