/*
Iteration is another one of the main tasks in computer programming. Iteration means "looping", the act of doing
something repeatedly for a certain number of times. It is quite useful in software development, as we are about to
see in this lesson.

There are several different types of looping elements, all of which will be covered in this section. The first one,
and perhaps the simplest, is the Do While loop.

You can copy and paste the lines below into your IDE of choice to see how this code works.
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // The Do While loop has a very simple structure. The basic concept is: DO something WHILE a condition is true.

            // Let's try a simple example.
            // Say you need to make an application that counts from 0 to 50. It is a lot of work to do Console.WriteLine()
            // fifty times. Instead, you could reduce it to just a handful of lines by using the Do While loop.
            // Here is what it looks like:

            // First of all, we need something to count the number of times a number will be printed on the screen.
            // We create a counter element, and its initial value is zero. Zero is also the first value to be printed.
            int counter = 0;

            do
            {
                Console.WriteLine(counter);

                // After the counter number is printed on the screen, we need to add one to itself, in order to get the next number.
                counter = counter + 1;
            }
            // The whole code block inside the Do statement will run repeatedly, until we stablish when to stop.
            // We must state that this block must run WHILE some condition is met. In this case, WHILE counter <= 50.
            while (counter <= 50);

            // This is all there is to it. If you run this code, you will see 51 lines containing all numbers from 0 to 50.

            // All other statements that were covered in other lessons can also be incorporated in Do While loops.

            // For instance, let's try and write a code that will print all even numbers from 1 to 50.

            // Let's create another counter. This time, our count starts at 1.
            int newCounter = 1;

            do
            {
                // IF the counter has an even number, display it.
                // A number is even if the remainder of its division by 2 equals 0.
                if (newCounter % 2 == 0)
                {
                    Console.WriteLine(newCounter);
                }

                // Never forget to add 1 to your counter!
                newCounter = newCounter + 1;

                // In this case, there are no instructions to be done for odd numbers. So, no else is required.
            }
            // We repeat this code block WHILE our counter is smaller than or equal to 50.
            while (newCounter <= 50);

            // Ready for a more complex example?

            // Let's write a code that prints even numbers normally, but prints an asterisk * right after every odd number.
            // The range of numbers to be printed are 1 to 50.

            int lastCounter = 1;

            do
            {
                if (lastCounter % 2 == 0)
                {
                    Console.WriteLine(lastCounter);
                }

                else
                {
                    Console.WriteLine("{0} *", lastCounter);
                }

                // This is another way to add 1 to your counter:
                lastCounter++;
            }
            while (lastCounter <= 50);

            // As we advance, things start to get a little more complicated. No need to panic! Go over and over again through
            // each session until you feel comfortable with each statement, and practice the exercises at the end of every lesson.
        }
    }
}

/*
EXPLORATION EXERCISES:

1) Write a program that prints all multiples of 7 from 0 to 100.

2) Write a program that displays the sum of all numbers from 0 to 100.

3) Write a program that prompts the user for a number. The program must return the factorial of this number.
Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.
*/
