using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            long answer = 0;
            int inputInt;
            string input;
            while (true)
            {
                do
                {
                    answer = 0;
                    Console.WriteLine("Welcome to the Factorial Calculator!");
                    Console.WriteLine();
                    Console.Write("Enter an integer that's greater than 0 but less than 20: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out inputInt);

                } while (answer != 0);

                    if (inputInt < 1 || inputInt > 20)
                {
                    Console.Clear();
                    Console.WriteLine("I'm sorry Dave, I'm afraid I can't do that. . .");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {

                    answer = CalculateFactorial(inputInt);

                    Console.WriteLine("The factorial of " + inputInt + " is " + answer + ".");
                    Console.ReadKey();
                    Console.Write("Continue? (y/n): ");
                    if (Console.ReadLine() != "y") break;
                }
            }
        }

        static long CalculateFactorial(int number)
        {
            long factorialAnswer = 1;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Number: " + number + " i: " + i);
                factorialAnswer *= i;
                Console.WriteLine("Factorial: " + factorialAnswer);
            }
            return factorialAnswer;
        }
    }
}
