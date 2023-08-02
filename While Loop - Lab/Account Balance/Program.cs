using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double cash = 0;
            while (money != "NoMoreMoney")
            {
                if (double.Parse(money) <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                double plusSum = double.Parse(money);

                cash += plusSum;


                Console.WriteLine($"Increase: {plusSum:f2}");
                money = Console.ReadLine();

            }
            Console.WriteLine($"Total: {cash:f2}");


        }
    }
}
