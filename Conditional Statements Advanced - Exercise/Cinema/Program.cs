using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            double income = 0;
            switch (typeOfProjection)
            {
                case "Premiere": income = 12; break;
                case "Normal": income = 7.5; break;
                case "Discount": income = 5; break;
            }
            if (typeOfProjection == "Premiere")
            {
                Console.WriteLine($"{rows * colums * income:f2}");
            }
            else if (typeOfProjection == "Normal")
            {
                Console.WriteLine($"{rows * colums * income:f2}");
            }
            else if (typeOfProjection == "Discount")
            {
                Console.WriteLine($"{rows * colums * income:f2}");
            }
        }
    }
}
