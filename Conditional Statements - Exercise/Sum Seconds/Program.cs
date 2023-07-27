using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secontTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secontTime + thirdTime;
            int second = totalTime % 60;
            double minutes = totalTime / 60;

            if (second < 10)
            {
                Console.WriteLine($"{minutes}:0{second}");


            }
            else
            {
                Console.WriteLine($"{minutes}:{second}");

            }
        }
    }
}
