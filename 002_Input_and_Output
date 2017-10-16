/*
As mentioned before, the Console is the medium through which information is
gathered from and printed to, in order to interact with the user. In this context,
the two most important actions are:

- Reading user's input,
- Displaying data on the screen.

The methods for performing these actions are, respectively:

- Read() or ReadLine(),
- Write() or WriteLine().

In simple words, Methods are instructions that are given to an specific object. Since the
Console is what we want to interact with, we must call it, and use the Dot Operator "." followed
by the instruction that will be given to it.

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
            /*In order to store information, variables must be created. Variables work as a "box" in which things
            are stored into. In the context of programming, these things are called data.

            In order to use variables, they must always be declared before being put into use
            (Similarly, you must first buy the box you need before putting things into it). */
            string firstName;
            string lastName;

            //The WriteLine() method is called in the Console. An information is requested.
            Console.WriteLine("Please input your first name: ");

            //The ReadLine() method is called, and the information on the Console is stored in a variable.
            firstName = Console.ReadLine();

            Console.WriteLine("Please input your last name: ");
            lastName = Console.ReadLine();

            //Inserting an empty line in order to make the output more visual.
            Console.WriteLine();

            //There are a few ways of displaying the output. The "+ operator can be used to concatenate information":
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");

            //Or placeholders {} can be used instead, to make the code cleaner and elegant.
            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        }
    }
}
