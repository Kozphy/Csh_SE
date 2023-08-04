using System.Text;
using System.Threading.Tasks;
using System.IO;
using System;

namespace FilelOc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteFile();
        }

        static void ReadFile() { 
            string Flocation = @"C:\Users\dbdf0\source\repos\C_sh_l\FilelOc\TextFile1.txt";
            // Example 1 - reading text
            string text = System.IO.File.ReadAllText(Flocation);
            Console.WriteLine("Textfile contains following text: {0}",text);

            // Example 2
            string[] lines = System.IO.File.ReadAllLines(Flocation);

            Console.WriteLine("Contents of textfile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine($"\t {line}");
            }
        }

        static void WriteFile()
        {
            var directory = VisualStudioProvider.TryGetSolutionDirectoryInfo();
            Console.WriteLine(directory);


            string Flocation = $"{directory}\\FilelOc\\TextFile2.txt";
            Console.WriteLine(Flocation);
            string[] lines = { "first line", "second line", "third line" };

            File.WriteAllLines(Flocation, lines);

            Console.WriteLine("Please input filename");
            string filename = Console.ReadLine();
            Console.WriteLine("Please input file content");
            string input = Console.ReadLine();

            File.WriteAllText($"{directory}\\FilelOc\\{filename}", input);

        }
    }
}