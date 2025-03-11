// EXERCISE 1: BASIC VARIABLE DECLARATION
// Create a C# program that declares variables for each of the following:
// - Your age as an integer
// - Your height in meters as a double
// - Your first name as a string
// - Whether you've programmed before as a boolean
// Initialize these with appropriate values and display them

using System;

class Exercise1
{
    static void Main()
    {
        // TODO: Declare and initialize variables here
        
        
        // TODO: Display all variables with appropriate labels
        
        
        Console.WriteLine("Press any key to continue to the next exercise...");
        Console.ReadKey();
    }
}

// EXERCISE 2: TYPE CONVERSION
// Create a program that demonstrates different type conversions:
// - Convert a string to an integer
// - Convert a double to an integer (note the loss of precision)
// - Convert an integer to a double
// - Try to convert a non-numeric string to an integer and handle the error

using System;

class Exercise2
{
    static void Main()
    {
        // Example of string to integer conversion
        string numberAsString = "42";
        int convertedNumber = Convert.ToInt32(numberAsString);
        Console.WriteLine($"Converted string \"{numberAsString}\" to integer: {convertedNumber}");
        
        // TODO: Convert a double to an integer
        
        
        // TODO: Convert an integer to a double
        
        
        // TODO: Try to convert an invalid string to integer with try-catch
        
        
        Console.WriteLine("Press any key to continue to the next exercise...");
        Console.ReadKey();
    }
}

// EXERCISE 3: CALCULATING WITH VARIABLES
// Create a simple calculator program that:
// - Declares two double variables
// - Performs addition, subtraction, multiplication, and division on them
// - Displays the results formatted to 2 decimal places

using System;

class Exercise3
{
    static void Main()
    {
        // TODO: Declare two variables here
        
        
        // TODO: Perform calculations and display results
        
        
        Console.WriteLine("Press any key to continue to the next exercise...");
        Console.ReadKey();
    }
}

// EXERCISE 4: WORKING WITH DIFFERENT NUMERIC TYPES
// Create a program that demonstrates the differences between:
// - int, long, float, double, and decimal
// - Show the precision differences and ranges

using System;

class Exercise4
{
    static void Main()
    {
        // TODO: Demonstrate differences between numeric types
        
        
        Console.WriteLine("Press any key to continue to the next exercise...");
        Console.ReadKey();
    }
}

// EXERCISE 5: CHALLENGE - TEMPERATURE CONVERTER
// Create a program that converts temperatures between Celsius and Fahrenheit
// - Declare a variable for Celsius temperature
// - Calculate and display the equivalent Fahrenheit temperature using the formula: F = C × 9/5 + 32
// - Then do the reverse: convert a Fahrenheit temperature to Celsius using: C = (F - 32) × 5/9

using System;

class Exercise5
{
    static void Main()
    {
        // TODO: Implement temperature conversion
        
        
        Console.WriteLine("Program complete. Press any key to exit.");
        Console.ReadKey();
    }
}