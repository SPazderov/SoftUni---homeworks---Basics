using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            int littersOfStaff = int.Parse(Console.ReadLine());
            double percentOfDiscount = int.Parse(Console.ReadLine());

            double priceOfPen = numberOfPens * 5.80;
            double priceOfMarkers = numberOfMarkers * 7.20;
            double priceOfStaff = littersOfStaff * 1.20;
            double priceForAni = priceOfPen + priceOfMarkers + priceOfStaff;
            double priceForAniWithDiscount = priceForAni - (priceForAni * (percentOfDiscount / 100));

            Console.WriteLine(priceForAniWithDiscount);







        }
    }
}
