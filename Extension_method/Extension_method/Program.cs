using System.Threading.Channels;

namespace Extension_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string source = null;
            string result;

            result = source.Left(10);

            source = string.Empty;
            result = source.Left(10);

            source = "abcdef";
            result = source.Left(-10);

            result = source.Left(100);

            result = source.Left(3); // abc
            Console.WriteLine(result);

            Console.WriteLine("--------------------");
            List<string> itemsA = new List<string> { "A", null, "B", null, null, "C" };
            List<string> resultA = itemsA.WhereNotNull(); // "A", "B", "C"
            resultA.ForEach(item => Console.WriteLine(item));


        }
    }
    public static class StringExts
    {
        public static string Left(this string source, int length)
        {
            if (string.IsNullOrEmpty(source)) return string.Empty;
            if (length <= 0) return string.Empty;
            if (length > source.Length) return source;

            return source.Substring(0, length);
        }
    }

    public static class ArrayExts
    {
        public static List<T> WhereNotNull<T>(this List<T> source) where T : class
        {
            if (source == null) return new List<T>();
            return source.Where((x) => x != null).ToList();
        }
    }


}