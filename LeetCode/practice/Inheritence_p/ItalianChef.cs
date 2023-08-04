using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Inheritence_p
{
    internal class ItalianChef : Chef
    {
        public override void MakeSpecialDish()
        {
            Console.WriteLine("Make special dish.");
        }

        public void MakePasta()
        {
            Console.WriteLine("The chef makes pasta.");
        }
    }
}
