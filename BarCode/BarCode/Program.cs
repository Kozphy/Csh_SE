using IronBarCode;
using System.IO;

namespace BarCodeTest
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            GeneratedBarcode myBarcode = QRCodeWriter.CreateQrCode("https://www.britannica.com/technology/bitmap", 500, QRCodeWriter.QrErrorCorrectionLevel.Medium);
            DirectoryInfo executeDir = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
            string storedDir = Path.Combine(executeDir.ToString(), "波士頓派.png");
            myBarcode.SaveAsImage(storedDir);
            //Console.WriteLine(storedDir);
            //Console.WriteLine(executeDir);
            Console.ReadLine();
            //Console.WriteLine("Hello, World!");
        }
    }
}