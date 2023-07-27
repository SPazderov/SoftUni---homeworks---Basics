using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjetForFilm = double.Parse(Console.ReadLine());
            int statistActor = int.Parse(Console.ReadLine());
            double priceForClothesToOneStatist = double.Parse(Console.ReadLine());
            double decorForFilm = budjetForFilm * 0.1;
            double priceForClothes = priceForClothesToOneStatist * statistActor;


            if (statistActor > 150)
            {
                priceForClothes = priceForClothes - priceForClothes * 0.1;
            }
            if ((decorForFilm + priceForClothes) > budjetForFilm)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {decorForFilm + priceForClothes - budjetForFilm:F2} leva more.");
            }
            if ((decorForFilm + priceForClothes) <= budjetForFilm)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budjetForFilm - (decorForFilm + priceForClothes):F2} leva left.");
            }
        }
    }
}
