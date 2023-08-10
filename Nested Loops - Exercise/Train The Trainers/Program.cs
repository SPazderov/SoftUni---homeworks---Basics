using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int judjes = int.Parse(Console.ReadLine()); // number of judje
            string presentetion = Console.ReadLine();
            int countJudjes = 0;
            double totalAvgGrade = 0;
            while (presentetion != "Finish")
            {

                double avgGrade = 0;
                for (int i = 1; i <= judjes; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    avgGrade += grade;
                    countJudjes++;
                }
                totalAvgGrade += avgGrade;
                Console.WriteLine($"{presentetion} - {avgGrade / judjes:f2}.");

                presentetion = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalAvgGrade / countJudjes:f2}.");
        }
    }
}
