using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            int annualTaxForTraining = int.Parse(Console.ReadLine());
            int priceOfTraining = annualTaxForTraining;
            double priceForTrainers = priceOfTraining - (priceOfTraining * 0.4);
            double priceForOutfit = priceForTrainers - (priceForTrainers * 0.2);
            double priceForBall = 0.25 * priceForOutfit;
            double priceForAccsesoiries = 0.2 * priceForBall;
            double finalPrice = priceOfTraining + priceForTrainers + priceForOutfit + priceForBall + priceForAccsesoiries;

            Console.WriteLine(finalPrice);

        }
    }
}
