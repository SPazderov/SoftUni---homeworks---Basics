using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int days = 0;

            double ownMoney = money;
            int spendCounter = 0;

            while (ownMoney < neededMoney && spendCounter < 5)
            {
                string typeOfAction = Console.ReadLine();
                double money2 = double.Parse(Console.ReadLine());
                days++;
                if (typeOfAction == "save")
                {
                    spendCounter = 0;
                    ownMoney += money2;
                }
                if (typeOfAction == "spend")
                {
                    ownMoney -= money2;
                    spendCounter++;
                    if (ownMoney <= 0)
                    {
                        ownMoney = 0;
                    }
                }
            }
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
            if (ownMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }


            /*   while (true)
               {

                   string typeOfAction = Console.ReadLine();
                   double money2 = double.Parse(Console.ReadLine());
                   if (typeOfAction == "spend")
                   {
                       ownMoney -= money2;
                       days++;
                       spendCounter++;
                       if (ownMoney <= 0)
                       {
                           ownMoney = 0;
                       }
                   }
                   if (typeOfAction == "save")
                   {
                       spendCounter = 0;
                       ownMoney += money2;
                       days++;
                       if (ownMoney == neededMoney)
                       {
                           Console.WriteLine($"You saved the money for {days} days.");
                           break;
                       }
                   }
                   if (spendCounter == 5)
                   {
                       Console.WriteLine("You can't save the money.");
                       Console.WriteLine($"{days}");
                       break;
                   }
               }


        }*/
        }
    }
}
