using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int luggage = 0;
            int space = width * lenght * height;
            int spaceNeeded = 0;

            while (comand != "Done")
            {
                int partOfLuggage = int.Parse(comand);
                luggage += partOfLuggage;
                if (luggage > space)
                {
                    spaceNeeded = space - luggage;
                    break;
                }

                comand = Console.ReadLine();
            }
            if (luggage > space)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(spaceNeeded)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{space - luggage} Cubic meters left.");
            }



        }
    }
}
