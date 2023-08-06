using System.Collections.Generic;

namespace LinkList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);

            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

            // insert node
            LinkedListNode<int> node = linkedList.Find(20);
            linkedList.AddAfter(node, 25);

            // delete node
            linkedList.Remove(20);
            Console.WriteLine("--------------");
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

        }
    }
}