using System;

namespace Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());
            double musala = 0;
            double kilimandajaro = 0;
            double monblan = 0;
            double k2 = 0;
            double everest = 0;
            int allOfPeople = 0;


            for (int i = 1; i <= numberOfGroups; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                allOfPeople += numberOfPeople;
                if (numberOfPeople <= 5)
                {
                    musala += numberOfPeople;
                }
                else if (numberOfPeople > 5 && numberOfPeople <= 12)
                {
                    monblan += numberOfPeople;
                }
                else if (numberOfPeople > 12 && numberOfPeople <= 25)
                {
                    kilimandajaro += numberOfPeople;
                }
                else if (numberOfPeople > 25 && numberOfPeople <= 40)
                {
                    k2 += numberOfPeople;
                }
                else if (numberOfPeople > 40)
                {
                    everest += numberOfPeople;
                }
            }

            Console.WriteLine($"{(musala / allOfPeople) * 100:f2}%");
            Console.WriteLine($"{(monblan / allOfPeople) * 100:f2}%");
            Console.WriteLine($"{(kilimandajaro / allOfPeople) * 100:f2}%");
            Console.WriteLine($"{(k2 / allOfPeople) * 100:f2}%");
            Console.WriteLine($"{(everest / allOfPeople) * 100:f2}%");


        }

    }
}
