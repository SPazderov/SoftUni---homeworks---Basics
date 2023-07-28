using System;

namespace Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int priceForTicket = 0;


            if (dayOfWeek == "Monday" ^ dayOfWeek == "Tuesday" ^ dayOfWeek == "Wednesday" ^ dayOfWeek == "Thursday" ^ dayOfWeek == "Friday" ^ dayOfWeek == "Saturday" ^ dayOfWeek == "Sunday")
            {
                switch (dayOfWeek)
                {
                    case "Monday": priceForTicket = 12; Console.WriteLine($"{priceForTicket}"); break;
                    case "Tuesday": priceForTicket = 12; Console.WriteLine($"{priceForTicket}"); break; ;
                    case "Wednesday": priceForTicket = 14; Console.WriteLine($"{priceForTicket}"); break; ;
                    case "Thursday": priceForTicket = 14; Console.WriteLine($"{priceForTicket}"); break; ;
                    case "Friday": priceForTicket = 12; Console.WriteLine($"{priceForTicket}"); break; ;
                    case "Saturday": priceForTicket = 16; Console.WriteLine($"{priceForTicket}"); break; ;
                    case "Sunday": priceForTicket = 16; Console.WriteLine($"{priceForTicket}"); break; ;

                }
            }
        }
    }
}
