/*
Virtually every program can be developed only by using if statements for flow control.

However, there are other statements that can be used not only to save time, but also make our lives easier
as programmers.

Think of a problem that could have 50 possible inputs, but 40 of them would have to follow the same procedure, regardless.
If everything you know to solve this problem are if statements, then you would have to write 50 if code blocks.
That takes a lot of time, apart from not being professional nor elegant. Here is where the "else statement" comes in.

Else statements are to be used when more than one alternative is possible to handle the information the application is working with.

Basically, it works as follows:

IF some condition is met -> Do this.
OR ELSE -> Do that.

You can copy and paste the lines below into your IDE of choice to see how this code works.
*/

using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // As an example, we want to write again a code that checks if the user is old enough to drive a car.

            // We prompt the user for their age:
            Console.WriteLine("Please enter your age: ");

            // And store their answer into a numeric variable:
            int age = Convert.ToInt32(Console.ReadLine());

            /*
            Again, there are only two scenarios in this context:
            
            1. The user is either 16 years old or older. This alternative comprises all numbers greater than or equal to 16.
            2. OR ELSE, the user has whatever other age. This alternative comprises all other possible values.
            
            There is no other alternative!
            */

            // Let's put it into C#:
            if (age >= 16)
            {
                Console.WriteLine("You can apply for a driver's license!");
            }

            // The previous "if (age < 16)" is replaced with:
            else
            {
                Console.WriteLine("Unfortunately you are not old enough to drive.");
            }

            // Not only that is a much simpler statement, but it also helps is cover a whole range without having
            // to specify further details.

            // Let's see a more complex example.

            // Write an application to determine if the user is allowed to watch a movie that is classified as 18+.

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

            /*
            There are times in which the Else statement can be segmented into different sub-paths.

            Let's try a code that gives a customer a discount based on the total price of their purchase.
            Amounts greater than $100 get a 10% discount. However, amounts greater than $150 get 15% discount.

            In order to easily understand this problem, we must be familiar with the concept of Nested If's.
            It means having one If inside another If. This is how it works:
            */

            // Prompt for an input:
            Console.WriteLine("Please input the total amount of your purchase: ");
            double price = Convert.ToDouble(Console.ReadLine());

            // Values greater than or equal to $100 are elligible for a discount. However, we must cover two alternatives!
            // After checking IF the value is greater than $100, we must know IF it is also greater than $150.
            if (price > 100)
            {
                // Values between 100 and 150 are elligible for 10% discount.
                if (price < 150)
                {
                    Console.WriteLine("This purchase is elligible for 10% discount!");
                }

                // Any other value greater than 150 is elligible for 15% discount.
                else
                {
                    Console.WriteLine("This purchase is elligible for 15% discount!");
                }

            }

            // Nested If's are often used, but the drawback is that they may be harder to read and be clearly understood.

            // Let's try a more elegant code to solve the same problem:

            // Prompt for an input:
            Console.WriteLine("Please input the total amount of your purchase: ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            // There are 99 values between $0 and $99 that get no discount. Only one If statement covers them all.
            if (totalPrice < 99)
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

            /*
            Quick note: You don't always have to work with Else and/or Else If statements.
            However, some rules must always be followed:

            - Else's or Else If's are not always needed.
            - Else's must always come after If's.
            - When Else If's are used, there MUST BE a last Else to close the block. Otherwise an error will occur.
            
            As you can see, Else and Else If statements enrich our code, allowing us to be more efficient programmers.

            If you were able to easily understand the If statement, you probably noticed that there is not much
            difference in the syntax. However, it may need some practice for the concept to be fully grasped.
            */
        }
    }
}

/*
EXPLORATION EXERCISES:

Retry the exercises from last time, now using else and else if statements.

1) Write a program that prompts the user for the current ambient temperature. If the temperature is lower than 20 degrees,
display the message "Too cold!". If the temperature is equal to 20, display the message "Good temperature.". If the
temperature is higher than 20 degrees, display the message "Too warm!".

2) Write a program that prompts the user for how many liters of water they drink per day. If the answer is lower than 2 liters,
display the message "You should drink more water!". If the answer is greater than or equal to 2 liters, display the message "Good!".

3) Write a console application that prompts the user for their gender. If the answer is "male", display the 
message "Hello, sir.". If the answer is "female", display the message "Hello, madam.".
*/
