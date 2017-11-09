/*
Basically, there are two types of loops. The Do-While loop that we covered in the last lesson is destined to applications
in which you do not know exactly the number of iterations (loops) that is going to be done by the program, that is, the block
of code within the loop will be repeated for an unknown number of times.

However, there are times in which you want a repeating block of code to run for an specific number of times. For those
situations, C# has the For loop.

Similarly to the Do-While loop, For loops also make use of counter variables. Although, the structure is a little different.

When writing a For statement, there are three parameters that must be declared with it. Let's call them a, b and c.

- a is the number in which the counter starts;
- b is the number up to which the counter must go to;
- c is the step in which the counter increases.

Let's take a look at an example. If we wanted to use a For loop to make a code that counts from 1 to 5, here is what it 
would look like:
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declaring counters.
            int counter;

            // The counter variable is declared inside as a parameter.
            // It starts at 1, and goes up to 5, increasing 1 unit at a time.
            for (counter = 1; counter <= 5; counter = counter + 1)
            {
                Console.WriteLine(counter);
            }

            /*
            As you may have noticed, there is very little difference in the syntax we used in the last lesson for the Do-While statement.

            Let's see another example. Say we want to print on the screen all numbers from 1 to 10, but placing an asterisk in the even numbers.            
            */

            // Let's get elegant and declare the counter inside the statement.
            // The loop starts on 1, goes up to 50, one by one.
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} *", i);
                }

                else
                {
                    Console.WriteLine(i);
                }
            }

            /*
            This is all there is to it. The statement itself is very simple, but it takes a little practice to memorize the 
            mechanics of it. Don't forget to give it a go on the exploration exercises and get the For statement under your
            fingers, as they are very popular and very important in the daily life of a programmer.
            */
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