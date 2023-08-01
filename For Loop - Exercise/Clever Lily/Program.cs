using System;

namespace Cleverly_Mariq
{
    class Program
    {
        static void Main(string[] args)
        {
            int mariqAge = int.Parse(Console.ReadLine());
            double priceForWashingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            double money = 0;
            for (int i = 1; i <= mariqAge; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += toyPrice;
                }
            }
            if (money >= priceForWashingMachine)
            {
                Console.WriteLine($"Yes! {money - priceForWashingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceForWashingMachine - money:f2}");
            }
        }
    }
}
