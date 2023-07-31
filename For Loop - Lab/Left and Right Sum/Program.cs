using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int val = 0;
        int sum1 = 0;
        int sum2 = 0;
        for (int i = 0; i < 2 * n; i++)
        {
            val = int.Parse(Console.ReadLine());

            if (i >= 0 && i < n)
            {
                sum1 = sum1 + val;
            }
            else if (i >= n && i < 2 * n)
            {
                sum2 = sum2 + val;
            }
        }
        if (sum1 == sum2)
        {
            Console.WriteLine($"Yes, sum = {sum1}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
        }
    }
}