namespace L1_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500) {
                    Console.WriteLine("Breaking Loop");
                    loopState.Break();
                }
                return;
            });
        }
    }
}