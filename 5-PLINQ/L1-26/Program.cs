namespace L1_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel()
                .Where(x => x % 2 == 0);



            parallelResult.ForAll(Console.WriteLine );
        }
    }
}