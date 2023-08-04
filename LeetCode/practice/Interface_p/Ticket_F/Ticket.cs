using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.practice.Interface_p.Ticket_F
{
    internal class Ticket : IEquatable<Ticket>
    {
        // property to store the duration  of the ticket in hours
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return DurationInHours == other.DurationInHours;
        }
    }
}
