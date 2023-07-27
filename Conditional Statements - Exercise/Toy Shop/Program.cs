using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForHoliday = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int speakDoll = int.Parse(Console.ReadLine());
            int teddyBear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double pricePuzzels = puzzels * 2.6;
            double priceSpeakDoll = speakDoll * 3;
            double priceTeddyBear = teddyBear * 4.1;
            double priceMinion = minion * 8.2;
            double priceTrucks = trucks * 2;
            int numberOfToys = puzzels + speakDoll + teddyBear + minion + trucks; // number of toys
            double totalPrice = pricePuzzels + priceSpeakDoll + priceTeddyBear + priceMinion + priceTrucks; // price of toys
            double priceWithDiscount = totalPrice * 0.25;//0.25 => money for Discount






            if (numberOfToys >= 50)
            {
                totalPrice = totalPrice - priceWithDiscount;
            }

            totalPrice = totalPrice - totalPrice * 0.1;
            if (totalPrice >= priceForHoliday)
            {
                Console.WriteLine($"Yes! {totalPrice - priceForHoliday:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceForHoliday - totalPrice:F2} lv needed.");
            }



        }
    }
}
