/*
As we covered before, variables are like boxes, being used to store information, and Data Types are
all the different kinds of information that we can work with (strings, numbers, etc).

One of the most important skills in any programming language is knowing how to work with data. A good
programmer must be able to create and handle data at their own free will, doing whatever it takes
to make the application work. This lesson covers the tip of the iceberg of what it is.

One quick and fun way to understand this is by using C# to perform basic mathematical operations. The
following lines will do just that.

You can copy and paste the lines below into your IDE of choice to see how this code works.
*/

using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Suppose we have two integers, listed below.
            int a = 10;
            int b = 15;

            // See how we declared each variable and assigned a value to it on the same line?
            // That is not only cool, but saves a lot of time!

            // We can create new variables to store the result of arithmetical operations of a and b.

            int result = a + b;

            // Remember how we print things on the Console?
            Console.WriteLine(result);

            // And here is another way to do just the same thing:
            Console.WriteLine(a + b);

            /*
            There are five basic operations in programming:

            - Addition: By using the operator "+".
            - Subtraction: By using the operator "-".
            - Multiplication: By using the operator "*".
            - Division: By using the operator "/".
            - Modulus: Returns the remainder of a division by the use of the operator "%".
            */

            // Now, let's write a code that prompts the user for two numbers, and then multiplies them.
            // Let's work with doubles this time.

            Console.WriteLine("Please input the first number: ");
            double number1 = Console.ReadLine();

            Console.WriteLine("Please input the second number: ");
            double number2 = Console.ReadLine();

            /*
            Have you tried running the code block above (lines 53 to 58)? It returns an error!
            This is because, as we said before, EVERYTHING that is written by the user on the Console
            is a string! That is not right! If you but a shoe box, there is no way you're able to store
            a basketball inside it. Just as you need right boxes for different objects, you need right 
            variable types for different data types.

            That means, in order to make the code above work, we need to CONVERT the users input (which 
            are originally strings) into numbers. Here is how we do that:

            PS: If you are running this file on your IDE, you will see the errors will not let you run the code.
            Please delete or comment lines 54 to 58 in order to clear the code and make it runnable.
            */

            Console.WriteLine("Please input the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // We just learned another trick: How to convert strings into doubles. This is very useful!
            // But don't worry much about converting now. It will be better explained in the next lesson.
            // Now we continue our code and multiply them, showing the result to the user.

            Console.WriteLine(number1 * number2);

            /*
            Now, there are two mathematical operators that can also be used with strings. These are
            Addition "+" and Multiplication "*". however, they behave quite differently with strings.
            */

            string string1 = "Hello ";
            string string2 = "World!";

            string concatenation = string1 + string2;

            Console.WriteLine(concatenation);

            /* See how the code in line 91 prints a nice "Hello World!" in the Console?
            The operation that we just did is called CONCATENATION. It means just
            placing one string right beside another. 
            */
        }
    }
}

/*
EXPLORATION EXERCISES:

1) Make a console application that calculates the area of a square room that is 10 meters per 5.7 meters.

2) Make a console application that prompts the user for two numbers, and show the result of the division number1 / number2.

3) Make a console application that calculates the area of a circle. The radius must be given by the user.

*/
