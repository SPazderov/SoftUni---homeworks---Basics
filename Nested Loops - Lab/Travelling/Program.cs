using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double minSum = double.Parse(Console.ReadLine());
                double savingMoney = 0;
                while (minSum > savingMoney)
                {
                    savingMoney += double.Parse(Console.ReadLine());

                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
