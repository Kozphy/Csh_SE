using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    public class strings
    {
        static string randString = "This is a string";

        public static void strLength() {
            // Get number of characters in string
            Console.WriteLine("String Length: {0}", randString.Length);
        }

        public static void strContains(){
            // Check if string contains other string
            Console.WriteLine("String Contains is: {0}", randString.Contains("is"));
        }

        public static void strIndexOf(){
            // Index of string match
            Console.WriteLine("Index of is: {0}", randString.IndexOf("is"));
        }

        public static void strRemove(){
            // Remove number of characters starting at an index
            Console.WriteLine("Remove string: {0}", randString.Remove(10,6));
        }

        public static void strInsert(){
            // Add a string starting at an index
            Console.WriteLine("Insert String: {0}", randString.Insert(10, "short "));
        }

        public static void strReplace(){
            // Replace a string with another
            Console.WriteLine("Replace String: {0}", randString.Replace("string", "sentence"));
        }

        // compare strings and ignore case sensitive
        public static void strComparisonOrdinalIgnoreCase(){
            // < 0: str1 preceeds str2
            int lessInt = String.Compare("A", "B", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(lessInt);

            // =: True
            bool eq = String.Equals("A", "a", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(eq);

            // > 0: str2 preceeds str1
            int GreaterInt = String.Compare("B", "A", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(GreaterInt);
        }

        public static void PadLeftRight()
        {
            string pl = randString.PadLeft(20, '.');
            Console.WriteLine(pl);
            string pr = randString.PadRight(20, '.');
            Console.WriteLine(pr);
        }

        public static void TrimWhiteSpace()
        {
            string s = randString.Trim();
            Console.WriteLine(s);
        }

        public static void UpperLower()
        {
            string s1 = randString.ToUpper();
            Console.WriteLine(s1);
            string s2 = randString.ToLower();
            Console.WriteLine(s2);
        }

        public static void FormatCreateString()
        {
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field"
                );
            Console.WriteLine(newString);
        }

        public static void newLineStr()
        {
            string newString = String.Format("{0} saw a {1} {2} in the {3}",
                "Paul", "rabbit", "eating", "field"
                );
            Console.WriteLine(newString + "\n");
        }

        public static void VerbatimString()
        {
            Console.WriteLine(@"Exactly what I Typed\n");
        }
    }


}