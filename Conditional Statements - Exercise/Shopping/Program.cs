using System;

namespace Shopiping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjetOfPeter = double.Parse(Console.ReadLine());
            int numberOfVideoCards = int.Parse(Console.ReadLine());
            int numberOfProcesors = int.Parse(Console.ReadLine());
            int numberOfRamMemory = int.Parse(Console.ReadLine());
            int priceForOneVideoCard = numberOfVideoCards * 250;
            double priceForProcesors = (priceForOneVideoCard * 0.35) * numberOfProcesors;
            double priceForRamMemory = (priceForOneVideoCard * 0.1) * numberOfRamMemory;
            double totalPrice = priceForRamMemory + priceForProcesors + priceForOneVideoCard;
            if (numberOfVideoCards > numberOfProcesors)
            {
                totalPrice = totalPrice - totalPrice * 0.15;

            }
            double diffrence = budjetOfPeter - totalPrice;
            if (diffrence >= 0)
            {
                Console.WriteLine($"You have {diffrence:F2} leva left!");

            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(diffrence):F2} leva more!");
            }
        }
    }
}
