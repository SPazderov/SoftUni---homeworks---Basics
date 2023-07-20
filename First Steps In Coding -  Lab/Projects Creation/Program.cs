using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProject = int.Parse(Console.ReadLine());
            int hours = numberOfProject * 3;
            Console.WriteLine($"The architect {architectName} will need {hours} hours to complete {numberOfProject} project/s.");

        }
    }
}
