using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double m2 = double.Parse(Console.ReadLine());
            double priceOfLandscaping = m2 * 7.61;
            double discount = priceOfLandscaping * 0.18;
            double finalPrice = priceOfLandscaping - discount;
            Console.WriteLine($"The final price is:{finalPrice} lv.");
            Console.WriteLine($"The discount is:{discount} lv.");

        }
    }
}
