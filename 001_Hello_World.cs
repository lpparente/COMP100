/*
In the context of C#, "Console" is a class that is invoked always when there is a need to interact with the user
via Console. As we are starting in a context of console applications, the Console will be used to both display 
outputs and gather inputs from the user.

The WriteLine method, as the name suggests, inserts a line, displaying it on to the screen.
It may contain text, numbers, or values that were previously stored in a variable.
If the WriteLine method is being used to show simple text strings, double quotes "" must be used, and the text 
inside the parenthesis ("text") will be displayed. The code below is your first C# console application. 
It displays the text "Hello World!" to the user.

You can copy and paste the lines below into your IDE of choice and see how this code works.
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
