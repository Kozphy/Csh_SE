using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.practice
{
    internal class test_Dictionary
    {
        private static Dictionary<string, string>  openWith = new Dictionary<string, string>()
         {
             { "tif",  "1"},
             { "tif2", "2"},
             { "tif3", "3"}
         };



        public  static void StartTry
            (out string value) { 
            if (openWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"tif\" is not found.");
            }
        }

        public static void IterDic() {
            foreach(var kv in openWith) {
                Console.WriteLine($"key: {kv.Key}, value: {kv.Value}");
            }
        }

        //if(openWith.TryGetValue("tif", out value))
        //{
        //    Console.WriteLine("For key = \"tif\", value = {0}.", value);
        //}else
        //{
        //    Console.WriteLine("Key = \tif\" is not found.");
        //}
    }
}
