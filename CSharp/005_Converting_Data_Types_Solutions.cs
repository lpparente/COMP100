using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            EXPLORATION EXERCISES - Solutions:

            1) You are a programmer working for a census company. Write an application that prompts the user for the
            number of TV's they have in their homes. If each TV costs $500, how much money has this person spent in TV's?
            Your program must calculate and display the answer.
            */

            Console.WriteLine("How many TV's do you have at home? ");
            int numberOfTVs = Convert.ToInt32(Console.ReadLine());

            double tvPrice = 500;

            double moneySpent = numberOfTVs * tvPrice;

            Console.WriteLine("You have spent {0} in TV's.", moneySpent);

            /*
            2) Write a program that prompts the user for their hourly pay and the number of hours worked in a month.
            Calculate and display the salary for that month.
            */

            Console.WriteLine("Please enter your hourly pay: ");
            double hourlyPay = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the hours worked this month: ");
            double hours = Convert.ToDouble(Console.ReadLine());

            var salary = hourlyPay * hours;

            Console.WriteLine("Your salary this month is {0}", salary);

            /*
            3) Make a console application that prompts the user for the first letter of their first name. Display a
            friendly message with the letter (i.e. "L is my favorite word!").
            */

            Console.WriteLine("What is the first letter of your first name? ");
            char letter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0} is my favorite letter!", letter);
        }
    }
}
