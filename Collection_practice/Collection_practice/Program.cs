// See https://aka.ms/new-console-template for more information
using System.Linq;

class Book
{
    public string Name { get; set; }
    public int UnitPrice { get; set; }

    public static void CreateBooks()
    {
        var mvc = new Book { Name = "一次就懂 ASP.NET MVC", UnitPrice = 790 };
        var vue = new Book { Name = "8天絕對學不完的 Vue.js 3", UnitPrice = 600 };
        var cleanCode = new Book { Name = "Clean code 無瑕的程式碼", UnitPrice = 580 };

        List<Book> books = new List<Book>();
        books.Add(mvc);
        books.Add(vue);
        books.Add(cleanCode);
        books.RemoveAt(0);
        books.Add(new Book() { Name = "為你自己學 Git", UnitPrice = 500 });

        foreach (Book book in books)
        {
            Console.WriteLine(book.Name);
            Console.WriteLine(book.UnitPrice);
        }
    }
}

class Pd
{

    private static string[] items = new string[] { "A", "C", "B", "A", "Z", "A", "C" };
    public static void CalculateCounterLinQ()
    {
        var itemsLookUp = items.ToLookup(x => x).ToDictionary(x => x.Key, x=> x.Count());
        DisplayResult(itemsLookUp);
    }

    public static void CaculateDic()
    {
        Dictionary<string, int> res = new Dictionary<string, int>();
        foreach (var item in items)
        {
            if (res.ContainsKey(item))
            {
                res[item]++;
            }
            else
            {
                res.Add(item,1);
            }
        }
        DisplayResult(res);
    }

    private static void DisplayResult(Dictionary<string, int> result)
    {
        foreach (var item in result)
        {
            Console.WriteLine($"Key: {item.Key}, value: {item.Value}");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        #region Practice List 
        //Book.CreateBooks();
        #endregion

        #region Practice Dictionary 
        Pd.CalculateCounterLinQ();
        #endregion

    }
}

