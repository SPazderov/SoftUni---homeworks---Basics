using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPackageDog = int.Parse(Console.ReadLine());
            int numberOfPackageCat = int.Parse(Console.ReadLine());
            double priceDogFood = numberOfPackageDog * 2.50;
            int priceCatFood = numberOfPackageCat * 4;
            double priceFoodOfMonth = priceDogFood + priceCatFood;

            Console.WriteLine($"{priceFoodOfMonth} lv.");

        }
    }
}
