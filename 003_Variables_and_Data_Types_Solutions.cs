using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            EXPLORATION EXERCISES - Solutions:

            1) Make a console application that prompts the user for their name, and welcomes them with a warm greeting.
            */

            string name;

            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Nice to meet you, {0}!", name);

            /*
            2) Make a console application that prompts the user for their name and age, and then prints it on the screen.
            */

            //Two different variables cannot have the same name, so we must use different names for different variables,
            //even if they may contain the same information.
            string userName;
            string userAge;

            Console.WriteLine("What is your name? ");
            userName = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            userAge = Console.ReadLine();

            Console.WriteLine("{0} is {1} years old!", userName, userAge);

            /*
            3) Make a console application that asks the user for the name of their home town. Then, print a message containing
            a compliment to that town (i.e. Toronto is a beautiful place!).
            */

            string city;

            Console.WriteLine("What city do you live in?");
            city = Console.ReadLine();

            Console.WriteLine("{0} is a beautiful place!", city);
        }
    }
}
