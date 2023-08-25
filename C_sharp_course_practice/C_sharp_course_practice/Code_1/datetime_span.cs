using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    internal class datetime_span
    {
        public void test()
        {
            // get datetime
            DateTime awDate = new DateTime(1974, 12, 31);
            Console.WriteLine("Day of week: {0}", awDate);

            // change values
            awDate = awDate.AddDays(4);
            awDate = awDate.AddMonths(1);
            awDate = awDate.AddYears(1);
            Console.WriteLine("New Date: {0}", awDate);

            // TimeSpan
            TimeSpan lt = new TimeSpan(12, 30, 0);

            lt = lt.Subtract(new TimeSpan(0, 15, 0));
            lt = lt.Add(new TimeSpan(1, 0, 0));
            Console.WriteLine("New Time: {0}", lt.ToString());




        }
    }
}
