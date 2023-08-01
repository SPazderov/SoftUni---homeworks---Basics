using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actor = Console.ReadLine();
            double pointsAcadamy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double points = 0;
            for (int i = 1; i <= n; i++)
            {
                string assesorName = Console.ReadLine();
                double assesorPoint = double.Parse(Console.ReadLine());
                pointsAcadamy += ((assesorName.Length * assesorPoint) / 2);

                if (pointsAcadamy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {pointsAcadamy:f1}!");
                    break;
                }

            }
            if (pointsAcadamy < 1250.5)
            {
                Console.WriteLine($"Sorry, {actor} you need {1250.5 - pointsAcadamy:f1} more!");
            }
        }
    }
}
