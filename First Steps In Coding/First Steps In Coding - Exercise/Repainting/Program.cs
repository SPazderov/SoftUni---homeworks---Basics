using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidyNylonNedeed = int.Parse(Console.ReadLine());
            int quantidyPaintNedeed = int.Parse(Console.ReadLine());
            int quantidyThinnerNedeed = int.Parse(Console.ReadLine());
            int hoursOfWork = int.Parse(Console.ReadLine());
            double percentOfPaint = quantidyPaintNedeed * 0.1;

            double priceOfNylon = (quantidyNylonNedeed + 2) * 1.50;
            double priceOfPaint = (quantidyPaintNedeed + percentOfPaint) * 14.50;
            double priceOfThinner = quantidyThinnerNedeed * 5;
            double priceOfPacket = 0.40;
            double priceOfAll = priceOfNylon + priceOfPaint + priceOfThinner + priceOfPacket;
            double priceToPay = (priceOfAll * 0.3) * 8;
            double finalAmount = priceOfAll + priceToPay;

            Console.WriteLine(finalAmount);







        }
    }
}
