using System.Runtime.CompilerServices;

namespace SOLID_SingleResponsibilityPrinciple;

class Maker
{
        private string Name { get; set; }
        private string Color { get; set; }
        internal int Price { get; set; }

        public Maker(string name, string color, int price)
        {
                this.Name = name;
                this.Color = color;
                this.Price = price;
        }
}

class Invoice
{
        private Maker _maker; 
        private int _quantity;

        public Invoice(Maker maker, int quantity)
        {
                this._maker = maker;
                this._quantity = quantity;
        }

        public decimal CalculateTotal()
        {
                return this._maker.Price * this._quantity;
        }
}

class InvoiceDao
{
        private Invoice _invoice;

        public InvoiceDao(Invoice invoice)
        {
                this._invoice = invoice;
        }

        public void saveToDb()
        {
                // save to database implementation
        }
}

class InvoicePrinter
{
        private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
                this.invoice = invoice;
        }
}

class Program
{
        static void Main(string[] args)
        {
                Maker maker = new Maker("Marker", "Red", 100):
                Invoice invoice = new Invoice(maker, 10);
                invoice.calculateTotal();
        }
        
}