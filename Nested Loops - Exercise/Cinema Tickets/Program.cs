using System;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int student = 0;
            int standard = 0;
            int kids = 0;
            double allTicket = 0;
            while (projection != "Finish")
            {
                int emptySpaces = int.Parse(Console.ReadLine());
                string typeOfTicket = Console.ReadLine();
                double sumTicket = 0;
                int countStudent = 0;
                int countStandard = 0;
                int countKid = 0;
                while (typeOfTicket != "End")
                {
                    switch (typeOfTicket)
                    {
                        case "student": countStudent++; break;
                        case "standard": countStandard++; break;
                        case "kid": countKid++; break;
                    }
                    sumTicket = countKid + countStandard + countStudent;
                    if (sumTicket >= emptySpaces)
                    {
                        break;
                    }
                    typeOfTicket = Console.ReadLine();
                }
                student += countStudent;
                standard += countStandard;
                kids += countKid;
                allTicket += sumTicket;
                Console.WriteLine($"{projection} - {sumTicket / emptySpaces * 100:f2}% full.");
                projection = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {allTicket}");
            Console.WriteLine($"{student / allTicket * 100:f2}% student tickets.");
            Console.WriteLine($"{standard / allTicket * 100:f2}% standard tickets.");
            Console.WriteLine($"{kids / allTicket * 100:f2}% kids tickets.");
        }
    }
}
