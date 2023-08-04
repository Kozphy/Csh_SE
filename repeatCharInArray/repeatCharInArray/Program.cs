using System.Net.WebSockets;

namespace repeatCharInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] items = new string[] { "A", "C", "B", "A", "Z", "A", "C" };
            forLoop(items);
            Console.WriteLine();
            GetCountLinq(items);
            
        }

        static void forLoop(string[] items) { 

            Dictionary<string, int> res = new Dictionary<string, int>();

            foreach (string item in items)
            {
                if (!res.ContainsKey(item))
                {
                    res[item] = 1;
                }
                else {
                    res[item]++;
                }
            }

            foreach (KeyValuePair<string, int> item in res) {
                Console.WriteLine($"{item.Key} appear {item.Value} times");
            }
        }

        static void GetCountLinq(string[] items) {
            var query = items.ToLookup(x => x).Select(x => new { Key = x.Key, Value = x.Count() });

            foreach (var item in query) {
                Console.WriteLine($"{item.Key} appear {item.Value} times");
            }
        }
    }
}