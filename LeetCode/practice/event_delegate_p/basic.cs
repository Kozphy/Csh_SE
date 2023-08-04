using System;
using System.Collections.Generic;

namespace ConsoleApp2.practice.event_delegate_p
{
    internal class delegate_Basic{
        public static void basic()
        {
           List<string> names = new List<string>{"Aiden", "Sif", "Walter", "Anatoli"};
           System.Console.WriteLine("-----before-----");
           foreach(var n in names){
            System.Console.WriteLine(n);
           }

           names.RemoveAll(Filter);

           System.Console.WriteLine("-----after------");
           foreach(string n in names){
            System.Console.WriteLine(n);
           }

        }

        static bool Filter(string s)
        {
            return s.Contains("i");
        }
    }
}