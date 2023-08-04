using System;

namespace ConsoleApp2.practice.Main_p
{
    internal class main
    {
        static float num1;
        static float num2;

        public static void Start(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please input args");
                return;
            }

            bool isNum1Parsed = float.TryParse(args[1], out num1);
            bool isNum2Parsed = float.TryParse(args[2], out num2);

            if (!isNum1Parsed || !isNum2Parsed)
            {
                Console.WriteLine("Invalid arguments, please use the help command for instructions");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Hello " + args[0]);
            Console.ReadKey();

            calc_start(args);
        }

        private static void calc_start(string[] args){
            float result;

            switch (args[0])
            {
                // case 1 add
                case "add":
                    result = num1 + num2;
                    System.Console.WriteLine($"The sum of {num1} and {num2} is {result}");
                    break;
                // case 2 sub
                case "sub":
                    result = num1 - num2;
                    System.Console.WriteLine($"The sub of {num1} and {num2} is {result}");
                    break;
                default:
                    System.Console.WriteLine("Invalid arguments, please use the help cmd for instruction.");
                    break;
            }
        }
    }

}