using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int n = int.MinValue;
            while (number != "Stop")
            {

                if (n < int.Parse(number))
                {
                    n = int.Parse(number);
                }



                number = Console.ReadLine();
            }
            Console.WriteLine(n);
        }
    }
}
