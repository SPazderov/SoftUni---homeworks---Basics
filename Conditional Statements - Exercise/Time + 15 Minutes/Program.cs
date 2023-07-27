using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursIn = int.Parse(Console.ReadLine());
            int minutesIn = int.Parse(Console.ReadLine());
            int timeInMin = minutesIn + hoursIn * 60;
            timeInMin = timeInMin + 15;
            hoursIn = timeInMin / 60;
            minutesIn = timeInMin % 60;



            if (hoursIn >= 24)
            {
                hoursIn = 0;
            }
            if (minutesIn < 10)
            {
                Console.WriteLine($"{hoursIn}:0{minutesIn}");
            }
            else
            {
                Console.WriteLine($"{hoursIn}:{minutesIn}");
            }
        }
    }
}
