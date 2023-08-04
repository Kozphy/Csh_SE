using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.practice.Interface_p.Own_F;
using ConsoleApp2.practice.Interface_p.Ticket_F;

namespace ConsoleApp2.practice.Interface_p
{
    internal class Interface_demo
    {
        public static void Start() 
        {
            //Interface_Demo_Ticket(); 
            Interface_Demo_Own();
        }
        private static void Interface_Demo_Ticket() {
            Ticket ticket1 = new Ticket(10);
            Ticket ticket2 = new Ticket(10);
            bool tick_res = ticket1.Equals(ticket2);
            Console.WriteLine(tick_res);
        }

        private static void Interface_Demo_Own()
        {
            Chair officeChair = new Chair("Brown", "plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            Car demangedCar = new Car(80f, "Blue");

            // DestoryableNearby is list of IDestoryable type and
            // Chair inherit IDestoryable type so we can Add Chair to DestoryableNearby.
            demangedCar.DestoryablesNearby.Add(officeChair);
            demangedCar.DestoryablesNearby.Add(gamingChair);

            demangedCar.Destory();
        }
        
    }
}
