using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine()) * 100;
            int numcoins = 0;
            int pause = 0;

            while (change - 200 >= 0)
            {
                change -= 200;
                numcoins++;
            }
            while (change - 100 >= 0)
            {
                change -= 100;
                numcoins++;
            }
            while (change - 50 >= 0)
            {
                change -= 50;
                numcoins++;
            }
            while (change - 20 >= 0)
            {
                change -= 20;
                numcoins++;
            }
            while (change - 10 >= 0)
            {
                change -= 10;
                numcoins++;
            }
            while (change - 5 >= 0)
            {
                change -= 5;
                numcoins++;
            }
            while (change - 2 >= 0)
            {
                change -= 2;
                numcoins++;
            }
            while (change - 1 >= 0)
            {
                change -= 1;
                numcoins++;
            }


            Console.WriteLine(numcoins);


        }
    }
}




