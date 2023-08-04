using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.debug_p
{
    internal class debug_start
    {
        public static void Start()
        {

            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angelies" };
            var empty = new List<string>();
            var partyFriends = GetPartyFriends(empty, 7);

            foreach (var name in partyFriends)
                Console.WriteLine(name);

            Console.WriteLine();

            foreach (var name in friends)
                Console.WriteLine(name);
        }

        private static string GetPartyFriend(List<string> list)
        {

            string shortestName = list[0];

            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            
            return shortestName;
        }

        private static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list.Count == 0  || list == null)
                throw new ArgumentNullException("List", "The list is empty.");

            if (count < 0 || count > list.Count) 
            {
                throw new ArgumentOutOfRangeException("count can't be out of list.");
            }
            var buffer = new List<string>(list);
            List<string> shortestNames = new List<string>();

            while (shortestNames.Count < count)
            {
                string shortName = GetPartyFriend(buffer);
                shortestNames.Add(shortName);
                buffer.Remove(shortName);
            }
            return shortestNames;
        }
    }
}
