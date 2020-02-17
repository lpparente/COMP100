# Bootstrapping C#

## Module 2

### Lesson 8 - If Statements

There are times when coding an application that not all lines of code are meant to run every time. When that is the case, the application has only one very limited purpose.

We want to strive beyond that, don't we?

This lesson will teach you how to write smarter code, in the sense that it will be able to make decisions based on specific conditions. This is called a Control Structure, meaning that a set of instructions will be performed in case a condition is satisfied.

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

Programming languages have something called "if statements", that will do something **IF** some condition is met.

- **IF** user's age is greater than or equal to 16, then they are allowed to apply for a license.
- **IF** user's age is lower than 16, then they are not allowed to drive.

In order to achieve that, we have to be familiar with comparison operators:
- Greater than ```>``` and greater than or equal to ```>=```.
- Lower than ```<``` and lower than or equal to ```>=```.
- Equals ```==```.
- Different ```!=```.

Let's put it in terms of C#:

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

The condition that is determined within round brackets () is a ```boolean```. It can be either ```true``` or ```false``` - and nothing else.
            
These conditions are, in very simple terms, a comparison (hence the name, comparison operators). In the last example, we are comparing the variable wheels with the number 2 and 3. 

Mind you that the "equal to" condition defined in the round brackets () of our if statements contain two equal signs ==. This is because, in programming, one single equal sign is an assignment operator. The equivalent comparison operator is ```==```.

There is a big difference:

- ```a = 10``` : Assigns the value ```10``` to the variable ```a```.
- ```a == 10```: Compares the number ```10``` with the variable ```a```. This statement returns a ```bool```.

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

3) Write a console application that prompts the user for their sex. If the answer is "male", display the message "Hello, sir.".
If the answer is "female", display the message "Hello, madam.".

*****

### Lesson 9 - Else Statement

Virtually every program can be developed only by using if statements for flow control. However, there are other statements that can be used not only to save time, but also make our lives a lot easier.

Think of a problem that could have 50 possible inputs, but 40 of them would have to follow the same procedure, regardless. If everything you know to solve this problem is if statements, then you would have to write 50 if-blocks. That takes a lot of time, apart from not being very professional. Here is where the else statement comes in handy.

Else statements are to be used when more than one alternative is possible to handle the information the application is working with.

Basically, it works as follows:

- IF some condition is met -> Do this.
- OR ELSE -> Do that.

As an example, we want to write a code that checks if the user is old enough to drive a car.

```csharp
// We prompt the user for their age:
Console.WriteLine("Please enter your age: ");

// And store their answer into a numeric variable:
int age = Convert.ToInt32(Console.ReadLine());
```

Again, there are only two scenarios in this context:
            
1. The user is either 16 years old or older. This alternative comprises all numbers greater than or equal to 16.
2. OR ELSE, the user has whatever other age. This alternative comprises all other possible values. There is no other alternative after this one!

Let's put it into C#:

```csharp
// If the following condition is true...
if (age >= 16)
{
    // Do this:
    Console.WriteLine("You can apply for a driver's license!");
}

// The previous "if (age < 16)", from last lesson, is replaced with:
else
{
    // Or else, do this:
    Console.WriteLine("Unfortunately you are not old enough to drive.");
}
```

Not only that is a much simpler statement, but it also helps is cover a whole range without having to specify further details.

Let's see a more complex example. Let's write an application to determine if the user is allowed to watch a movie that is classified as 18+.

```csharp
// Prompting the user for their age and storing the input in a variable:
Console.WriteLine("You must be older than 18 years old to watch this movie. How old are you? ");
int userAge = Convert.ToInt32(Console.ReadLine());

// User's input could have a number of possible answers, from 1 to over 100.
// By using If and Else, we can narrow it down to only two possible paths:

if (userAge >= 18)
{
    Console.WriteLine("You can watch this movie!");
}

else
{
    Console.WriteLine("You are not allowed to watch this movie.");
}
```

There are times in which the else statement can be segmented into different sub-paths. Let's try a code that gives a customer a discount based on the total price of their purchase. Amounts greater than $100 get a 10% discount. However, amounts greater than $150 get 15% discount.

In order to easily understand this problem, we must be familiar with the concept of nested if's. It means having one if inside of the other. 

This is how it works:

```csharp
// Prompt for an input:
Console.WriteLine("Please input the total amount of your purchase: ");
double price = Convert.ToDouble(Console.ReadLine());

// The discount exists IF the purchase price is greater than $100.
if (price > 100)
{
    // OK, the purchase price is greater than 100. But is it lower than 150?
    if (price < 150)
    {
        // If so, the discount is 10%:
        Console.WriteLine("This purchase is elligible for 10% discount!");
    }

    // Or else, any value greater than 150 is elligible for 15% discount.
    else
    {
        Console.WriteLine("This purchase is elligible for 15% discount!");
    }

}
```

Obviously, there are better ways of writing this code, but let's keep that as is, for the sake of the exercise. Nested if's are often used, but the drawback is that they may be harder to read and be clearly understood. Let's try a more elegant code to solve the same problem:

```csharp
// Prompt for an input:
Console.WriteLine("Please input the total amount of your purchase: ");
double totalPrice = Convert.ToDouble(Console.ReadLine());

// There are 99 values between $0 and $99 that get no discount. Only one If statement covers them all.
if (totalPrice <= 99)
{
    Console.WriteLine("Unfortunately your purchase value is not elligible for a discount.");
}

// OR ELSE, any value greather than or equal to $100 is elligible for a discount.
// Now, the value could be either below $150, or greater than $150.

// We must cover these alternatives one by one. Let's cover the first one:
else if (totalPrice < 150)
{
    Console.WriteLine("This purchase is elligible for 10% discount!");
}

// And now we cover the only remaining one:
else
{
    Console.WriteLine("This purchase is elligible for 15% discount!");
}
```

**Quick note:** You don't always have to work with else and else if statements. Just use your best judgement and do whatever is best for the problem you are tring to solve.

As you can see, else and else if statements enrich our code, allowing us to be more efficient programmers. If you were able to understand if statements easily, you probably noticed that there is not a lot of difference between the two. However, it may need some practice to fully understand the whole concept.

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

            else
            {
                Console.WriteLine("Unfortunately you are not old enough to drive.");
            }

            Console.WriteLine("You must be older than 18 years old to watch this movie. How old are you? ");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("You can watch this movie!");
            }

            else
            {
                Console.WriteLine("You are not allowed to watch this movie.");
            }

            Console.WriteLine("Please input the total amount of your purchase: ");
            double price = Convert.ToDouble(Console.ReadLine());

            if (price > 100)
            {
                if (price < 150)
                {
                    Console.WriteLine("This purchase is elligible for 10% discount!");
                }

                else
                {
                    Console.WriteLine("This purchase is elligible for 15% discount!");
                }
            }

            Console.WriteLine("Please input the total amount of your purchase: ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            if (totalPrice < 99)
            {
                Console.WriteLine("Unfortunately your purchase value is not elligible for a discount.");
            }

            else if (totalPrice < 150)
            {
                Console.WriteLine("This purchase is elligible for 10% discount!");
            }

            else
            {
                Console.WriteLine("This purchase is elligible for 15% discount!");
            }
        }
    }
}
```

#### EXPLORATION EXERCISES:

Give it another go on the exercises from last time, now using else and else if statements.

1) Write a program that prompts the user for the current ambient temperature. If the temperature is lower than 20 degrees,
display the message "Too cold!". If the temperature is equal to 20, display the message "Good temperature.". If the
temperature is higher than 20 degrees, display the message "Too warm!".

2) Write a program that prompts the user for how many liters of water they drink per day. If the answer is lower than 2 liters,
display the message "You should drink more water!". If the answer is greater than or equal to 2 liters, display the message "Good!".

3) Write a console application that prompts the user for their gender. If the answer is "male", display the 
message "Hello, sir.". If the answer is "female", display the message "Hello, madam.".

*****

### Lesson 10 - Switch Statement

If and else statements are powerful tools for flow control in programming languages. However, when it comes to a more complex code, with a lot of possible paths, things may get a little harder to read. 

For this reason, simple structures with many possible paths may have its readability improved by the use of switch statements.

Switch statements work very similarly to if and else statements. The difference is that they are simpler and a bit less powerful, yet
very useful for flow control.

Let's start with a simple example from a previous lesson. We want to write a code that checks if the user has a bicycle or a tricicle.

```csharp
// Prompt the user for the number of wheels:
Console.WriteLine("Please input the number of wheels your bike has: ");

// Store the input in a numberic variable:
int wheels = Convert.ToInt32(Console.ReadLine());
```

The Switch statement works with CASES. IN CASE something happens, do this. IN CASE something else, do that.

```csharp
// The variable inside round brackets () is the one that will be checked.
switch(wheels)
{
    // IN CASE the value is 2, then:
    case 2:
        Console.WriteLine("You have a bicycle.");
        // A Break statement must be used to tell the computer that this code block has ended.
        break;

    case 3:
        Console.WriteLine("You have a tricicle.");
        break;
    
    // Now, what if the user inputs 4? Or 5? Or a letter?
    // Switch statements handle this type of error easily. The Default statement comprises the code block
    // that will be executed for every other case that is not the ones written above. Much like an Else statement.
    
    default:
        Console.WriteLine("ERROR: Invalid input!");
        break;
}
```

You may have noticed how the code became simple and clearer. That is the advantage of switch statements.

Switch statements can also be used to check the value of an expression. But in order to do that, you must remember what a ```bool``` data type is. Do you?

Booleans are variables that can only hold the values ```true``` or ```false```. These are not strings, but computational values that determine whether a condition is true or false.

Let's take a look at an example from our previous lesson. We want to write a code that checks if the user is old enough to drive a car.

```csharp
// We start our code:
Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
```

There are two possible cases: The user is either 16 or older, or younger than 16 years of age.

```csharp
// Is the user 16 or older?
switch(age >= 16)
{
    // IN CASE they are (age >= 16 is true):
    case true:
        Console.WriteLine("You can apply for a driver's license.");
        break;

    // IN CASE they are not (age >= 16 is false):
    case false:
        Console.WriteLine("You are not allowed to drive at this moment.");
        break;

    // What if the user mistakenly inputs a letter? The Default statement handles that error.
    default:
        Console.WriteLine("ERROR: Invalid input!");
        break;
}
```

This is not good code, and in real life, you will never find this kind of thing. But it is here, so you know it is possible.

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of wheels your bike has: ");
            int wheels = Convert.ToInt32(Console.ReadLine());

            switch(wheels)
            {
                case 2:
                    Console.WriteLine("You have a bicycle.");
                    break;

                case 3:
                    Console.WriteLine("You have a tricicle.");
                    break;
                
                default:
                    Console.WriteLine("ERROR: Invalid input!");
                    break;
            }

            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            switch(age >= 16)
            {
                case true:
                    Console.WriteLine("You can apply for a driver's license.");
                    break;

                case false:
                    Console.WriteLine("You are not allowed to drive at this moment.");
                    break;

                default:
                    Console.WriteLine("ERROR: Invalid input!");
                    break;
            }
        }
    }
}
```

If statements may or may not have an Else statement, that is, Else's are not mandatory. Switch statements, however, must have a Default statement. This is mandatory.

Switch statements are very simple. Make sure to practice in order to get comfortable with how they work!

#### EXPLORATION EXERCISES:

Retry the exercises from last time, now using else and else if statements.

1) Write a program that prompts the user for the current ambient temperature. If the temperature is lower than or equal to 20 degrees, display the message "Too cold!". If the temperature is higher than 20 degrees, display the message "Too warm!".

2) Write a program that prompts the user for how many liters of water they drink per day. If the answer is lower than 2 liters, display the message "You should drink more water!". If the answer is greater than or equal to 2 liters, display the message "Good!".

3) Write a console application that prompts the user for their gender. If the answer is "male", display the message "Hello, sir.". If the answer is "female", display the message "Hello, madam.".

*****

### Congratulations!

This is the end of Module 2. Congratulations for making it this far!

Before moving to the next Module, make sure that every concept covered up to this point is really under your fingers. Things will start to get more challenging from now on, but I'm sure you're prepared!
