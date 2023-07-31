using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int val = 0;
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < n; i++)
        {
            val = int.Parse(Console.ReadLine());

            if (i % 2 == 0)
            {
                sum1 = sum1 + val;
            }
            else if (i % 2 == 1)
            {
                sum2 = sum2 + val;
            }
        }
        if (sum1 == sum2)
        {
            Console.WriteLine($"Yes");
            Console.WriteLine($"Sum = {sum1}");
        }
        else
        {
            Console.WriteLine($"No");
            Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
        }
    }
}