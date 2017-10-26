/*
If and Else statements are powerful tools for flow control in most programming languages. However, when it comes to
a more complex code, with a lot of possible paths, it may become a little harder to read. 

For this reason, simple structures with many possible paths may have its readability improved by the use of Switch statements.

Switch statements work very similarly to If and Else statements. The difference is that they are simpler and less powerful, yet
very useful for flow control.

You can copy and paste the lines below into your IDE of choice to see how this code works.
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Let's start with a simple example from a previous lesson. 
            // We want to write a code that checks if the user has a bicycle or a tricicle.

            // Prompt the user for the number of wheels:
            Console.WriteLine("Please input the number of wheels your bike has: ");

            // Store the input in a numberic variable:
            int wheels = Convert.ToInt32(Console.ReadLine());

            // The Switch statement works with CASES. IN CASE something happens, do this. IN CASE something else, do that.

            switch(wheels)
            // The variable inside round brackets () is the one that will be checked.
            {
                case 2:
                    // IN CASE the value is 2, then:
                    Console.WriteLine("You have a bicycle.");
                    // The Break statement must be used to tell the computer that this code block has ended.
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

            // You may have noticed how the code became simple and clearer. That is the advantage of Switch statements.

            /*
            Switch statements can also be used to check the value of an expression. But in order to do that, you must 
            remember what a bool Data Type is. Do you?

            Bool's are variables that can only hold the values 'true' or 'false'. These are not strings, but
            computational values that determine whether a condition is truth or false.

            Let's take a look at an example from our previous lesson.
            */

            // We want to write a code that checks if the user is old enough to drive a car.

            // We start our code:
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // There are two possible cases: The user is either 16 or older, or younger than 16 years of age.

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

            // If statements may or may not have an Else statement, that is, Else's are not mandatory.
            // Switch statements, however, must have a Default statement. This is mandatory.

            // Switch statements are very simple. Make sure to practice in order to get comfortable with how they work!
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
