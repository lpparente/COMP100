/*
This lesson is going to cover a couple of very important C# tools that gives us more control over our code. These are the
Break and Continue statements.

They are generally used inside a looping structure, and this is what they do:

- Break: Stops the code in that particular line, jumping out of that block of code and resuming out of the loop.

- Continue: Immediately goes to the next iteraction of the loop.

These concepts might appear a little complex, but they'll make much more sense when we look an example. 
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Let's write a code that prints only odd numbers from 1 to 10.

            for (int counter = 1; counter <= 10; counter++)
            {
                if (counter % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(counter);
            }

            // What happened here is, once the compiler reaches the Continue statement, it jumps immediately to the beginning of
            // the next loop. Hence, whatever comes after the Continue statement will never be read by the compiler. 

            // Run the code below. Can you see the special warning being printed?

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                    Console.WriteLine("Special Warning: This line never gets printed!");
                }

                Console.WriteLine(i);
            }

            // Now let's try something different. Say we have two control variables, a and b.
            // We want to run a loop 100 times, but if a becomes greater than b at some point, the loop must stop.

            int a = 0;
            int b = 20;

            for (int i = 1; i <= 100; i++)
            {
                a++;

                if (a > b)
                {
                    Console.WriteLine("The loop has been broken!");
                    break;
                    Console.WriteLine("Will this message be printed?");
                }

                Console.WriteLine(a);
            }

            /*
            There are many situations in which these statements come in handy. Maybe new students struggle to actually see a 
            practical situation in which they can be used to solve a problem, but that's fine. There are a few things in life that
            you don't know you need it until you need it. Sounds obvious, but it couldn't be more true in this case.

            So, learn the Break and Continue statements, and remember you have them as an option. It won't be long until you use them.
            */
        }
    }
}