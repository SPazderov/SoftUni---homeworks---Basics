using System;

namespace SoftUni_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double occupiedSpace = percent / 100;
            double volumeOfAquarium = lenght * width * height;
            double volumeOfAquariumInLitters = volumeOfAquarium * 0.001;
            double littersNeeded = volumeOfAquariumInLitters * (1 - occupiedSpace);
            Console.WriteLine(littersNeeded);

        }
    }
}
