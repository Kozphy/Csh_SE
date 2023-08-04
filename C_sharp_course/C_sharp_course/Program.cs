using C_sharp_course.Code_1;
using System.Threading.Channels;

namespace C_sharp_course
{
    internal class Program
    {
        enum CarColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Red,
            Yellow
        };


        static void Main(string[] args)
        {

            //  Out Parameter
            //int solution;
            //DoubleIt(2, out solution);
            //Console.WriteLine(solution);

            // pass by reference
            int num3 = 3;
            int num4 = 4;
            test1.Swap(ref num3, ref num4);
            Console.WriteLine("num3: {0}, num4:{1}", num3, num4);

            // Params
            double[] nums = { 1, 2, 3 };
            double sum = test1.GetSumMore(nums);
            Console.WriteLine("sum: {0}", sum);
            // ------- Enums ---------
            // An enum is a custom data type with
            // key value pairs. They allow you to
            // use symbolic names to represent data
            // The first number is 0 by default unless
            // you change it
            // You can define the underlying type
            // or leave it as int as default

            // --------- variables --------

            // INTEGERS
            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            // Longs
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);

            // DECIMALS
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC: PI + bigNum = {0}", decPiVal + decBigNum);
            Console.WriteLine("Biggest Decimal: {0}", Decimal.MaxValue);

            // DOUBLES
            // Doubles are 64-bit float types
            Console.WriteLine("Biggest Double: {0}", double.MaxValue);

            // It is precise to 14 digits
            double db1PiVal = 3.14159265358979;
            double db1BigNum = 3.00000000000002;
            Console.WriteLine("DBL: PI + bigNum = {0}", db1PiVal + db1BigNum);

            // Other Data Types
            // byte : 8-bit unsigned int 0 to 255
            // char : 16-bit unicode character
            // sbyte : 8-bit signed int 128 to 127
            // short : 16-bit signed int -32,768 to 32,767
            // uint : 32-bit unsigned int 0 to 4,294,967,295
            // ulong : 64-bit unsigned int 0 to 18,446,744,073,709,551,615
            // ushort : 16-bit unsigned int 0 to 65,535

            // ------- DATA TYPE CONVERSION ------
            bool boolFromStr = bool.Parse("True");
            int intFromStr = int.Parse("100");
            double db1FromStr = double.Parse("1.234");

            // Convert double into a string
            string strVal = db1FromStr.ToString();

            // Get the new data type
            Console.WriteLine($"Data type: {strVal.GetType()}");

            // Cast double into integer (Explicit Conversion)
            // Put the data type to convert into between ()
            double db1Num = 12.345;
            Console.WriteLine($"Integer: {(int)db1Num}");

            // Implicit Conversion
            int intNum = 10;
            long longNum = intNum;

            // ---------FORMATTING OUTPUT-----------
            // currency
            Console.WriteLine("Currency: {0:c}", 23.455);

            // Pad with zeroes
            Console.WriteLine("Pad with 0s: {0:d4}", 23);

            // Define decimals
            Console.WriteLine("3 Decimals: {0:f3}", 23.4555);

            // Add commas and decimals
            Console.WriteLine("Commas: {0:n4}", 2300);

            // -------- STRINGS ----------
            string randString = "This is a string";

            // Get number of characters in string
            Console.WriteLine("String Length: {0}", randString.Length);

            // Check if string contains other string
            Console.WriteLine("String Contains is: {0}", randString.Contains("is"));

            // Index of string match
            Console.WriteLine("Index of is: {0}", randString.IndexOf("is"));

            // Remove number of characters starting at an index
            Console.WriteLine("Remove string: {0}", randString.Remove(10,6));

            // Add a string starting at an index
            Console.WriteLine("Insert String: {0}", randString.Insert(10, "short "));

            // Replace a string with another
            Console.WriteLine("Replace String: {0}", randString.Replace("string", "sentence"));


        }
    }
}