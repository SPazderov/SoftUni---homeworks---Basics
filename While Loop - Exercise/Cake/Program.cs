using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int pieceCake = width * lenght;
            while (comand != "STOP")
            {

                int takePiece = int.Parse(comand);
                pieceCake -= takePiece;
                if (pieceCake <= 0)
                {
                    break;
                }

                comand = Console.ReadLine();


            }
            if (pieceCake <= 0)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(pieceCake)} pieces more.");
            }
            else
            {
                Console.WriteLine($"{pieceCake} pieces are left.");
            }
        }
    }
}
