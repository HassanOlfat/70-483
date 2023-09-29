namespace L1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var result = new Int32[3];
                TaskFactory tf= new TaskFactory(TaskCreationOptions.AttachedToParent,TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => result[0] = 0);
                tf.StartNew(() => result[1] = 1);
                tf.StartNew(() => result[2] = 2);
                return result;
            });
            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (var i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });
            finalTask.Wait();
        }
    }
}