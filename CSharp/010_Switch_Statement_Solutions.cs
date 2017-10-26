using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            EXPLORATION EXERCISES - Solutions:

            Retry the exercises from last time, now using Switch statements.

            1) Write a program that prompts the user for the current ambient temperature. If the temperature is lower than or equal
            to 20 degrees, display the message "Too cold!". If the temperature is higher than 20 degrees, display the message 
            "Too warm!".
            */

            // You may have noticed this exercise has been slightly changed. This is because Switch statements are not as powerful
            // as If statements. They are meant to handle simpler situations.

            // Collect user's input and store in a variable.
            Console.WriteLine("Please input the current temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            // Is the temperature below than or equal to 20 degrees?
            switch (temperature <= 20)
            {
                // IN CASE yes:
                case true:
                    Console.WriteLine("Too cold!");
                    break;

                // IN CASE not:
                case false:
                    Console.WriteLine("Too warm!");
                    break;

                // Handling errors:
                default:
                    Console.WriteLine("ERROR: Invalid input!");
                    break;
            }

            /*
            2) Write a program that prompts the user for how many liters of water they drink per day. If the answer is lower than 2 liters,
            display the message "You should drink more water!". If the answer is greater than or equal to 2 liters, display the message "Good!".
            */

            Console.WriteLine("How many liters of water do you drink per day? ");
            double water = Convert.ToDouble(Console.ReadLine());

            switch (water >= 2)
            {
                case true:
                    Console.WriteLine("Good!");
                    break;

                case false:
                    Console.WriteLine("You should drink more water!");
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid input!");
                    break;
            }

            /*
            3) Write a console application that prompts the user for their gender. If the answer is "male", display the 
            message "Hello, sir.". If the answer is "female", display the message "Hello, madam.".
            */

            Console.WriteLine("Please input your gender: ");
            string gender = Console.ReadLine();

            switch (gender)
            {
                case "male":
                    Console.WriteLine("Hello, sir.");
                    break;

                case "female":
                    Console.WriteLine("Hello, madam.");
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid input!");
                    break;
            }
        }
    }
}
