/*
We have already lerned that data comes in many different types. This lesson is going to cover
more on how to convert between different data types, and also introduce new Data Types.
*/

using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // These are the data types we were introduced so far:

            string name = "Bob";
            int age = 25;
            double pi = 3.14159;

            // We also know that we can do various operations with numbers, but
            // not all operations can be done with strings.

            // Console.WriteLine(name * pi) returns an ERROR!
            // Console.WriteLine(name + name) returns "BobBob".

            Console.WriteLine("How many wheels does a car have?");

            // When the user is prompted for an input, this input will get into the application
            // as a String. Always, everything that is typed into the Console is String!
            // If we intend to use this information for mathematical operations, we MUST convert
            // it to a suitable Data Type. the Convert.ToInt32() method will convert the input to an Integer.

            int wheels = Convert.ToInt32(Console.ReadLine());

            // How many wheels are there in a garage with 5 cars?

            Console.WriteLine("A garage with 5 cars has {0} wheels.", wheels * 5);

            // However, there are times in which the user's input is a number, but we will not
            // use it for any calculation. Sometimes this is just an information that will be displayed.

            Console.WriteLine("How many people are there in your family? ");
            string familyMembers = Console.ReadLine();

            // In this case, no conversion is needed!

            Console.WriteLine("Your family has {0} people.", familyMembers);

            // Different variables may contain the same value, but in different types:

            var value1 = 10;
            var value2 = "10";

            // value1 is different than value2! One is a number, the other is a string. Be careful!

            /*
            "var" is a keyword that can be used to declare new variables.
            Instead of using specific keywords, such as "string", "int", "double" (etc.) for different variables,
            you can just use "var", and C# will automatically detect which Data Type the new variable is.
            Be careful with its use!
            */

            // There are other important Data Types in C#: bool and char.

            bool variable1 = true;
            char variable2 = 'a';

            /*
            "bool" is a Data Type that can either be "true" or "false". No other value is permitted.
            It has many applications in the context of programming.
            "char" is a Data Type that is very similar to a string, but it only contains one character.
            The values stored in a char variable must contain single quotes ' ', and not douple quotes " " as strings.
            This is one way to differentiate strings from chars: chars have single quotes ' ', strings have double quotes " ".
            */

            /*
            As there are many different Data Types, it is important to know when and how to convert between types. It may be
            the only difference between a functional code and a non-functional code.

            We have already converted a few Data Types before, by using the Convert.To... method. This method can be used to
            convert between String and whatever the desired Data Type is.
            If you are converting from or to String, ALWAYS use Convert.To...
            */

            var newVariable1 = Convert.ToString(variable1);
            var newVariable2 = Convert.ToString(variable2);

            /*
            Not all conversions are accepted by C#. In order to convert between Data Types, we must make sure that the
            destination type accepts the value we want to assign to it.
            For example, if we have a string "Bob", we cannot convert this value to a number! Letters are not numbers!
            Another good example: We know that a boolean (bool) variable can only be "true" or "false". Again, we cannot
            convert a boolean variable to a number (neither int nor double)! Letters are not numbers!
            We can, however, convert bool to string. Text is text!
            */

            // Another quick method to do type conversion is by CASTING.
            // It can be done when converting between types that are not strings. It is very simple to do:

            double x = 1.23456;
            int y = (int)x;

            Console.WriteLine(y);
        }
    }
}

/*
EXPLORATION EXERCISES:

1) You are a programmer working for a census company. Write an application that prompts the user for the
number of TV's they have in their homes. If each TV costs $500, how much money has this person spent in TV's?
Your program must calculate and display the answer.

2) Write a program that prompts the user for their hourly pay and the number of hours worked in a month.
Calculate and display the salary for that month.

3) Make a console application that prompts the user for the first letter of their first name. Display a
friendly message with the letter (i.e. "L is my favorite word!").
*/
