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
            int counter1 = 0;

            do
            {
                if (counter1 % 7 == 0)
                {
                    Console.WriteLine(counter1);
                }

                counter1++;
            }
            while (counter1 <= 100);

            /*
            2) Write a program that displays the sum of all numbers from 0 to 100.
            */

            // We will need two variables for this exercise.
            int counter2 = 0;
            int sum = 0;

            do
            {
                sum = sum + counter2;
                counter2++;
            }
            while (counter2 <= 100);

            Console.WriteLine(sum);
            /*
            3) Write a program that prompts the user for a number. The program must return the factorial of this number.
            Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.
            */

            int counter3 = 1;
            int factorial = 1;

            Console.WriteLine("Please input a whole number: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            do
            {
                factorial = factorial * counter3;
                counter3++;
            }
            while (counter3 <= userNumber);

            Console.WriteLine(factorial);
        }
    }
}