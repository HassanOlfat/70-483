namespace L1_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel()
                .Where(x => x %2== 0)
                .ToArray();
        }
    }
}