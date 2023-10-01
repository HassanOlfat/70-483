namespace L1_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => { Thread.Sleep(1000); });
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers,i=> { Thread.Sleep(1000); });

        }
    }
}