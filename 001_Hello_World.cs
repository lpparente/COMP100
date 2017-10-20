/*
As we are starting this course in a simple context, the Console will be used to both display 
outputs and gather inputs from the user. C#, and also most programming languages, have vast resources dedicated
to interacting with the user via Console.

"Hello World" is a classic introduction to programming languages. Due to its simplicity, it is easy to introduce
basic concepts to the student, such as displaying information on the screen.

The WriteLine method, as the name suggests, inserts a line, displaying it on to the screen.
It may contain text or numbers. As we want to display the message "Hello World!", which is a text string,
double quotes "" must be used.

The code below is your first C# console application. You can copy and paste the lines below into your IDE of 
choice and see how this code works.
*/

using System;

namespace Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
