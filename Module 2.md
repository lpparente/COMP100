# C# in a Nutshell

## Module 2

### Lesson 8 - If Statement (008_If_Statement.cs)

There are times when coding an application that not all lines of code are meant to run every time. When that is the case, the application has only one very limited purpose.

We want to strive beyond that, don't we?

This lesson will teach you how to code a smarter code, in the sense that it will be able to make decisions based on specific conditions. This is called a Control Structure, meaning that a set of instructions will be performed in case a condition is satisfied.

As an example, let's write a code that checks if the user is old enough to drive a car.

```csharp
// We prompt the user for their age:
Console.WriteLine("Please enter your age: ");

// And store their answer into a numeric variable:
int age = Convert.ToInt32(Console.ReadLine());
```

Now, there are only two scenarios in this context:

1. The user is 16 years old or older;
2. The user is less than 16 years old.

There is no other alternative!

Most programming languages will have a statement called "if", that will do something **IF** some condition is met.

- **IF** user's age is greater than or equal to 16, then they are allowed to apply for a license.
- **IF** user's age is lower than 16, then they are not allowed to drive.

Let's put it into C#:

```csharp
// IF age is greater than or equal to 16...
if (age >= 16)
{
    // Do this:
    Console.WriteLine("You can apply for a driver's license!");
}

// If age is less than 16...
if (age < 16)
{
    // Do this:
    Console.WriteLine("Unfortunately you are not old enough to drive.");
}
```

The "if" statement has two sections:

- The first one is delimited with round brackets ();
- The second one is delimited by curly brackets {}.

Into the round brackets (), we must insert the condition that is being checked for, in our example: age is greater than or equal to 16.

Into the curly brackets {}, we delimit the block of code that will be executed **IF, and only if,** that condition is true. 

Let's try another example. We want to write a code that checks if the user has a bicycle or a tricicle.

```csharp
// Prompt the user for the number of wheels:
Console.WriteLine("Please input the number of wheels your bike has: ");

// Store the input in a numberic variable:
int wheels = Convert.ToInt32(Console.ReadLine());

// IF the bike has 2 wheels, it is a bicycle. IF it has 3, it is a tricycle.

// Is the following statement true or false?
if (wheels == 2)
{
    // If true, do this:
    Console.WriteLine("You have a bicycle!");
}

// Or is the following true or false?
if (wheels == 3)
{
    // If true, do this:
    Console.WriteLine("You have a tricycle!");
}
```

The condition that is determined within round brackets () is a boolean. It can be either true or false.
            
These conditions are, in very simple terms, a comparison. In the last example, we are comparing the variable wheels with the number 2 and 3. In order to do comparisons, we must use comparison operators, just as we are used to do in mathematics. They are:

- Greater than (>);
- Equal to (==);
- Lower than (<).

The "equal to" comparison operator is the only one that may appear alone, or along with one of the others:

- Greater than or equal to (>=);
- Lower than or equal to (<=).

Mind you that the "equal to" condition defined in the round brackets () of our if statements contain two equal signs ==. This is because, in programming, one single equal sign is a definition operator. The equivalent comparison operator is ==.

There is a big difference:

- ```a = 10``` : Assigns the value 10 to the variable a.
- ```a == 10```: Compares the number 10 with the variable a. This statement can be either true or false.

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 16)
            {
                Console.WriteLine("You can apply for a driver's license!");
            }

            if (age < 16)
            {
                Console.WriteLine("Unfortunately you are not old enough to drive.");
            }

            Console.WriteLine("Please input the number of wheels your bike has: ");

            int wheels = Convert.ToInt32(Console.ReadLine());

            if (wheels == 2)
            {
                Console.WriteLine("You have a bicycle!");
            }

            if (wheels == 3)
            {
                Console.WriteLine("You have a tricycle!");
            }
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) Write a program that prompts the user for the current ambient temperature. If the temperature is lower than 20 degrees,
display the message "Too cold!". If the temperature is equal to 20, display the message "Good temperature.". If the
temperature is higher than 20 degrees, display the message "Too warm!".

2) Write a program that prompts the user for how many liters of water they drink per day. If the answer is lower than 2 liters,
display the message "You should drink more water!". If the answer is higher than 2 liters, display the message "Good!".

3) Write a console application that prompts the user for their gender. If the answer is "male", display the message "Hello, sir.".
If the answer is "female", display the message "Hello, madam.".

*****

