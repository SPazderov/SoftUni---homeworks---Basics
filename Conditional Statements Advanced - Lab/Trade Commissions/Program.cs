using System;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string place = Console.ReadLine();
            double quantityOfSales = double.Parse(Console.ReadLine());

            if (quantityOfSales <= 500 & quantityOfSales > 0)
            {
                switch (place)
                {
                    case "Sofia": Console.WriteLine($"{quantityOfSales * 0.05:f2}"); break;
                    case "Varna": Console.WriteLine($"{quantityOfSales * 0.045:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{quantityOfSales * 0.055:f2}"); break;
                }
            }
            else if (quantityOfSales <= 1000 & quantityOfSales > 500)
            {
                switch (place)
                {
                    case "Sofia": Console.WriteLine($"{quantityOfSales * 0.07:f2}"); break;
                    case "Varna": Console.WriteLine($"{quantityOfSales * 0.075:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{quantityOfSales * 0.08:f2}"); break;
                }
            }
            else if (quantityOfSales <= 10000 & quantityOfSales > 1000)
            {
                switch (place)
                {
                    case "Sofia": Console.WriteLine($"{quantityOfSales * 0.08:f2}"); break;
                    case "Varna": Console.WriteLine($"{quantityOfSales * 0.1:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{quantityOfSales * 0.12:f2}"); break;
                }
            }
            else if (quantityOfSales > 10000)
            {
                switch (place)
                {
                    case "Sofia": Console.WriteLine($"{quantityOfSales * 0.12:f2}"); break;
                    case "Varna": Console.WriteLine($"{quantityOfSales * 0.13:f2}"); break;
                    case "Plovdiv": Console.WriteLine($"{quantityOfSales * 0.145:f2}"); break;
                }
            }
            if (quantityOfSales < 0)
            {
                Console.WriteLine("error");
            }
            else if (place != "Sofia" ^ place != "Plovdiv" ^ place != "Varna")
            {
                Console.WriteLine("error");
            }

        }


    }
}
