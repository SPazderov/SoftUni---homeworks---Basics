using System;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            int budjetForFlowers = int.Parse(Console.ReadLine());
            double priceOfFlowers = 1;
            switch (typeOfFlowers)
            {
                case "Roses": priceOfFlowers = numberOfFlowers * 5; break;
                case "Dahlias": priceOfFlowers = numberOfFlowers * 3.80; break;
                case "Tulips": priceOfFlowers = numberOfFlowers * 2.80; break;
                case "Narcissus": priceOfFlowers = numberOfFlowers * 3; break;
                case "Gladiolus": priceOfFlowers = numberOfFlowers * 2.5; break;
            }
            if (numberOfFlowers > 80 & typeOfFlowers == "Roses")
            {
                priceOfFlowers = priceOfFlowers - priceOfFlowers * 0.10;
            }
            else if (numberOfFlowers > 90 & typeOfFlowers == "Dahlias")
            {
                priceOfFlowers = priceOfFlowers - priceOfFlowers * 0.15;
            }
            else if (numberOfFlowers > 80 & typeOfFlowers == "Tulips")
            {
                priceOfFlowers = priceOfFlowers - priceOfFlowers * 0.15;
            }
            else if (numberOfFlowers < 120 & typeOfFlowers == "Narcissus")
            {
                priceOfFlowers = priceOfFlowers + priceOfFlowers * 0.15;
            }
            else if (numberOfFlowers < 80 & typeOfFlowers == "Gladiolus")
            {
                priceOfFlowers = priceOfFlowers + priceOfFlowers * 0.20;
            }




            if (budjetForFlowers >= priceOfFlowers)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {typeOfFlowers} and {budjetForFlowers - priceOfFlowers:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {priceOfFlowers - budjetForFlowers:f2} leva more.");
            }
        }
    }
}
