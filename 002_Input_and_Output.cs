/*
The Console is the medium through which information is gathered from and printed to, in order to 
interact with the user. In this context, the two most important actions are:

- Reading information given by the user,
- Displaying information to the user.

The methods for performing these actions are, respectively:

- Read() or ReadLine(),
- Write() or WriteLine().

However, we always need to write our code in a language that the computer understands. In order to use the
ReadLine() or WriteLine() methods, we must specify that we want to address these commands to the Console.

The example below uses both methods mentioned in order to make a console application
that gathers an information from the user, and prints them afterwards.

You can copy and paste the lines below into your IDE of choice to see how this code works.

*/

using System;

namespace Input_Output
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* In order to store information, variables must be created. Variables work as a "box" in which things
            are stored into. In the context of programming, these things are called data.

            In order to use variables, they must always be created, or declared, before being put into use
            (Similarly, you must first buy the box you need before putting things into it). */
            string firstName;
            string lastName;

            // The WriteLine() method is called in the Console. An information is requested.
            Console.WriteLine("Please input your first name: ");

            // The ReadLine() method is called. It allows us to store the information given by the user
            // in a variable that was previously declared.
            firstName = Console.ReadLine();

            Console.WriteLine("Please input your last name: ");
            lastName = Console.ReadLine();

            // The line below is how to insert an empty line on the Console.
            Console.WriteLine();

            // There are a few ways of displaying the output. This is the simplest one:
            Console.WriteLine(firstName);
            
            // But we can make it better using the "+" operator:
            Console.WriteLine("Hello, " + firstName);

            // A more advanced method, and probably the best way to display information, is by using placeholders.
            // Spaceholders are curly brackets {} with a number (index) inside. This number represents the position
            // of the variables placed after comma ",", identifying what is to be displayed in that place.
            //It makes the code cleaner, professional and elegant.
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        }
    }
}
