using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Enums_p
{
    internal class Enum_start
    {
        enum Day { Mo,Tu,We,Th,Fr,Sa,Su};
        enum Month { Jan=1,Feb,Mar,Apr,May,June,July,Aug, Sep, Oct, Nov, Dec}

        public static void Start() {
            Day fr = Day.Fr;
            Day su = Day.Sa;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine(Day.Mo);
            Console.WriteLine((int)Day.Mo);

            Console.WriteLine((int)Month.Jan);
            Console.WriteLine((int)Month.Dec);
            Console.ReadKey();
        }
    }
}
