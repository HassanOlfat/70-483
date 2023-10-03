namespace L1_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(x => x % 2 == 0)
                .ToArray();


            foreach (var result in parallelResult) { Console.WriteLine(result); }
        }
    }
}