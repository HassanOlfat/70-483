namespace L1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                return 42;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine(task.Result);
        }
    }
}