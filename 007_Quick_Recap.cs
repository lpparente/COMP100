/*
Before we continue to the next lessons, it is highly recommended that you make sure that
you are comfortable with everything that have been covered so far.

So, let's do a quick recap.
*/

using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // The most common data types that we have worked with are:

            // Strings:
            string name = "Bob";

            // Integers:
            int age = 25;

            // Doubles:
            double bobsSalary = 2000.50;

            // We can ask Bob to input a name of one of his friends:
            Console.WriteLine("Bob, please enter a name of one of your friends: ");

            // And then store this number into a variable:
            string bobsFriend = Console.ReadLine();

            // Everything entered via Console is a STRING. So, if we prompt Bob for the number of hands he has:
            Console.WriteLine("Bob, please input the number of hands that you have: ");

            // We must convert the entered value to a number, so we can run mathematical operations with it.
            int bobsHands = Convert.ToInt32(Console.ReadLine());

            // Now this number is suitable for mathematics.
            int numberOfFingers = 5 * bobsHands;

            // After running our calculations, we can print the result on to the screen using a placeholder {0}.
            Console.WriteLine("Bob has {0} fingers.", numberOfFingers);

            // However, if no mathematics are needed, it is OK to keep numbers as strings.
            Console.WriteLine("Please enter your phone number: ");
            string phoneNumber = Console.ReadLine();

            // Bob is 25 years old. Is he allowed to drive?
            bool allowedToDrive = true;

            // Is he old enough to retire?
            bool retirementAge = false;

            // What is the first letter of Bob's name?
            char firstLetter = 'b';

            // Chars can also be numbers (if no mathematics is involved):
            char fingersPerHand = '5';

            // But if some mathematics comes up, we can convert between types, and the world is good again!
            int newFingersPerHand = (int)fingersPerHand;

            // And our quick recap was neatly commented, so you can come back here anytime for a quick check :)
        }
    }
}
