using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberOfChichken = int.Parse(Console.ReadLine());
            int numberOfFish = int.Parse(Console.ReadLine());
            int numberOfVegetarian = int.Parse(Console.ReadLine());

            double priceOfChichken = numberOfChichken * 10.35;
            double priceOfFish = numberOfFish * 12.40;
            double priceOfVegetarian = numberOfVegetarian * 8.15;
            double priceOfAll = priceOfChichken + priceOfFish + priceOfVegetarian;
            double priceOfAllForDesert = priceOfAll * 0.2;
            double priceOfDelivery = 2.50;
            double finalPrice = priceOfAll + priceOfAllForDesert + priceOfDelivery;

            Console.WriteLine(finalPrice);





        }
    }
}
