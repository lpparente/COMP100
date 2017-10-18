using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* EXPLORATION EXERCISES - Solutions:

            1) Make a console application that calculates the area of a square room that is 10 meters per 5.7 meters.
            */

            int width = 10;
            double length = 5.7;

            double area = width * length;

            Console.WriteLine(area);

            /*
            2) Make a console application that prompts the user for two numbers, and show the result of the division number1 / number2.
            */

            Console.WriteLine("Please input the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double division = number1 / number2;

            Console.WriteLine("The result is {0}.", division);

            /*
            3) Make a console application that calculates the area of a circle. The radius must be given by the user.
            */

            double pi = 3.14159;

            Console.WriteLine("Please input the radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            area = pi * radius * radius;

            Console.WriteLine("The area of this circle is {0}.", area);
        }
    }
}