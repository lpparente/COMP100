# C# in a Nutshell

### Before we begin...

Before we go ahead through this course, it is recommended that you download the "CSharp" folder in this repository, as you'll then be able to run each file in your C# IDE, and see how each code is supposed to run. Use these files as reference, and consult them if your own files do not work as expected. Also, each file contains exercises for you to practice what you have just learned. Of course, doing them is optional, but it is a good idea to go through them to make sure that you are comfortable with what has just been taught.

Every new C# project is supposed to contain the following lines:

```csharp
using System;

namespace CSharp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // C# coding goes here!
        }
    }
}
```

Your code starts in the "C# coding goes here!" mark. When you create a new C# project, make sure you type your lines in the right place!

Each lesson title will have a reference in parenthesis () as to what file does that lesson refers to. In case you need to troubleshoot your code, make sure to look at the right .cs file!

Welcome to C#! I hope you enjoy this journey as much as I do!

***** 

### Lesson 1 - Hello World (001_Hello_World.cs)
As we are starting this course in a simple context, the Console will be used to both display outputs and gather inputs from the user. C#, and also most programming languages, have vast resources dedicated to interacting with the user via Console.

"Hello World" is a classic introduction to programming languages. Due to its simplicity, it is easy to introduce basic concepts to the student, such as displaying information on the screen.

The WriteLine method, as the name suggests, inserts a line, displaying it on to the screen. It may contain text or numbers. As we want to display the message "Hello World!", which is a text string, double quotes "" must be used.

The code below is your first C# console application. You can copy and paste the lines below into your IDE of 
choice and see how this code works.

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

### Lesson 2 - Input and Output (002_Input_and_Output.cs)

The Console is the medium through which information is gathered from and printed to, in order to interact with the user. In this context, the two most important actions are:

- Reading information given by the user,
- Displaying information to the user.

The methods for performing these actions are, respectively:

- Read() or ReadLine(),
- Write() or WriteLine().

However, we always need to write our code in a language that the computer understands. In order to use the ReadLine() or WriteLine() methods, we must specify that we want to address these commands to the Console.

The example below uses both methods mentioned in order to make a console application that gathers an information from the user, and prints them afterwards.

In order to store information, variables must be created. Variables work as a "box" in which things are stored into. In the context of programming, these things are called data.

In order to use variables, they must always be created, or declared, before being put into use (similarly, you must first buy the box you need before putting things into it).

This is how we declare variables in C#:

```csharp
string firstName;
string lastName;
```

The WriteLine() method is called in the Console. An information is requested.

```csharp
Console.WriteLine("Please input your first name: ");
```

The ReadLine() method is called. It allows us to store the information given by the user in a variable that was previously declared. This is the way to do it:

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

We can make it better and show both names using the "+" operator:

```csharp
Console.WriteLine("Hello, " + firstName);
```

A more advanced method, and probably the best way to display information, is by using placeholders.

Spaceholders are curly brackets {} with a number (index) inside. This number represents the position of the variables placed after comma ",", identifying what is to be displayed in that position. It makes the code cleaner, professional and elegant. Here is how it's done:

```csharp
Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
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

            Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
        }
    }
}
```

*****

### Lesson 3 - Variables and Data Types (003_Variables_and_Data_Types.cs)

As mentioned in the last lesson, variables behave as real life boxes, in which objects are stored into them for later use. In most languages, variables are treated much like these objects, storing different types of information, such as numbers, text, and much more.

This is when the concept of Data Types comes in. Data is just another word for information, and information comes in many different shapes and sizes. The first data types you are going to be introduced to are:

- Strings
- Integers
- Doubles

There are many other Data Types in C#, but those will be introduced later, in a more suitable occasion.

In a nutshell:

- Strings are characters, words, sentences, or any kind of text.
- Integers are positive or negative whole numbers.
- Doubles are numbers that contain a decimal point (i.e. 2.5).

In real life, when you need a box, you must know what you want to store in it. If you need to put in a pair of shoes, you need a shoe box. If you need to pit in a hat, you need a hat box. In programming, things work very similarly. In order to create a variable, you must know
what is going to be stored in that variable in advance. 

If you need a variable to store text, you need a variable of the "string" type. If you need to store numbers, you will need either an
integer variable or a double variable. Let's code an example.

Suppose you want to code an application that shows your name on the console. Your name is a string, so we need to declare a string variable.

```csharp
string name;
```

Notice how every line of code ends with a semi-colon ";". Never forget that!

Now that our variable is created, let's assign a value to it.

```csharp
name = "Luiz";
```

Now we can use the WriteLine method to print the name to the Console.

```csharp
Console.WriteLine(name);
```

Now, we want to make our application more user friendly, so we may enhance our code a bit.

```csharp
Console.WriteLine("Hello, " + name + "!");
```

Alternatively, we can use placeholders as well. Hopefully you remember that from our last lesson.

```csharp
Console.WriteLine("Hey, {0}, how are you?", name);
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

            Console.WriteLine("Hey, {0}, how are you?", name);
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

### Lesson 4 - Operations With Variables (004_Operations_With_Variables.cs)

As we covered before, variables are like boxes, being used to store information, and Data Types are all the different kinds of information that we can work with (strings, numbers, etc).

One of the most important skills in any programming language is knowing how to work with data. A good programmer must be able to create and handle data at their own free will, doing whatever it takes to make the application work. This lesson covers the tip of the iceberg of what it is.

One quick and fun way to understand this is by using C# to perform basic mathematical operations. The following lines will do just that.

Suppose we have two integers, listed below.

```csharp
int a = 10;
int b = 15;
```

See how we declared each variable and assigned a value to it on the same line? That is not only cool, but saves a lot of time!

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

Have you tried running the code block above (lines 53 to 58)? **It returns an error!**

This is because, as we said before, EVERYTHING that is written by the user on the Console is a string! If you buy a shoe box, there is no way you're able to store a basketball inside it. Just as you need right boxes for different objects, you need right 
variable types for different data types.

That means, in order to make the code above work, we need to CONVERT the users input (which are originally strings) into numbers. Here is how we do that:

```csharp
Console.WriteLine("Please input the first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please input the second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());
```

We just learned another trick: How to convert strings into doubles. This is very useful! But don't worry much about converting now. It will be better explained in the next lesson.

Now we continue our code and multiply them, showing the result to the user.

```csharp
Console.WriteLine(number1 * number2);
```

There are two mathematical operators that can also be used with strings. These are Addition "+" and Multiplication "*". However, they behave quite differently with strings.
 
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

