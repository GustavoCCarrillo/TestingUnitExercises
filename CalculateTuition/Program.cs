using System;

namespace CalculateTuition
{
    class Program
    {
        public static string TuitionCalculator(int year)
        {
            double tuition = 6000;
            string finalTuition;
            for (int i = 1; i <= year; i++)
            {
                tuition += tuition * 0.2;
            }
            return finalTuition = $"For year {year} your tuition will be {tuition}";


        }
        static void Main(string[] args)
        {
            Console.WriteLine(TuitionCalculator(3));
        }
    }
}
