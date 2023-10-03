namespace L1_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(x => x % 2 == 0).AsSequential();
                


            foreach (var result in parallelResult.Take(5)) { Console.WriteLine(result); }
        }
    }
}