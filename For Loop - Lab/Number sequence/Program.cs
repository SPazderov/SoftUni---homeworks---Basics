using System;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxDigit = int.MinValue;
            int minDigit = int.MaxValue;
            int helpVar = 0;

            for (int i = 0; i < n; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                if (digit > maxDigit)
                {
                    maxDigit = digit;

                }
                if (digit < minDigit)
                {
                    minDigit = digit;
                }





            }

            Console.WriteLine($"Max number: {maxDigit}");
            Console.WriteLine($"Min number: {minDigit}");
        }
    }
}
