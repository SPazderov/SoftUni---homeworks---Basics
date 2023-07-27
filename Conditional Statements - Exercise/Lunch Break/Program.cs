using System;

namespace Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int movieDuration = int.Parse(Console.ReadLine());
            int restDuration = int.Parse(Console.ReadLine());

            double evenTime = restDuration * 5.0 / 8;

            if (evenTime >= movieDuration)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {Math.Ceiling(evenTime - movieDuration)} minutes free time.");
            }
            else
            {

                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {Math.Ceiling(movieDuration - evenTime)} more minutes.");
            }

        }
    }
}



