using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp2.practice.regu
{
    internal class regex_start
    {
        public static void Start() {
            Console.WriteLine("Hello world");
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 123414";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine($"{matchCollection.Count} hits found:\n {text}");

            foreach(Match hit in matchCollection) 
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine($"{group[0].Value} found at {group[0].Index}");
            }
        }
    }
}
