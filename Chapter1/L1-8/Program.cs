namespace L1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*");
                }

            });

            t.Wait();

        }
    }
}