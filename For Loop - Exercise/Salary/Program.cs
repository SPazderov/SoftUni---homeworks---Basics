using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsNumber = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int penalty = 0;
            for (int i = 1; i <= tabsNumber; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook")
                {
                    penalty += 150;
                }
                else if (site == "Instagram")
                {
                    penalty += 100;
                }
                else if (site == "Reddit")
                {
                    penalty += 50;
                }
                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }
            if (salary > penalty)
            {
                Console.WriteLine(salary - penalty);
            }

        }
    }
}
