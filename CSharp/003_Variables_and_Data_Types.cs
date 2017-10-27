/*
As mentioned in the last lesson, variables behave as real life boxes, in which
objects are stored into them for later use. In most languages, variables are treated
much like these objects, storing different types of information, such as numbers, text, and much more.

This is when the concept of Data Types comes in. Data is just another word for information, 
and information comes in many different shapes and sizes. The first data types you are going to be
introduced to are:

- Strings
- Integers
- Doubles

There are many other Data Types in C#, but those will be introduced later, in a more suitable occasion.

In a nutshell:

- Strings are characters, words, sentences, or any kind of text.
- Integers are positive or negative whole numbers.
- Doubles are numbers that contain a decimal point (i.e. 2.5).

In real life, when you need a box, you must know what you want to store in it. If you need to
put in a pair of shoes, you need a shoe box. If you need to pit in a hat, you need a hat box.
In programming, things work very similarly. In order to create a variable, you must know
what is going to be stored in that variable in advance. If you need a variable to store text,
you need a variable of the "string" type. If you need to store numbers, you will need either an
integer variable or a double variable. Let's code an example.

You can copy and paste the lines below into your IDE of choice to see how this code works.
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Suppose you want to code an application that shows your name on the console.
            //Your name is a string, so we need to declare a string variable.
            string name;

            //Notice how every line of code ends with a semi-colon ";". Never forget that!

            //Now that our variable is created, let's assign a value to it.
            name = "Luiz";

            //Now we can use the WriteLine method to print the name to the Console.
            Console.WriteLine(name);

            //Now, we want to make our application more user friendly, so we may enhance our code a bit.
            Console.WriteLine("Hello, " + name + "!");

            //Hopefully you remember our last lesson. There are more elegant ways of displaying strings and variables together.
            Console.WriteLine("Hey, {0}, how are you?", name);
        }
    }
}

/*
EXPLORATION EXERCISES:

1) Make a console application that prompts the user for their name, and welcomes them with a warm greeting.

2) Make a console application that prompts the user for their name and age, and then prints it on the screen.

3) Make a console application that asks the user for the name of their home town. Then, print a message containing
a compliment to that town (i.e. Toronto is a beautiful place!).

*/
