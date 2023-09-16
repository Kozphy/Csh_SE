namespace Thead_task_test
{
    internal class Program
    {

        public static readonly List<Thread> ThreadList = new List<Thread>();

        // TODO: fix run concurrently
        static void Main(string[] args)
        {

        }

        private static void ThreadStart()
        {
            // Task
            Task task = new Task(() =>
            {
                Console.WriteLine("Running task in seperate thread...");
                int result = AddNumbers(5, 10);
                Console.WriteLine("Result of addition  " + result);
            });
            task.Start();

            /* 
             thread = an execution path of program
                      We can use multiple threads to perform,
                      different tasks of our program at the same time.
                      Current thread running i "main" thread
                      using Sysem.Threading;
            */

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            Console.WriteLine(mainThread.Name + "Start!");

            Action DCountDown = CountDown;
            Action DCountUp = CountUp;

            Thread threadCountDown = new Thread(CountDown);
            threadCountDown.Start();

            Thread threadCountUp = new Thread(CountUp);
            threadCountUp.Start();

            Console.WriteLine(mainThread.Name + "is complete!");
            Console.ReadKey();
        }

        static int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1: " + i + " seconds");
                // sleep 1 second
                Thread.Sleep(1000);
            };

            Console.WriteLine("Timer #1 is complete!");
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Timer #2 is complete");
        }
    }
}