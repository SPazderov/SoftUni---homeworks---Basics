using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string acc = Console.ReadLine();
            string pass = Console.ReadLine();
            string passWord = Console.ReadLine();


            while (passWord != pass)
            {

                passWord = Console.ReadLine();

            }

            Console.WriteLine($"Welcome {acc}!");

        }
    }
}
