using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocity = double.Parse(Console.ReadLine());
            string speed = "start";
            if (velocity <= 10)
            {
                speed = "slow";
            }
            else if (velocity > 10 && velocity <= 50)
            {
                speed = "average";
            }
            else if (velocity > 50 && velocity <= 150)
            {
                speed = "fast";
            }
            else if (velocity > 150 && velocity <= 1000)
            {
                speed = "ultra fast";
            }
            else if (velocity > 1000)
            {
                speed = "extremely fast";
            }
            Console.WriteLine($"{speed}");

        }
    }
}
