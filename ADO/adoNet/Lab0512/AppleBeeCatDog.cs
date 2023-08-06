using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0512
{
    internal class Book 
    {
        private string BookISBN { get; set;} // 屬性

        public string BookName = "one piece 105";
        public short price = 999; //變數

    }
    class Car
    {
        // 1. public 2. constructor name is same as class 3. constructor doesn't have return value
        public Car() { }
        public Car(string brandName) {
            this.CarBrand = brandName;
        }
        public string CarBrand { get;set; }
        public void CarStart() {
            Console.WriteLine($"{this.CarBrand} activate");
        }
    }
    
}
