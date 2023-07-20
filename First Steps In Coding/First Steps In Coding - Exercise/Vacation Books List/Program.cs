using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPage = int.Parse(Console.ReadLine());
            int pages = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = numberOfPage / pages;
            int numberOfHours = hours / days;

            Console.WriteLine(numberOfHours);


        }
    }
}
