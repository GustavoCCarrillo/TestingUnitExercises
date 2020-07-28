using System;

namespace Averages
{
    class Program
    {
        static int AvgTenNumbers()             //1 Sum of Numbers
        {
            int sum = 0;
            int count;
            Console.WriteLine("Please enter ten scores:");
            for(count = 0; count < 10; count++)
            {
                Console.Write($"{count+1} next?");
                sum += Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The sum of all ten numbers is {sum}");
            return sum / count;
        }

        static char AssignLetterGrade(int averageScore)
        {
            if (averageScore >= 90) return 'A';
            if (averageScore >= 80) return 'B';
            if (averageScore >= 70) return 'C';
            if (averageScore >= 60) return 'D';
            return 'F';
        }

        static void Main(string[] args)
        {
            int score = AvgTenNumbers();
            Console.WriteLine($"The average of the ten numbers is {score}");
            char grade = AssignLetterGrade(score);
            Console.WriteLine($"The average score of {score} = the letter grade {grade}");
            
        }
    }
}
