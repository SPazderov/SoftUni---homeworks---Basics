using System;
class Program
{
    static void Main()
    {
        double record = double.Parse(Console.ReadLine());
        double distance = double.Parse(Console.ReadLine());
        double speed = double.Parse(Console.ReadLine());
        double time = distance * speed + Math.Floor((distance / 15)) * 12.5;
        if (time < record)
        {
            Console.WriteLine($"Yes, he succeeded! The new world record is {time:f2} seconds.");
        }
        else
        {
            Console.WriteLine($"No, he failed! He was {time - record:f2} seconds slower.");
        }
    }
}
