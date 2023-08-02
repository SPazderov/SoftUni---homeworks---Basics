using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int n = 0;
            double sumOfEvaluation = 0;
            int breakk = 0;
            while (n < 12)
            {
                double yearEvalution = double.Parse(Console.ReadLine());

                if (yearEvalution < 4)
                {
                    breakk++;
                }
                if (breakk == 2)
                {
                    break;
                }
                sumOfEvaluation += yearEvalution;
                n++;
            }

            if (n == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumOfEvaluation / 12:f2}");
            }
            else if (n < 12)
            {
                Console.WriteLine($"{name} has been excluded at {n} grade");
            }
        }

    }
}
