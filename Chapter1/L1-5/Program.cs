namespace L1_5
{
    internal class Program
    {
        [ThreadStatic]
        public static int _field;
        static void Main(string[] args)
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("thread A:{0}", _field);
                }
            }).Start();
           
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("thread B:{0}", _field); 
                }
            }).Start();

            Console.ReadKey();
        }
    }
}