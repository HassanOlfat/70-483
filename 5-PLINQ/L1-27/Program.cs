namespace L1_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(i => IsEven(i));

                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException exception)
            {

                Console.WriteLine("There where {0} exceptions",exception.InnerExceptions.Count);
            }
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new AggregateException("i");
            return i % 2 == 0;
        }
    }
}