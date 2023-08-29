using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.test_func
{
    internal class IsLowerThanRetailPrice
    {
        private static int? Cost = 50;
        private static int? Discount = 70;
        private static int? SalesPrice = 90; 

        public static bool start()
        {
            if (Discount <= Cost ||
               Discount == null || 
               SalesPrice <= Cost
                )
            {
                return false;
            }

            return true;
        }
    }
}
