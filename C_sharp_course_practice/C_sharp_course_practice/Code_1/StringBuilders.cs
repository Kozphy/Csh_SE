using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_course_practice.Code_1
{
    internal class StringBuilders
    {
        public void test()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            sb.AppendLine("More important text");
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string name = "Bob Smith";
            sb2.AppendFormat(enUS, "Best Customer: {0}", name);
            Console.WriteLine(sb2.ToString());
        }
    }
}
