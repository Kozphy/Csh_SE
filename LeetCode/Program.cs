
using ConsoleApp2.grind_169;
using ConsoleApp2.test_func;
using System.ComponentModel;
using ConsoleApp2.algo;
using ConsoleApp2.practice.abstract_p;
using ConsoleApp2.practice.Interface_p;
using ConsoleApp2.practice.Inheritence_p;
using ConsoleApp2.practice.Enumerate_p;
using ConsoleApp2.practice.poly.para;
using ConsoleApp2.practice.poly;
using ConsoleApp2.practice.linq_p;
using ConsoleApp2.practice.datetime_p;
using ConsoleApp2.practice.nullable_p;
using ConsoleApp2.practice.Main_p;
using ConsoleApp2.practice.event_delegate_p;
using ConsoleApp2.practice.event_delegate_p.multicast_delegate;
using CshAlgo.algo;
using CshAlgo.grind_169;
using CshAlgo.practice.try_parse;
using CshAlgo.test_func;
using System.Numerics;
using CshAlgo.practice;
using CshAlgo.practice.value_ref_pointer_p;

namespace ConsoleApp2
{

    internal class Program
    {
        private static int[] arr1 = { 2, 2, 1 };
        private static int[] arr2 = { 4, 1, 2, 1, 2 };

        static void Main(string[] args)
        {
            // two sum
            //foreach (var i in TwoSum.hashTable())
            //{
            //    Console.WriteLine(i);
            //}
            // datetime_start.Start();
            // nullable_start.Start();
            // explain_Main_start(args);
            // main.Start(args);
            //event_delegate.Start();
            //event_and_multicast_delegate.Start();
            //Longest_SubString_3.Start();
            //try_parse tp = new try_parse();
            //tp.parse1();
            // Print(FindTheIndex_28.test());
            //Print(SingleNum.start(arr1));
            //Print(Valid_Palindrome_125.IsPalindrome("race a car"));
            PassByValue.Start();
            Console.WriteLine("----------");
            PassByReference.Start();
            Console.WriteLine("----------");
            PassByPointer.Start();
        }

        static void TryGetValue_WithDic()
        {
            string value = "ftif";
            //test_Dictionary.StartTry(out value);
            test_Dictionary.IterDic();
        }

        static void Bubble_Sort()
        {
            Bubble_sort.Start("asc");
            Console.WriteLine("------------");
            Bubble_sort.Start("desc");
        }

        static void Print<T>(T f)
        {
            Console.WriteLine(f);
        }
    }
}