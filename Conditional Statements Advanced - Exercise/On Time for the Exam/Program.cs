using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOfExam = int.Parse(Console.ReadLine());
            int minutesOfExam = int.Parse(Console.ReadLine());
            int hourToArriveToExam = int.Parse(Console.ReadLine());
            int minutesToArriveToExam = int.Parse(Console.ReadLine());
            int timeInMinutesToStartExam = minutesOfExam + hourOfExam * 60;
            int timeInMinutesToArriveToExam = minutesToArriveToExam + hourToArriveToExam * 60;
            int difference = 0;
            int diffHours = 0;
            int diffMin = 0;



            // Late
            if (timeInMinutesToArriveToExam > timeInMinutesToStartExam)
            {
                Console.WriteLine("Late");
                difference = timeInMinutesToArriveToExam - timeInMinutesToStartExam;
                diffHours = difference / 60;

                diffMin = difference % 60;
                if (diffHours >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine($"{diffHours}:0{diffMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffHours}:{diffMin} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{diffMin} minutes after the start");
                }
            }
            // On Time
            if (timeInMinutesToArriveToExam < timeInMinutesToStartExam)
            {

                difference = timeInMinutesToStartExam - timeInMinutesToArriveToExam;
                diffHours = difference / 60;
                diffMin = difference % 60;

                if (diffMin <= 30 && diffHours == 0)
                {
                    Console.WriteLine("On Time");
                    Console.WriteLine($"{diffMin} minutes before the start");
                }
                //
                if (diffHours >= 1)
                {
                    if (diffMin < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{diffHours}:0{diffMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{diffHours}:{diffMin} hours before the start");
                    }
                }
                else if (diffHours < 1 && diffMin > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{diffMin} minutes before the start");
                }


            }
            if (timeInMinutesToArriveToExam == timeInMinutesToStartExam)
            {
                Console.WriteLine("On Time");
            }

        }
    }

}
