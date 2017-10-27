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

By the end of this lesson, this is how your code should look like:

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

