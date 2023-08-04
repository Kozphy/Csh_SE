using ConsoleApp2.practice.Interface_p;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Inheritence_p
{
    internal class Inheritence_demo
    {
        public static void Start()
        {
            Inheritence_demo If_demo = new Inheritence_demo();
            If_demo.Chef_Inheritence();
        }
        private void Chef_Inheritence()
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();
            Console.ReadLine();
        }

    }
}
