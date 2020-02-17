# Bootstrapping C#

## Module 1

### Before we begin...

Please make sure to take a look at the [read me file](https://github.com/luizparente/CSharp/blob/master/README.md), as it contains important information for you to know before starting this couse.

Each lesson contains exercises for you to practice what you have just learned. Of course, solving them is optional, but it is a good idea to go through them to make sure that you are comfortable with what has just been covered.

Every new C# project is supposed to contain the following lines:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // C# magic happens here!
        }
    }
}
```

Your code starts in the "C# magic happens here!" mark. When you create a new C# project, make sure you type your lines in the right place!

Welcome to C#! I hope you enjoy this journey as much as I do!

***** 

### Lesson 1 - Hello World
As we are starting this course in a simple context, the Console will be used to both display outputs and gather inputs from the user. C#, and also most programming languages, have vast resources dedicated to interacting with the user via Console. Do not let yourself be fooled! Console applications can be very powerful - sometimes more than applications with fancy UI's!

"Hello World" is a classic introduction to programming languages. Due to its simplicity, it is easy to introduce basic concepts to the student, such as displaying information on the screen.

The ```WriteLine``` method, as the name suggests, inserts a line, displaying it on to the screen. It may contain text or numbers. As we want to display the message "Hello World!", which is a text string, double quotes "" must be used.

The code below is your first C# console application. You can copy and paste the lines below into your IDE and see how this code works.

```csharp
Console.WriteLine("Hello World!");
```

Just to make sure you understood where your code is supposed to go, here is what your .cs file should look like. Make sure it is exactly the same as below, so that you are able to run it properly!

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```

*****

### Lesson 2 - Input and Output

The Console is the medium through which information is gathered from and printed to, in order to interact with the user. In this context, the two most important actions are:

- Reading information given by the user,
- Displaying information to the user.

The methods for performing these actions are, respectively:

- ```Read()``` or ```ReadLine()```,
- ```Write()``` or ```WriteLine()```.

However, we always need to write our code in a language that the computer understands. In order to use the ```ReadLine()``` or ```WriteLine()``` methods, we must specify that we want to address these commands to the Console.

The example below uses both methods mentioned in order to make a console application that gathers an information from the user, and prints them afterwards.

In order to store information, variables must be created. Variables work as a "box" in which things are stored into. In the context of programming, these things are called data.

In order to use variables, they must always be created, or declared, before being put into use (similarly, you must first buy the box you need before putting things into it).

This is how we declare variables in C#:

```csharp
string firstName;
string lastName;
```

Note how the variables have been named. They follow a convention called camelCase. That is, it always starts with a lowercase letter, and has an uppercase letter for every new word. For example, thisWouldBeANiceVariableName.

To proceed with the code, the ```WriteLine()``` method is called in the Console. An information is requested.

```csharp
Console.WriteLine("Please input your first name: ");
```

The ```ReadLine()``` method is called. It allows us to store the information given by the user in a variable that was previously declared. This is the way to do it:

```csharp
firstName = Console.ReadLine();
```

Let's do it again and ask the user to input their last name.

```csharp
Console.WriteLine("Please input your last name: ");
lastName = Console.ReadLine();
```

There are a few ways of displaying the output. This is the simplest one:

```csharp
Console.WriteLine(firstName);
```

We can make it better and show both names using the "+" operator. The ```+``` sign, in this case, is used to concatenate strings:

```csharp
Console.WriteLine("Hello, " + firstName + " " + lastName);
```

Another way of displaying information is using placeholders.

Placeholders are curly brackets ```{}``` with a number (index) inside. This number represents the position of the variables placed after comma ",", identifying what is to be displayed in that position. Here is how it's done:

```csharp
Console.WriteLine(string.Format("Hello, {0} {1}!", firstName, lastName));
```

There is also another way to achieve the same result, which is by using interpolation. A dollar sign ```$``` signifies a string interpolation is happening, making the curly braces ```{ }``` mean something special:

```csharp
Console.WriteLine($"Hello, {firstName} {lastName}!");
```

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string firstName;
            string lastName;

            Console.WriteLine("Please input your first name: ");

            firstName = Console.ReadLine();

            Console.WriteLine("Please input your last name: ");
            lastName = Console.ReadLine();

            Console.WriteLine(firstName);
            
            Console.WriteLine("Hello, " + firstName);

            Console.WriteLine(string.Format("Hello, {0} {1}!", firstName, lastName));

            Console.WriteLine($"Hello, {firstName} {lastName}!");
        }
    }
}
```

*****

### Lesson 3 - Variables and Data Types

As mentioned in the last lesson, variables behave as real life boxes, in which objects are stored into them for later use. In most languages, variables are treated much like these objects, storing different types of information, such as numbers, text, and much more.

This is when the concept of Data Types comes in. Data is just another word for information, and information comes in many different shapes and sizes. The first data types you are going to be introduced to are:

- Strings
- Integers
- Doubles

There are many other Data Types in C#, but those will be introduced later, in a better occasion.

In a nutshell:

- Strings are characters, words, sentences, or any kind of text.
- Integers are positive or negative whole numbers.
- Doubles are numbers that contain a decimal point (i.e. 2.5).

In real life, when you need a box, you must first know what you want to store in it. If you need to store a pair of shoes, you need a shoe box. If you need to store a hat, you need a hat box. In programming, things work very similarly. In order to create a variable, you must know what is going to be stored in that variable. 

If you need a variable to store text, you need a variable of the ```string``` type. If you need to store numbers, you will need either an integer variable of type ```int```, or a floating point variable of type ```double```. Let's write an example.

Suppose you want to code an application that shows your name on the console. Your name is a piece of text, so we need to declare a ```string``` variable.

```csharp
string name;
```

Notice how every line of code ends with a semi-colon ";". Never forget that!

Now that our variable is created, let's assign a value to it.

```csharp
name = "Luiz";
```

Now we can use the ```WriteLine``` method to print the name to the Console.

```csharp
Console.WriteLine(name);
```

Now, we want to make our application more user friendly, so we may enhance our code a bit.

```csharp
Console.WriteLine("Hello, " + name + "!");
```

Alternatively, we can use interpolation as well. Hopefully you remember that from our last lesson.

```csharp
Console.WriteLine($"Hey, {name}, how are you?");
```

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;

            name = "Luiz";

            Console.WriteLine(name);

            Console.WriteLine("Hello, " + name + "!");

            Console.WriteLine($"Hey, {name}, how are you?");
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) Make a console application that prompts the user for their name, and welcomes them with a warm greeting.

2) Make a console application that prompts the user for their name and age, and then prints it on the screen.

3) Make a console application that asks the user for the name of their home town. Then, print a message containing
a compliment to that town (i.e. Toronto is a beautiful place!).

*****

### Lesson 4 - Operations With Variables

As we covered before, variables are like boxes, being used to store information, and data types are all the different kinds of information that we can work with (strings, numbers, etc).

One of the most important skills for any developer is knowing how to work with data. A good programmer must be able to create and handle data as necessary, doing whatever it takes to make the application work efficiently. This lesson covers the tip of the iceberg of what it is.

One quick and fun way to understand this is by using C# to perform basic mathematical operations. The following lines will do just that.

Suppose we have two integers, listed below.

```csharp
int a = 10;
int b = 15;
```

See how we declared each variable and assigned a value to it on the same line? That is not only cool, but saves a lot of time! By the way, the correct terminology for when you assign a value to a variable is "initialization".

We can create new variables to store the result of arithmetical operations of a and b.

```csharp
int result = a + b;
```

Remember how we print things on the Console?

```csharp
Console.WriteLine(result);
```

And here is another way to do just the same thing:

```csharp
Console.WriteLine(a + b);
```

There are five basic operations in programming:

- Addition: By using the operator "+".
- Subtraction: By using the operator "-".
- Multiplication: By using the operator "*".
- Division: By using the operator "/".
- Modulus: Returns the remainder of a division by the use of the operator "%".

Now, let's write a code that prompts the user for two numbers, and then multiplies them. Let's work with doubles this time.

```csharp
Console.WriteLine("Please input the first number: ");
double number1 = Console.ReadLine();

Console.WriteLine("Please input the second number: ");
double number2 = Console.ReadLine();
         
```

Have you tried running the code block above? **It gives us an error!**

This is because, as we said before, EVERYTHING that is written by the user on the Console is a string! If you buy a shoe box, there is no way you're able to store a basketball in it. Just as you need right boxes for different objects, you need right variable types for different data types.

That means, in order to make the code above work, we need to CONVERT the users input (which are originally strings) into numbers. Here is how we do that:

```csharp
Console.WriteLine("Please input the first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input the second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());
```

We just learned another trick: How to convert a ```string``` into a ```double```. This is very useful! But don't worry much about converting now. It will be better explained in the next lesson.

Now we continue our code and multiply these numbers, showing the result to the user.

```csharp
Console.WriteLine(number1 * number2);
```

The "+" sign, however, works very differently with strings. Since there is no way to sum strings, what it does, instead, is concatenate them.
 
```csharp
string string1 = "Hello ";
string string2 = "World!";

string concatenation = string1 + string2;

Console.WriteLine(concatenation);
```

The code above prints on the Console:

```csharp
Hello World!
```

The operation that we just did is called CONCATENATION. It means just placing one string right after another. 

By the end of this lesson, this is what your code should look like:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a = 10;
            int b = 15;

            int result = a + b;

            Console.WriteLine(result);

            Console.WriteLine(a + b);

            Console.WriteLine("Please input the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(number1 * number2);

            string string1 = "Hello ";
            string string2 = "World!";

            string concatenation = string1 + string2;

            Console.WriteLine(concatenation);
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) Make a console application that calculates the area of a square room that is 10 meters per 5.7 meters.

2) Make a console application that prompts the user for two numbers, and show the result of the division number1 / number2.

3) Make a console application that calculates the area of a circle. The radius must be given by the user.

*****

### Lesson 5 - Converting Data Types

We have already learned that data comes in many different types. This lesson is going to go a little further on how to convert between different data types, and also introduce new ones.

These are the data types we know so far:

```csharp
string name = "Bob";
int age = 25;
double pi = 3.14159;
```

We also know that we can do various operations with numbers, but not all operations can be done with strings.

```csharp
Console.WriteLine(name * pi)        // returns an ERROR!
Console.WriteLine(name + name)      // returns "BobBob"
```

When the user is prompted for an input, this input will get into the application as a string. Everything typed into the Console **Always** comes into the code as a string!

Let's write an application that prompts the user for some information, and then does something with it.

```csharp
Console.WriteLine("How many wheels does a car have?");
```

If we intend to use this information for mathematical operations, we MUST convert it to a suitable Data Type. the ```Convert.ToInt32()``` method will convert the input to an ```int```.

```csharp
int wheels = Convert.ToInt32(Console.ReadLine());
```

How many wheels are there in a garage with 5 cars?

```csharp
Console.WriteLine($"A garage with 5 cars has {wheels * 5} wheels.");
```

Note how we just made a mathematical operation inside that placeholder. Yep, we can do that, too :)

However, there are times in which the user inputs a number, but we will not use it for any calculation. Sometimes this is just an information that will be displayed, or stored in a database. Like a phone number, for example.

Here is another example in which no conversion is needed:

```csharp
Console.WriteLine("How many people are there in your family? ");
string familyMembers = Console.ReadLine();

Console.WriteLine($"Your family has {familyMembers} people.");
```

Different variables may contain the same value, but in different types:

```csharp
var value1 = 10;
var value2 = "10";
```

Variables value1 is different than value2! One is a number, the other is a string. Be careful!

By the way, ```var``` is a keyword that can be used to declare new variables. C# will automatically infer the actual data type for you, for that variable.

There are other important Data Types in C#: ```bool``` and ```char```.

```csharp 
bool variable1 = true;
char variable2 = 'a';
``` 

Now, ```bool``` is a data type that can either be ```true``` or ```false```. No other value is permitted. It has many applications in the context of programming.

```char``` is a data type that is very similar to a ```string```, but it only contains one character. The values stored in a char variable must contain single quotes ```' '```, and not douple quotes ```" "``` as strings.

This is a good way to differentiate strings from chars: chars have single quotes ' ', strings have double quotes " ".

As there are many different data types, it is important to know when and how to convert between types. It may be the only difference between a functional code and a non-functional code.

We have already converted a few data types before, by using the ```Convert.To...``` method. This method can be used to convert between strings and whatever the desired data type is. If you are converting from or to a ```string```, ALWAYS use Convert.To...

```csharp
var newVariable1 = Convert.ToString(variable1);
var newVariable2 = Convert.ToString(variable2);
```

In order to convert between data types, we must make sure that the destination type accepts the value we want to assign to it.

For example, if we have a string "Bob", we cannot convert this value to a number! Letters are not numbers! Another good example: We know that a boolean (```bool```) variable can only be ```true``` or ```false```. Again, we cannot convert a boolean variable to a number (neither ```int``` nor ```double```)! Letters are not numbers!

We can, however, convert ```bool``` to ```string```. Text is text!

Another quick method to do type conversion is by CASTING. It can be done when converting between types that are not strings. It is very simple to do:

```csharp
double x = 1.23456;
int y = (int)x;

Console.WriteLine(y);
```

The console reads:

```csharp
1
```

By the way, never name your variables ```x```, ```y```, ```variable1```, ```number1```, etc. These are horrible, horrible names for variables.

By the end of this lesson, this is what your code should look like:

```csharp 
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name = "Bob";
            int age = 25;
            double pi = 3.14159;

            Console.WriteLine("How many wheels does a car have?");

            int wheels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A garage with 5 cars has {0} wheels.", wheels * 5);

            Console.WriteLine("How many people are there in your family? ");
            string familyMembers = Console.ReadLine();

            Console.WriteLine("Your family has {0} people.", familyMembers);

            var value1 = 10;
            var value2 = "10";

            bool variable1 = true;
            char variable2 = 'a';

            var newVariable1 = Convert.ToString(variable1);
            var newVariable2 = Convert.ToString(variable2);

            double x = 1.23456;
            int y = (int)x;

            Console.WriteLine(y);
        }
    }
}
```

#### EXPLORATION EXERCISES:

1) You are a programmer working for a census company. Write an application that prompts the user for the
number of TV's they have in their homes. If each TV costs $500, how much money has this person spent in TV's?
Your program must calculate and display the answer.

2) Write a program that prompts the user for their hourly pay and the number of hours worked in a month.
Calculate and display the salary for that month.

3) Make a console application that prompts the user for the first letter of their first name. Display a
friendly message with the letter (i.e. "L is my favorite word!").

*****

### Lesson 6 - Commenting Your Code

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            Have you ever noticed how there are lots of explanations and instructions in every file of this course?
            This is dont by adding comments into the executable code. There are two ways to do that:
            */

            // You can type two slashes //, and then type whatever note or reminder after that. Just like I did in this line.

            /*
            Or, in case a block of comments with more than one line is needed, you can do it like this!
            Then you can have multiple lines to write anything that is relevant to your code.
            
            The compiler will ignore these lines, so whatever is written in these blocks will not be displayed to the user!
            
            Do you want to check?
            
            Console.WriteLine("Can you see this?");
            
            I don't think so!
            */
        }
    }
}
```

*****

### Lesson 7 - Quick Recap

Before we continue to the next lessons, it is highly recommended that you make sure that you are comfortable with everything that has been covered so far.

So, let's do a quick recap.

The most common data types that we have worked with are:

- Strings:

```csharp 
string name = "Bob";
```

- Integers:

```csharp 
int age = 25;
```

- Doubles:

```csharp
double bobsSalary = 2000.50;
```

We can ask Bob to input a name of one of his friends:

```csharp
Console.WriteLine("Bob, please enter the name of a friend: ");
```

And then store this number into a variable:

```csharp
string bobsFriend = Console.ReadLine();
```

**Everything entered via Console is a STRING.** So, if we prompt Bob for the number of hands he has:

```csharp
Console.WriteLine("Bob, please input the number of hands that you have: ");
```

We must convert the entered value to a number, so we can run mathematical operations with it.

```csharp
int bobsHands = Convert.ToInt32(Console.ReadLine());
```

Now this number is suitable for math.

```csharp 
int numberOfFingers = 5 * bobsHands;
```

After running our calculations, we can print the result on to the screen using interpolation.

```csharp 
Console.WriteLine($"Bob has {numberOfFingers} fingers.");
```

However, if no mathematics are needed, it is OK to keep numbers as strings.

```csharp 
Console.WriteLine("Please enter your phone number: ");
string phoneNumber = Console.ReadLine();
```

Bob is 25 years old. He is allowed to drive. Is this statement true or false?

```csharp 
bool canDrive = true;
```

Is he old enough to retire?

```csharp
bool canRetire = false;
```

What is the first letter of Bob's name?

```csharp
char firstLetter = 'b';
```

Chars can also be numbers (if no mathematics is involved):

```csharp
char fingersPerHand = '5';
```

But if some mathematics comes up, we can convert between types, and the world is good again!

```csharp
int newFingersPerHand = (int)fingersPerHand;
```

```csharp
// Lastly, make sure your recap was neatly commented, so you can always come back to it anytime for a quick check :)
```

*****

### Congratulations!

This is the end of Module 1. Congratulations for making it this far!

Before moving to the next Module, make sure that every concept covered up to this point is really under your fingers. Things will start to get more challenging from now on, but I'm sure you're prepared!
