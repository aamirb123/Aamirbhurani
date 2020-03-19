using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nullcoalesing9
{
    class Program
    {
        static void Main()
        {
            int? TicketonSale = null;
            int AvailableTickets = TicketonSale ?? 0;
            Console.WriteLine("Available Tickets ={0}", AvailableTickets);
        }
    }
}
