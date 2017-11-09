/*
The Do-While statement from the previous lesson was quite simple, wasn't it? Now, we can make it even simpler. It can be reduced to
a simple While statement, and in that case, it will have the following philosophy:

- WHILE (something is true), repeat this code.

And then, the block of code inside the While statement will run as many times as needed, until the defined condition is true.

Let's take a look at an example. Say we want to write a code that counts from 1 to 5.
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declaring counters.
            int counter = 1;

            // While counter is less than or equal to 5...
            while (counter <= 5)
            {
                // ... Do this.
                Console.WriteLine(counter);

                counter++;
            }

            /*
            As you may have noticed, there is very little difference in the syntax we used in the last lesson for the Do-While statement.

            Let's see another example. Say we want to print on the screen all numbers from 1 to 10, but placing an asterisk in the even numbers.            
            */
            int i = 1;

            while (i <= 50)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} *", i);
                }

                else
                {
                    Console.WriteLine(i);
                }

                i++;
            }

            /*
            You may be asking yourself what is the difference between Do-While and While. It's simple:

            - Do-While statements will run first, and then again if the condition is true. It means they will always run at least once.
            - While statements will check the condition first, and will only run if the condition is true. It means they may not be run at all
            depending on the situation.

            Hopefully you had no worries with the previous Do-While lesson, and now the While is even simpler! Don't forget to check
            the exploration exercises to make sure you understand the concepts of looping structures before continuing with the course.
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
