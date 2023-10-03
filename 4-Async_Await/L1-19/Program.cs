using System;
using System.Linq.Expressions;

namespace L1_19
{
    internal class Program
    {
        static   void Main(string[] args)
        {
          
        }
        public static Task SleepAsyncA(int millisecondesTimeout)
        {
            return Task.Run(() => { Thread.Sleep(millisecondesTimeout); });
        }
        public static Task SleepAsyncB(int millisecondesTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs= new TaskCompletionSource<bool>();
            t.Change(millisecondesTimeout, -1);

            return tcs.Task;
        }
    }
}