namespace L1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() => { return 42; });

            Console.WriteLine(task.Result);
        }
    }
}