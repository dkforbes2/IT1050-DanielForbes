// Lab 2 
// Displaying the product of two numbers input from the keyboard.
using System;

public class Multiplication
{ 
    // Main method begins execution
       public static void Main( string[] args )
        {
        int number1; // declares first number to multiply
        int number2; // declares second number to multiply
        int result; // declares results of multiplication of number 1 and number 2

        Console.Write("Enter first integer: "); // prompt user
        // read first number from user
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second integer: "); // prompt user
        // read second number from user
        number2 = Convert.ToInt32(Console.ReadLine());

        result = number1 * number2; // multiplies numbers

        Console.WriteLine("Result is {0}", result); //display result of multiplication

        Console.WriteLine("{0}\n{1}", "Hello World!", "From Daniel");
        Console.WriteLine("{0}\t{1}", "Hello World!", "From Daniel");
        Console.ReadLine();
        /* Question 5:
         *a. Main method begins execution of C# application.
         *b. Integer type variable is a type that can hold any 32-bit integer or null. Float stores 32-bit floating-point values. Double stores 64-bit floating-point values.
         *c. An example of a method from Chapter 4 could be SetName. SetName does not return any information to its calling method.
         *d. To read the value of an instance variable, we create a method called a GET accessor. To assign a value to an instance variable, we use a method called a SET accessor.
         *e. An object is an instance of a class at any given time. The difference between a class and an object is that the object contains values for the properties. A single class may have any number of instances.
         */
    }
}