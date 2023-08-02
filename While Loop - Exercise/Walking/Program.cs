using System;

namespace Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int steps = 0;
            int stepsToHome = 0;
            while (input != "Going home")
            {
                int number = int.Parse(input);
                steps += number;
                if (steps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps - 10000} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                stepsToHome = int.Parse(Console.ReadLine());
                steps += stepsToHome;
                if (steps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{steps - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{10000 - steps} more steps to reach goal.");
                }
            }

        }
    }
}
