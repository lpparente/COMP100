using System;

namespace Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // In the context of C#, "Console" is a class that, in simple very words, represent
            // the text stream being shown in a console application. In this course, the Console
            // will be used to both display outputs and gather inputs from the user.
            // The WriteLine method, as the name suggests, inserts a line, displaying it to the user.
            // It may contain text, numbers, or values that were previously stored in a variable.
            // If the WriteLine method are being used to show simple text strings,
            // double quotes "" must be used, and the text inside the parenthesis ("text") will be displayed.
            // The line below is your first C# console application. It displays the text  "Hello World" to the user.
            
            // You can copy and paste the line 20 into your IDE of choice and see how this code works.

            Console.WriteLine("Hello World!");
        }
    }
}
