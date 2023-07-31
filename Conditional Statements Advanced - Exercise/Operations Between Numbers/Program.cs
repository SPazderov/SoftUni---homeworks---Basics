using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            double helpVar = (double)N1 / N2;
            string helpVar2 = "";

            if ((N1 + N2) % 2 == 0 & symbol == '+')
            {
                helpVar2 = "even";
            }
            else if ((N1 - N2) % 2 == 0 & symbol == '-')
            {
                helpVar2 = "even";
            }
            else if ((N1 * N2) % 2 == 0 & symbol == '*')
            {
                helpVar2 = "even";
            }
            else
            {
                helpVar2 = "odd";
            }
            if (N2 == 0 & (symbol == '/' ^ symbol == '%'))
            {
                Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else
            {

                switch (symbol)
                {
                    case '+': Console.WriteLine($"{N1} + {N2} = {N1 + N2} - {helpVar2}"); break;
                    case '-': Console.WriteLine($"{N1} - {N2} = {N1 - N2} - {helpVar2}"); break;
                    case '*': Console.WriteLine($"{N1} * {N2} = {N1 * N2} - {helpVar2}"); break;
                    case '/': Console.WriteLine($"{N1} / {N2} = {helpVar:f2}"); break;
                    case '%': Console.WriteLine($"{N1} % {N2} = {N1 % N2}"); break;
                }
            }



        }
    }
}
