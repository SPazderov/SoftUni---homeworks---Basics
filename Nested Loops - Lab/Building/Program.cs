using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFloors = int.Parse(Console.ReadLine());
            int numRooms = int.Parse(Console.ReadLine());

            for (int floor = numFloors; floor > 0; floor--)
            {
                for (int room = 0; room < numRooms; room++)
                {
                    if (numFloors == floor)
                    {
                        Console.Write($"L{floor}{room} ");
                        continue;
                    }
                    if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
