using System;

namespace WeightedAverageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compile-time initialization of values
            int homeworkScore = 97;
            int projectsScore = 82;
            int quizzesScore = 60;
            int examsScore = 75;
            int finalExamScore = 80;

            // Weight percentages
            double homeworkWeight = 0.10;
            double projectsWeight = 0.35;
            double quizzesWeight = 0.10;
            double examsWeight = 0.30;
            double finalExamWeight = 0.15;

            // Calculate weighted average
            double weightedAverage = (homeworkScore * homeworkWeight) +
                                      (projectsScore * projectsWeight) +
                                      (quizzesScore * quizzesWeight) +
                                      (examsScore * examsWeight) +
                                      (finalExamScore * finalExamWeight);

            // Display results
            Console.WriteLine("Weighted Average Calculation:");
            Console.WriteLine($"Homework Score: {homeworkScore}% (Weight: {homeworkWeight * 100}%)");
            Console.WriteLine($"Projects Score: {projectsScore}% (Weight: {projectsWeight * 100}%)");
            Console.WriteLine($"Quizzes Score: {quizzesScore}% (Weight: {quizzesWeight * 100}%)");
            Console.WriteLine($"Exams Score: {examsScore}% (Weight: {examsWeight * 100}%)");
            Console.WriteLine($"Final Exam Score: {finalExamScore}% (Weight: {finalExamWeight * 100}%)");
            Console.WriteLine($"Weighted Average: {weightedAverage:F2}");

            Console.ReadLine(); // To keep the console window open
        }
    }
}