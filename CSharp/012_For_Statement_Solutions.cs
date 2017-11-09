using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            EXPLORATION EXERCISES - Solutions:

            1) Write a program that prints all multiples of 7 from 0 to 100.
            */

            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            /*
            2) Write a program that displays the sum of all numbers from 0 to 100.
            */

            int sum = 0;

            for (int i = 0; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine(sum);

            /*
            3) Write a program that prompts the user for a number. The program must return the factorial of this number.
            Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.
            */

            Console.WriteLine("Please input an integer number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= userInput; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
        }
    }
}