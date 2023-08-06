using System.Diagnostics;

namespace Delegate
{
    internal class Program
    {

        public class Order
        {
            public int CalcTotal(int price, PromoHandler handler)
            {
                if (price < 0) throw new ArgumentOutOfRangeException(nameof(price), "price can't smaller than 0");
                if (handler == null) throw new ArgumentException(nameof(handler), "input must be PromoHandler");
                return handler(price);
            }

            public int CalcTotal2(int price, Func<int,int> handler)
            {
                if (price < 0) throw new ArgumentOutOfRangeException(nameof(price), "price can't smaller than 0");
                if (handler == null) throw new ArgumentException(nameof(handler), "input must be PromoHandler");
                return handler(price);
            }


        }

        static int Discount_80(int price)
        {
            return price * 8 / 10;
        }

        static int PromotionA(int price)
        {
            return price >= 10000 ? price - 1000 : price;
        }

        public delegate int PromoHandler(int price);

        static void Main(string[] args)
        {
            var order = new Order();
            int price = 10000;
            var handler = new PromoHandler(Discount_80);
            int result = order.CalcTotal(price, handler);
            Console.WriteLine(result);


            var handlerA = new PromoHandler(PromotionA);
            int resultA = order.CalcTotal(price, handlerA);
            Console.WriteLine(resultA);

            // anonymous method
            Func<int,int> discount_80 = (int p) => { return p * 8 / 10; };
            int result3 = order.CalcTotal2(price, discount_80); // 8000

            Func<int, int> promotionA = (int p) => { return (price >= 10000) ? price - 1000 : price; }; // 9000
            int result4 = order.CalcTotal2(price, promotionA);

        }
    }
}