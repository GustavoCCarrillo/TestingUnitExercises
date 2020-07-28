using System;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace MathApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            
            Console.WriteLine("Welcome! What type of mathematical operation would you like to do?");
            Console.WriteLine("\t Please enter one of the following arithmetic operators \n\t (*), (/), (+), (-) and press Enter:");
            string chosenOperator = Console.ReadLine();

            if(chosenOperator == "*")
            {
                Console.WriteLine(Multiplication());
            }
            else if(chosenOperator == "/")
            {
                Console.WriteLine(Division());
            }
            else if(chosenOperator == "+")
            {
                Console.WriteLine(Addition());
            }
            else if(chosenOperator == "-")
            {
                Console.WriteLine(Subtraction());
            }
            else
            {
                Console.WriteLine("Ooopss..! That is not an arithmetic operator.." +
                    "\n\t Would you like to try again? Y/N");
                string answer = Console.ReadLine().ToLower();

                if(answer == "yes" || answer == "y")
                {
                    Start();
                }
                else if(answer == "no" || answer == "n")
                {
                    Console.WriteLine("Thanks for stopping by!");
                    return;
                }
            }
        }


        //Addition of two numbers taking input from the user
        public static string Addition()
        {
            double a; double b; double result;
            string strResult = "";

            Console.WriteLine("Lets Add!");
            Console.WriteLine("\n\t Enter a number and press the Enter key: ");

            try 
            { 
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\t Enter another number and press the Enter key: ");
                b = double.Parse(Console.ReadLine());    
                result = a + b;
                strResult = $"The sum of {a} + {b} = {result}";
            }
            catch
            (FormatException ex)
            {
                Console.WriteLine($"You must enter a numer- Lets try again!" +
                    $"\n", ex);
                Start();
            }
            return strResult;
        }



        //Subtraction of two numbers taking input from the user
        public static string Subtraction()
        {
            double a; double b; double result;
            string strResult = "";

            Console.WriteLine("Lets Subtract!");
            Console.WriteLine("\n\t Type a number and press the Enter key: ");

            try 
            { 
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\t Enter another number and press thenEnter key: ");
                b = double.Parse(Console.ReadLine());
            
                result = a - b;
                strResult = $"The difference of {a} - {b} = {result}";
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"You must enter a numer- Lets try again!" +
                    $"\n", ex);
                Start();
            }
            return strResult;

        }


        //Multiplication of two numbers taking input from the user
        public static string Multiplication()
        {
            double a; double b; double result;
            string strResult = "";

            Console.WriteLine("Lets Multiply!");
            Console.WriteLine("\n\t Enter a number and press the Enter key: ");
            try
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("\n\t Enter another number and press the Enter key: ");
                b = double.Parse(Console.ReadLine());

                result = a / b;
                strResult = $"The product of {a} * {b} = {result}";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {0} - You must enter a number greater than zero. Lets try again!" +
                    $"\n", ex.Message);
                Start();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message} - You must enter a number. Lets try again!" +
                    $"\n");
                Start();
            }
            return strResult;
        }

        

        //Division of two numbers taking input from the user
        public static string Division()
        {
            double a;double b; double result;
            string strResult = "";

            Console.WriteLine("Lets Divide!");
            Console.WriteLine("\n\t Enter a number and press the Enter key: ");
            try 
            { 
             a = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\t Enter another number and press the Enter key: ");
             b = double.Parse(Console.ReadLine());

                if (b == 0)
                {
                    Console.WriteLine("You entered zero for the second value" +
                        "\n\t Division by zero is not valid" +
                        "\n\t Please enter a value greater than zero: ");
                     b = double.Parse(Console.ReadLine());
                }
                result = a / b;
                strResult = $"The quotient of {a} / {b} = {result}";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception caught: {0} You must enter a number greater than zero. Lets try again!" +
                    $"\n", ex.Message);
                Start();
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"{ex.Message} - You must enter a number. Lets try again!" +
                    $"\n");
                Start();
            }
            return strResult;
        }
    }
}
