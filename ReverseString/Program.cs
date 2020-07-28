using System;

namespace ReverseString
{
    public class Program
    {
        public static string ReverseString(string theString)
        {
            string reversedString = "";

            for (int i = 0; i < theString.Length; i++)
            {
                reversedString += theString[theString.Length - 1 - i];
            }
            return reversedString;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"{ReverseString("Gustavo")}");
        }
    }
}