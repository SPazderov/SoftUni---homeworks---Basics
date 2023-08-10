using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int sumPrime = 0;
            int sumNonPrime = 0;
            while (comand != "stop")
            {
                int number = int.Parse(comand);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    comand = Console.ReadLine();
                    continue;
                }
                bool isPrime = true;
                for (int i = 2; i <= number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
