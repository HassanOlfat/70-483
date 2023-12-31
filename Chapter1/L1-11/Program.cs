﻿using System.Threading.Tasks;

namespace L1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
               
                return 42;
            });

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            },TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
               
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

          var completedTask=  t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

          
            completedTask.Wait();
        }
    }
}