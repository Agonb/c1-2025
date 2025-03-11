// EXERCISE 1: BASIC VARIABLE DECLARATION - SOLUTION
using System;

class Exercise1Solution
{
    static void Main()
    {
        // Declare and initialize variables
        int age = 25;
        double heightInMeters = 1.75;
        string firstName = "Alex";
        bool hasProgrammedBefore = true;
        
        // Display all variables with appropriate labels
        Console.WriteLine("Personal Information:");
        Console.WriteLine($"Age: {age} years");
        Console.WriteLine($"Height: {heightInMeters} meters");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Has programmed before: {hasProgrammedBefore}");
        
        Console.WriteLine("\nPress any key to continue to the next solution...");
        Console.ReadKey();
    }
}

// EXERCISE 2: TYPE CONVERSION - SOLUTION
using System;

class Exercise2Solution
{
    static void Main()
    {
        // String to integer conversion
        string numberAsString = "42";
        int convertedNumber = Convert.ToInt32(numberAsString);
        Console.WriteLine($"Converted string \"{numberAsString}\" to integer: {convertedNumber}");
        
        // Double to integer conversion (note the loss of precision)
        double pi = 3.14159;
        int roundedPi = (int)pi;
        Console.WriteLine($"Converted double {pi} to integer: {roundedPi} (decimal part is lost)");
        
        // Integer to double conversion
        int count = 5;
        double countAsDouble = count;  // Implicit conversion
        Console.WriteLine($"Converted integer {count} to double: {countAsDouble}");
        
        // Trying to convert an invalid string to integer with try-catch
        string invalidNumber = "hello";
        try
        {
            int result = Convert.ToInt32(invalidNumber);
            Console.WriteLine($"Converted {invalidNumber} to {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine($"Error: Cannot convert \"{invalidNumber}\" to an integer.");
        }
        
        // Alternative using TryParse
        string anotherInvalidNumber = "42.5";  // Has a decimal point, can't be parsed as int
        int parsedResult;
        bool success = int.TryParse(anotherInvalidNumber, out parsedResult);
        
        if (success)
        {
            Console.WriteLine($"Successfully parsed {anotherInvalidNumber} to {parsedResult}");
        }
        else
        {
            Console.WriteLine($"Failed to parse \"{anotherInvalidNumber}\" as an integer. Result was {parsedResult}");
        }
        
        Console.WriteLine("\nPress any key to continue to the next solution...");
        Console.ReadKey();
    }
}

// EXERCISE 3: CALCULATING WITH VARIABLES - SOLUTION
using System;

class Exercise3Solution
{
    static void Main()
    {
        // Declare two double variables
        double number1 = 15.75;
        double number2 = 3.25;
        
        // Perform calculations
        double sum = number1 + number2;
        double difference = number1 - number2;
        double product = number1 * number2;
        double quotient = number1 / number2;
        
        // Display results formatted to 2 decimal places
        Console.WriteLine("Simple Calculator");
        Console.WriteLine($"First number: {number1}");
        Console.WriteLine($"Second number: {number2}");
        Console.WriteLine($"Addition: {number1} + {number2} = {sum:F2}");
        Console.WriteLine($"Subtraction: {number1} - {number2} = {difference:F2}");
        Console.WriteLine($"Multiplication: {number1} × {number2} = {product:F2}");
        Console.WriteLine($"Division: {number1} ÷ {number2} = {quotient:F2}");
        
        Console.WriteLine("\nPress any key to continue to the next solution...");
        Console.ReadKey();
    }
}

// EXERCISE 4: WORKING WITH DIFFERENT NUMERIC TYPES - SOLUTION
using System;

class Exercise4Solution
{
    static void Main()
    {
        Console.WriteLine("Numeric Type Demonstrations\n");
        
        // Integer examples
        int regularInt = 2147483647; // Maximum value for int
        Console.WriteLine($"Maximum int value: {regularInt}");
        
        long bigNumber = 9223372036854775807; // Maximum value for long
        Console.WriteLine($"Maximum long value: {bigNumber}");
        
        // What happens if we try to exceed the limits?
        Console.WriteLine($"Int overflow example: {regularInt + 1}"); // Will overflow to negative
        
        // Precision examples
        float floatNumber = 123.456789f;
        double doubleNumber = 123.456789;
        decimal decimalNumber = 123.456789m;
        
        Console.WriteLine("\nPrecision Comparison:");
        Console.WriteLine($"As float:   {floatNumber}"); // Less precise
        Console.WriteLine($"As double:  {doubleNumber}"); // More precise
        Console.WriteLine($"As decimal: {decimalNumber}"); // Most precise for financial calculations
        
        // Division comparison
        int a = 10;
        int b = 3;
        
        Console.WriteLine("\nDivision Comparison:");
        Console.WriteLine($"Integer division (10/3): {a / b}"); // Results in 3, decimal part truncated
        Console.WriteLine($"Float division (10/3): {10f / 3f}");
        Console.WriteLine($"Double division (10/3): {10.0 / 3.0}");
        Console.WriteLine($"Decimal division (10/3): {10m / 3m}");
        
        // Demonstrating numerical accuracy with decimal vs double
        double sum = 0.0;
        for (int i = 0; i < 1000; i++)
        {
            sum += 0.001;
        }
        
        decimal decimalSum = 0m;
        for (int i = 0; i < 1000; i++)
        {
            decimalSum += 0.001m;
        }
        
        Console.WriteLine("\nAccuracy in Financial Calculations:");
        Console.WriteLine($"Adding 0.001 a thousand times with double: {sum}"); // May not be exactly 1
        Console.WriteLine($"Adding 0.001 a thousand times with decimal: {decimalSum}"); // Will be exactly 1
        
        Console.WriteLine("\nPress any key to continue to the next solution...");
        Console.ReadKey();
    }
}

// EXERCISE 5: CHALLENGE - TEMPERATURE CONVERTER - SOLUTION
using System;

class Exercise5Solution
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter\n");
        
        // Celsius to Fahrenheit
        double celsius = 25.0;
        double fahrenheit = (celsius * 9 / 5) + 32;
        
        Console.WriteLine($"{celsius}°C is equal to {fahrenheit}°F");
        
        // Fahrenheit to Celsius
        double fahrenheitTemp = 98.6;
        double celsiusConverted = (fahrenheitTemp - 32) * 5 / 9;
        
        Console.WriteLine($"{fahrenheitTemp}°F is equal to {celsiusConverted:F1}°C");
        
        // Interactive version (optional enhancement)
        Console.WriteLine("\nInteractive Temperature Converter");
        Console.Write("Enter a temperature value: ");
        
        if (double.TryParse(Console.ReadLine(), out double inputTemp))
        {
            Console.Write("Convert from (C)elsius or (F)ahrenheit? ");
            string choice = Console.ReadLine()?.ToUpper();
            
            if (choice == "C")
            {
                double convertedF = (inputTemp * 9 / 5) + 32;
                Console.WriteLine($"{inputTemp}°C is equal to {convertedF:F1}°F");
            }
            else if (choice == "F")
            {
                double convertedC = (inputTemp - 32) * 5 / 9;
                Console.WriteLine($"{inputTemp}°F is equal to {convertedC:F1}°C");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter C or F.");
            }
        }
        else
        {
            Console.WriteLine("Invalid temperature value. Please enter a number.");
        }
        
        Console.WriteLine("\nProgram complete. Press any key to exit.");
        Console.ReadKey();
    }
}