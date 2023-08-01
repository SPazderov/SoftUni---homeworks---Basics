using System;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int pointsInRankList = int.Parse(Console.ReadLine());
            double finalPoints = 0;
            double winner = 0;
            double averagePoints = 0;

            for (int i = 1; i <= numberOfTournaments; i++)
            {
                string stageTournament = Console.ReadLine();

                if (stageTournament == "W")
                {
                    finalPoints += 2000;
                    winner += 1;
                }
                else if (stageTournament == "F")
                {
                    finalPoints += 1200;
                }
                else if (stageTournament == "SF")
                {
                    finalPoints += 720;
                }


            }
            finalPoints += pointsInRankList;
            averagePoints = Math.Floor((finalPoints - pointsInRankList) / numberOfTournaments);
            winner = (winner / numberOfTournaments) * 100;
            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {Math.Round(averagePoints)}");
            Console.WriteLine($"{winner:f2}%");
        }
    }
}
