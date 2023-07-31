using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); //"Spring", "Summer", "Autumn", "Winter"
            int numberOfFisher = int.Parse(Console.ReadLine());
            double rentForShip = 1;

            switch (season)
            {
                case "Spring": rentForShip = 3000; break;
                case "Autumn": rentForShip = 4200; break;
                case "Summer": rentForShip = 4200; break;
                case "Winter": rentForShip = 2600; break;
            }
            if (numberOfFisher <= 6)
            {
                rentForShip = rentForShip - rentForShip * 0.10;
            }
            else if (numberOfFisher > 6 & numberOfFisher <= 11)
            {
                rentForShip = rentForShip - rentForShip * 0.15;
            }
            else if (numberOfFisher > 12)
            {
                rentForShip = rentForShip - rentForShip * 0.25;
            }
            if (numberOfFisher % 2 == 0 & season != "Autumn")
            {
                rentForShip = rentForShip - rentForShip * 0.05;
            }
            if (budjet >= rentForShip)
            {
                Console.WriteLine($"Yes! You have {budjet - rentForShip:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rentForShip - budjet:f2} leva.");
            }
        }
    }
}
