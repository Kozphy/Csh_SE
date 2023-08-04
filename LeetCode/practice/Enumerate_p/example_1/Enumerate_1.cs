using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Enumerate_p.example_1
{
    internal class Enumerate_1
    {
        public static void Start(int num)
        {
            IEnumerable<int> unkownCollections = GetCollection(num);

            Console.WriteLine("This Collections type is: " + unkownCollections.GetType());

            foreach (int i in unkownCollections)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("iter End");
        }
        private static IEnumerable<int> GetCollection(int option)
        {
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();

            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15 };
            }
        }
    }
}
