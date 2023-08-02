using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > sum)
            {
                sum += number;
                if (sum >= n)
                {
                    break;
                }

                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
