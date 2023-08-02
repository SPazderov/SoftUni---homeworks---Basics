using System;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrade = int.Parse(Console.ReadLine());
            string nameOfTask = Console.ReadLine();
            int grade = 0;
            int numberBadGrade = 0;
            int numberOfGrades = 0;
            string lastProblem = "";
            double averageGrade = 0;


            while (nameOfTask != "Enough")
            {
                grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    numberBadGrade++;
                }
                if (badGrade == numberBadGrade)
                {
                    break;
                }
                averageGrade += grade;
                lastProblem = nameOfTask;
                numberOfGrades++;
                nameOfTask = Console.ReadLine();

            }
            averageGrade = averageGrade / numberOfGrades;
            if (nameOfTask == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {numberOfGrades}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            if (badGrade == numberBadGrade)
            {
                Console.WriteLine($"You need a break, {numberBadGrade} poor grades.");
            }
        }
    }
}
