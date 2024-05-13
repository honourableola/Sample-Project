using System;

namespace Batch21Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("======================================");
            Console.WriteLine("Welcome to My Simple Calculator App");
            Console.WriteLine("======================================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The app allows you to perform simple arithmetic such as additon, subtraction, multiplication and division of two numbers");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 1 for Additon");
            Console.WriteLine("Enter 2 for Subtraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");
            Console.WriteLine();
            int userChoice = int.Parse(Console.ReadLine());

            if(userChoice == 1)
            {
                Console.Write("Enter the first number: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double secondNumber = double.Parse(Console.ReadLine());
                double addition = firstNumber + secondNumber;
                Console.WriteLine($"The addition of {firstNumber} and {secondNumber} is {addition}");
            }
            else if(userChoice == 2)
            {
                Console.Write("Enter the first number: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double secondNumber = double.Parse(Console.ReadLine());
                double subtraction = firstNumber - secondNumber;
                Console.WriteLine($"The subtraction of {secondNumber} from {firstNumber} is {subtraction}");
            }
            else if(userChoice == 3)
            {
                Console.Write("Enter the first number: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double secondNumber = double.Parse(Console.ReadLine());
                double multiplication = firstNumber * secondNumber;
                Console.WriteLine($"The multiplication of {firstNumber} from {secondNumber} is {multiplication}");
            }
            else if(userChoice == 4)
            {
                Console.WriteLine("Enter the numerator: ");
                int numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator: ");
                int denominator = int.Parse(Console.ReadLine());

                if(denominator == 0)
                {
                    Console.WriteLine("The denominator cannot be zero");
                    Console.WriteLine("Enter the denominator again: ");
                    denominator = int.Parse(Console.ReadLine());
                }

                if(denominator != 0)
                {
                    int division = numerator / denominator;
                    Console.WriteLine($"The division of {numerator} by {denominator} is {division}");
                } 
                else
                {
                    Console.WriteLine("Sorry, please try again");
                }              
            }
            else
            {
                Console.WriteLine("Sorry! input must be between 1 and 4, please try again");
            }
        }

    }
}
