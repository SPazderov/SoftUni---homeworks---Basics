using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantityOfFruit = double.Parse(Console.ReadLine());


            if ((dayOfWeek == "Monday" ^ dayOfWeek == "Tuesday" ^ dayOfWeek == "Wednesday" ^ dayOfWeek == "Thursday" ^ dayOfWeek == "Friday")
                & (fruit == "banana" ^ fruit == "apple" ^ fruit == "orange" ^ fruit == "grapefruit" ^ fruit == "kiwi" ^ fruit == "pineapple" ^ fruit == "grapes"))
            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{quantityOfFruit * 2.50:f2}"); break;
                    case "apple": Console.WriteLine($"{quantityOfFruit * 1.20:f2}"); break;
                    case "orange": Console.WriteLine($"{quantityOfFruit * 0.85:f2}"); break;
                    case "grapefruit": Console.WriteLine($"{quantityOfFruit * 1.45:f2}"); break;
                    case "kiwi": Console.WriteLine($"{quantityOfFruit * 2.70:f2}"); break;
                    case "pineapple": Console.WriteLine($"{quantityOfFruit * 5.50:f2}"); break;
                    case "grapes": Console.WriteLine($"{quantityOfFruit * 3.85:f2}"); break;
                }
            }
            else if ((dayOfWeek == "Saturday" ^ dayOfWeek == "Sunday")
                 & (fruit == "banana" ^ fruit == "apple" ^ fruit == "orange" ^ fruit == "grapefruit" ^ fruit == "kiwi" ^ fruit == "pineapple" ^ fruit == "grapes"))


            {
                switch (fruit)
                {
                    case "banana": Console.WriteLine($"{quantityOfFruit * 2.70:f2}"); break;
                    case "apple": Console.WriteLine($"{quantityOfFruit * 1.25:f2}"); break;
                    case "orange": Console.WriteLine($"{quantityOfFruit * 0.90:f2}"); break;
                    case "grapefruit": Console.WriteLine($"{quantityOfFruit * 1.60:f2}"); break;
                    case "kiwi": Console.WriteLine($"{quantityOfFruit * 3.00:f2}"); break;
                    case "pineapple": Console.WriteLine($"{quantityOfFruit * 5.60:f2}"); break;
                    case "grapes": Console.WriteLine($"{quantityOfFruit * 4.20:f2}"); break;
                }
            }
            else
                Console.WriteLine("error");

        }
    }
}

