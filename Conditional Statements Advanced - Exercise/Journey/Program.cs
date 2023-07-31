using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double moneyForLiveIsLive = 0;
            string destination = "";
            string typeOfRest = "";
            if (budjet <= 100 & season == "summer")
            {
                moneyForLiveIsLive = budjet * 0.3;
                destination = "Bulgaria";
                typeOfRest = "Camp";
            }
            else if (budjet <= 100 & season == "winter")
            {
                moneyForLiveIsLive = budjet * 0.70;
                destination = "Bulgaria";
                typeOfRest = "Hotel";
            }
            if (budjet <= 1000 & budjet > 100 & season == "summer")
            {
                moneyForLiveIsLive = budjet * 0.40;
                destination = "Balkans";
                typeOfRest = "Camp";
            }
            else if (budjet <= 1000 & budjet > 100 & season == "winter")
            {
                moneyForLiveIsLive = budjet * 0.80;
                destination = "Balkans";
                typeOfRest = "Hotel";
            }
            else if (budjet > 1000 & (season == "summer" ^ season == "winter"))
            {
                moneyForLiveIsLive = budjet * 0.90;
                destination = "Europe";
                typeOfRest = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeOfRest} - {moneyForLiveIsLive:f2}");




        }

    }
}
