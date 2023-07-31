using System;
class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int days = int.Parse(Console.ReadLine());
        double studio = 0;
        double apartment = 0;
        double expense = 0;
        if (month == "May" || month == "October")
        {
            studio = 50;
            apartment = 65;
        }
        else if (month == "June" || month == "September")
        {
            studio = 75.2;
            apartment = 68.7;
        }
        else if (month == "July" || month == "August")
        {
            studio = 76;
            apartment = 77;
        }

        studio = studio * days;
        apartment = apartment * days;

        if (days > 7 && days < 15 && (month == "May" || month == "October"))
        {
            studio *= 0.95;
        }
        else if (days > 14 && (month == "May" || month == "October"))
        {
            studio *= 0.7;
        }
        else if (days > 14 && (month == "June" || month == "September"))
        {
            studio *= 0.8;
        }
        if (days > 14)
        {
            apartment *= 0.9;
        }
        Console.WriteLine($"Apartment: {apartment:f2} lv.");
        Console.WriteLine($"Studio: {studio:f2} lv.");
    }
}
