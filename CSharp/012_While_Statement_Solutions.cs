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

            int counter = 1;

            while (counter <= 100)
            {
                if (counter % 7 == 0)
                {
                    Console.WriteLine(counter);
                }

                counter++;
            }

            /*
            2) Write a program that displays the sum of all numbers from 0 to 100.
            */

            int sum = 0;
            int counter2 = 0;

            while (counter2 <= 100)
            {
                sum += counter2;

                counter2++;
            }

            Console.WriteLine(sum);

            /*
            3) Write a program that prompts the user for a number. The program must return the factorial of this number.
            Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.
            */

            Console.WriteLine("Please input an integer number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int counter3 = 1;
            int factorial = 1;

            while (counter3 <= userInput)
            {
                factorial *= counter3;

                counter3++;
            }

            Console.WriteLine(factorial);
        }
    }
}