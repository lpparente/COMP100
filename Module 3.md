# Bootstrapping C#

## Module 3

### Lesson 11 - Do While (011_Do_While.cs)

Iteration is another one of the main tasks in computer programming. Iteration means "looping", the act of doing something repeatedly for a certain number of times. It is quite useful in software development, as we are about to see in this lesson.

There are several different types of looping elements, all of which will be covered in this section. The first one, and perhaps the simplest, is the Do While loop. It has a very simple structure. The basic concept is: 

- **DO** something **WHILE** a condition is true.

Let's try a simple example. Say you need to make an application that counts from 0 to 50. It is a lot of work to do ```Console.WriteLine()``` fifty times. Instead, you could reduce it to just a handful of lines by using the Do While loop.

Here is what it looks like:

```csharp
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
```

This is all there is to it. If you run this code, you will see 51 lines containing all numbers from 0 to 50.

All other statements that were covered in other lessons can also be incorporated in Do While loops. For instance, let's try and write a code that will print all even numbers from 1 to 50.

```csharp
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
```

Ready for a more complex example?

Let's write a code that prints even numbers normally, but prints an asterisk * right after every odd number. The range of numbers to be printed is 1 to 50.

```csharp
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
```

```variable++``` is just another way of writing ```variable = variable + 1```. It's nothing but a nice shortcut!

As we advance, things start to get a little more complicated. No need to panic! Go over and over again through each lesson until you feel comfortable with every statement, and don't forget to practice the exercises!

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                Console.WriteLine(counter);

                counter = counter + 1;
            }
            while (counter <= 50);


            int newCounter = 1;

            do
            {
                if (newCounter % 2 == 0)
                {
                    Console.WriteLine(newCounter);
                }
                newCounter = newCounter + 1;
            }
            while (newCounter <= 50);


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

                lastCounter++;
            }
            while (lastCounter <= 50);
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) Write a program that prints all multiples of 7 from 0 to 100.

2) Write a program that displays the sum of all numbers from 0 to 100.

3) Write a program that prompts the user for a number. The program must return the factorial of this number.
Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.

*****

### Lesson 12 - For Statement (012_For_Statement.cs)

Basically, there are two types of loops. The Do-While loop that we covered in the last lesson is destined to applications
in which you do not know exactly the number of iterations (loops) that is going to be done by the program, that is, the block
of code within the loop will be repeated for an unknown number of times.

However, there are times in which you want a repeating block of code to run for an specific number of times. For those
situations, C# has the For loop.

Similarly to the Do-While loop, For loops also make use of counter variables. Although, the structure is a little different. When writing a For statement, there are three parameters that must be declared with it. Let's call them a, b and c.

- a is the number in which the counter starts;
- b is the number up to which the counter must go to;
- c is the step in which the counter increases.

Let's take a look at an example. If we wanted to use a For loop to make a code that counts from 1 to 5, here is what it would look like:

```csharp
/ Declaring counters.
int counter;

// The counter variable is declared inside as a parameter.
// It starts at 1, and goes up to 5, increasing 1 unit at a time.
for (counter = 1; counter <= 5; counter = counter + 1)
{
    Console.WriteLine(counter);
}
```

As you may have noticed, there is very little difference in the syntax we used in the last lesson for the Do-While statement. Let's see another example. Say we want to print on the screen all numbers from 1 to 10, but placing an asterisk in the even numbers.

```csharp
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
```

This is all there is to it. The statement itself is very simple, but it takes a little practice to memorize the mechanics of it. Don't forget to give it a go on the exploration exercises and get the For statement under your fingers, as they are very popular and very important in the daily life of a programmer.

By the end of this lesson, this is what your code should look like:

```csharp
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
```

#### EXPLORATION EXERCISES:

1) Write a program that prints all multiples of 7 from 0 to 100.

2) Write a program that displays the sum of all numbers from 0 to 100.

3) Write a program that prompts the user for a number. The program must return the factorial of this number.
Remark: Factorial of 5 = 5! = 5 * 4 * 3 * 2 * 1.

*****

