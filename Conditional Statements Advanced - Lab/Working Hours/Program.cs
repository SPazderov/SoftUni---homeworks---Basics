using System;

namespace Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (number >= 10 & number <= 18 & (dayOfWeek == "Monday" ^ dayOfWeek == "Tuesday" ^ dayOfWeek == "Wednesday" ^
                                            dayOfWeek == "Thursday" ^ dayOfWeek == "Friday" ^ dayOfWeek == "Saturday"))
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");

            }
        }
    }
}
