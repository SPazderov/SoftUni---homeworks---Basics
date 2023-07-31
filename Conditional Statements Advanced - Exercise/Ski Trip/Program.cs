using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();
            double priceForDay = 0;
            double totalPrice = 0;
            int night = days - 1;
            // price for one night
            switch (typeOfRoom)
            {
                case "room for one person": priceForDay = 18; break;
                case "apartment": priceForDay = 25; break;
                case "president apartment": priceForDay = 35; break;
            }
            totalPrice = priceForDay * night;
            //Discount
            if (typeOfRoom == "room for one person")
            {
                totalPrice = priceForDay * night;
            }
            if (typeOfRoom == "apartment" && night < 10)
            {
                totalPrice *= 0.70;
            }
            else if (typeOfRoom == "apartment" && (night >= 10 && night <= 15))
            {
                totalPrice *= 0.65;
            }
            else if (typeOfRoom == "apartment" && night > 15)
            {
                totalPrice *= 0.5;
            }
            if (typeOfRoom == "president apartment" && night > 15)
            {
                totalPrice *= 0.8;
            }
            else if (typeOfRoom == "president apartment" && (night >= 10 && night <= 15))
            {
                totalPrice *= 0.85;
            }
            else if (typeOfRoom == "president apartment" && night < 10)
            {
                totalPrice *= 0.9;
            }

            if (evaluation == "positive")
            {
                totalPrice = totalPrice + totalPrice * 0.25;
            }
            else if (evaluation == "negative")
            {
                totalPrice = totalPrice - totalPrice * 0.1;
            }


            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
