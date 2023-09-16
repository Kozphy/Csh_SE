namespace Thead_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread();
            Thread thread2 = new Thread();
            thread1.Start();
            thread2.Start();
            Console.WriteLine(mainThread.Name + "is complete!");
            Console.ReadKey();
        }
    }
}