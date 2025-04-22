// C# PROGRAMMING ESCAPE ROOM CHALLENGE
// ==================================
// This file contains all the puzzles for the escape room challenge.
// Each puzzle focuses on different programming concepts from weeks 1-7.
// Instructions for instructors: Separate these puzzles into individual files
// for distribution to students during the activity.

// =============================================================================
// PUZZLE 1: ENTRY ROOM - VARIABLES & DATA TYPES
// =============================================================================

/*
Welcome to the C# Escape Room Challenge!
To unlock the first door, you must correctly declare and initialize variables.
Follow the instructions carefully to receive the key to the next room.

INSTRUCTIONS:
1. Create variables with the EXACT names, types, and values specified
2. Do not modify any existing code
3. When all variables are correctly defined, the door will unlock!
*/

using System;

namespace EscapeRoom.Puzzle1
{
    class EntryRoom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRY ROOM: Variables & Data Types");
            Console.WriteLine("==================================");
            Console.WriteLine("Initialize the variables correctly to unlock the door!");
            
            // TASK 1: Create an integer variable named 'key' with the value 42
            // YOUR CODE HERE
            
            // TASK 2: Create a string variable named 'password' with the value "OpenSesame"
            // YOUR CODE HERE
            
            // TASK 3: Create a boolean variable named 'isLocked' with the value false
            // YOUR CODE HERE
            
            // TASK 4: Create a double variable named 'pi' with the value 3.14159
            // YOUR CODE HERE
            
            // TASK 5: Create a char variable named 'initial' with the value 'C'
            // YOUR CODE HERE
            
            // VERIFICATION (DO NOT MODIFY)
            bool task1Complete = (key == 42);
            bool task2Complete = (password == "OpenSesame");
            bool task3Complete = (isLocked == false);
            bool task4Complete = Math.Abs(pi - 3.14159) < 0.00001;
            bool task5Complete = (initial == 'C');
            
            if (task1Complete && task2Complete && task3Complete && task4Complete && task5Complete)
            {
                Console.WriteLine("Congratulations! The door unlocks...");
                Console.WriteLine("You receive a key with the code: LOGIC-8042");
                Console.WriteLine("Use this code to access the next puzzle!");
            }
            else
            {
                Console.WriteLine("The door remains locked. Check your variables and try again!");
                if (!task1Complete) Console.WriteLine("- Task 1 is incorrect");
                if (!task2Complete) Console.WriteLine("- Task 2 is incorrect");
                if (!task3Complete) Console.WriteLine("- Task 3 is incorrect");
                if (!task4Complete) Console.WriteLine("- Task 4 is incorrect");
                if (!task5Complete) Console.WriteLine("- Task 5 is incorrect");
            }
        }
    }
}

// =============================================================================
// PUZZLE 2: LOGIC CHAMBER - OPERATORS & CONTROL FLOW
// =============================================================================

/*
Welcome to the Logic Chamber!
In this room, you must fix broken if/else statements and complete logical expressions.
Debug the code below to proceed to the next room.

INSTRUCTIONS:
1. Find and fix all logical errors in the code
2. Ensure the correct path is chosen based on the given conditions
3. Do not modify the comments or the verification code
*/

using System;

namespace EscapeRoom.Puzzle2
{
    class LogicChamber
    {
        static void Main(string[] args)
        {
            // This code requires the access code from Puzzle 1
            Console.WriteLine("LOGIC CHAMBER: Operators & Control Flow");
            Console.WriteLine("======================================");
            Console.WriteLine("Enter the access code from the previous room:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "LOGIC-8042")
            {
                Console.WriteLine("Invalid access code. You cannot enter this room!");
                return;
            }
            
            Console.WriteLine("The door opens... you step into the Logic Chamber.");
            Console.WriteLine("Fix the broken logic to find your way through the maze!");
            
            int x = 10;
            int y = 5;
            
            // TASK 1: Fix the condition so it evaluates to TRUE
            bool pathA = (x < y || x == y); // This is WRONG - fix it!
            
            // TASK 2: Fix the condition so it evaluates to TRUE
            bool pathB = (x + y != 15 && x - y != 5); // This is WRONG - fix it!
            
            // TASK 3: Fix this IF statement to choose the correct path
            string direction = "unknown";
            if (x < 0)
            {
                direction = "left";
            }
            else if (y < 0)
            {
                direction = "right";
            }
            else if (x == 10 && y == 5)
            {
                direction = "backward"; // This should be "forward" to be correct
            }
            else
            {
                direction = "forward";
            }
            
            // TASK 4: Fix this SWITCH statement to calculate the correct key
            int secretKey = 0;
            switch (direction)
            {
                case "left":
                    secretKey = x - y;
                    break;
                case "right":
                    secretKey = x + y;
                    break;
                case "backward":
                    secretKey = x * y;
                    break;
                case "forward": // This case should set secretKey to x * y
                    secretKey = x - y;
                    break;
                default:
                    secretKey = 0;
                    break;
            }
            
            // VERIFICATION (DO NOT MODIFY)
            if (pathA && pathB && direction == "forward" && secretKey == 50)
            {
                Console.WriteLine("The logic is sound! A hidden door slides open...");
                Console.WriteLine("You receive a key with the code: LOOP-1337");
                Console.WriteLine("Use this code to access the next puzzle!");
            }
            else
            {
                Console.WriteLine("You're lost in the logic maze. Check your code and try again!");
                Console.WriteLine($"Path A: {(pathA ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Path B: {(pathB ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Direction: '{direction}' {(direction == "forward" ? "(Correct)" : "(Incorrect)")}");
                Console.WriteLine($"Secret Key: {secretKey} {(secretKey == 50 ? "(Correct)" : "(Incorrect)")}");
            }
        }
    }
}

// =============================================================================
// PUZZLE 3: LOOP LABYRINTH - LOOPS & ITERATIONS
// =============================================================================

/*
Welcome to the Loop Labyrinth!
In this chamber, you must navigate by fixing broken loops and implementing
correct iteration patterns.

INSTRUCTIONS:
1. Fix the broken loops to generate the correct sequences
2. Implement missing code in incomplete loops
3. Ensure each loop produces the expected output
*/

using System;

namespace EscapeRoom.Puzzle3
{
    class LoopLabyrinth
    {
        static void Main(string[] args)
        {
            // This code requires the access code from Puzzle 2
            Console.WriteLine("LOOP LABYRINTH: Loops & Iterations");
            Console.WriteLine("==================================");
            Console.WriteLine("Enter the access code from the previous room:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "LOOP-1337")
            {
                Console.WriteLine("Invalid access code. You cannot enter this room!");
                return;
            }
            
            Console.WriteLine("The door opens... you step into the Loop Labyrinth.");
            Console.WriteLine("Fix the broken loops to find your way through!");
            
            // TASK 1: Fix this loop to count from 1 to 5
            Console.Write("Loop 1 output: ");
            for (int i = 0; i <= 5; i--) // This loop is WRONG - fix it!
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            // Expected output: 1 2 3 4 5
            
            // TASK 2: Fix this loop to count down from 10 to 1
            Console.Write("Loop 2 output: ");
            int j = 10;
            while (j > 0)
            {
                // Missing code - implement it!
                j++;
            }
            Console.WriteLine();
            // Expected output: 10 9 8 7 6 5 4 3 2 1
            
            // TASK 3: Fix this loop to print the first 5 even numbers
            Console.Write("Loop 3 output: ");
            int k = 1;
            int evensFound = 0;
            while (evensFound < 5)
            {
                if (k % 2 == 1) // This condition is WRONG - fix it!
                {
                    Console.Write(k + " ");
                    evensFound++;
                }
                k++;
            }
            Console.WriteLine();
            // Expected output: 2 4 6 8 10
            
            // TASK 4: Implement a loop to calculate the sum of numbers from 1 to 10
            Console.Write("Loop 4 output: ");
            int sum = 0;
            // YOUR CODE HERE
            Console.WriteLine("Sum = " + sum);
            // Expected output: Sum = 55
            
            // VERIFICATION (DO NOT MODIFY)
            bool task1Output = VerifyTask1();
            bool task2Output = VerifyTask2();
            bool task3Output = VerifyTask3();
            bool task4Output = (sum == 55);
            
            if (task1Output && task2Output && task3Output && task4Output)
            {
                Console.WriteLine("You've escaped the Loop Labyrinth!");
                Console.WriteLine("You receive a key with the code: FUNC-2468");
                Console.WriteLine("Use this code to access the next puzzle!");
            }
            else
            {
                Console.WriteLine("You're still trapped in the loops. Check your code and try again!");
                Console.WriteLine($"Loop 1: {(task1Output ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Loop 2: {(task2Output ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Loop 3: {(task3Output ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Loop 4: {(task4Output ? "Correct" : "Incorrect")}");
            }
        }
        
        // Verification methods (implement these for a real application)
        static bool VerifyTask1() { return true; } // Placeholder
        static bool VerifyTask2() { return true; } // Placeholder
        static bool VerifyTask3() { return true; } // Placeholder
    }
}

// =============================================================================
// PUZZLE 4: FUNCTION FORGE - FUNCTIONS & METHODS
// =============================================================================

/*
Welcome to the Function Forge!
Here you must implement and fix functions to process data correctly.
Complete the function bodies to continue your escape.

INSTRUCTIONS:
1. Implement the missing function bodies
2. Fix broken function implementations
3. Ensure each function produces the expected output for all test cases
*/

using System;

namespace EscapeRoom.Puzzle4
{
    class FunctionForge
    {
        static void Main(string[] args)
        {
            // This code requires the access code from Puzzle 3
            Console.WriteLine("FUNCTION FORGE: Functions & Methods");
            Console.WriteLine("===================================");
            Console.WriteLine("Enter the access code from the previous room:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "FUNC-2468")
            {
                Console.WriteLine("Invalid access code. You cannot enter this room!");
                return;
            }
            
            Console.WriteLine("The door opens... you step into the Function Forge.");
            Console.WriteLine("Implement the missing functions to forge your key!");
            
            // TASK 1: Implement this function to return the maximum of three integers
            // Test cases
            Console.WriteLine($"Max of 5, 10, 3: {Max3(5, 10, 3)} (should be 10)");
            Console.WriteLine($"Max of 7, 7, 7: {Max3(7, 7, 7)} (should be 7)");
            Console.WriteLine($"Max of -5, -10, -3: {Max3(-5, -10, -3)} (should be -3)");
            
            // TASK 2: Fix this function to correctly check if a number is prime
            // Test cases
            Console.WriteLine($"IsPrime(7): {IsPrime(7)} (should be True)");
            Console.WriteLine($"IsPrime(15): {IsPrime(15)} (should be False)");
            Console.WriteLine($"IsPrime(23): {IsPrime(23)} (should be True)");
            Console.WriteLine($"IsPrime(1): {IsPrime(1)} (should be False)");
            
            // TASK 3: Implement this function to count vowels in a string
            // Test cases
            Console.WriteLine($"CountVowels(\"hello\"): {CountVowels("hello")} (should be 2)");
            Console.WriteLine($"CountVowels(\"programming\"): {CountVowels("programming")} (should be 3)");
            Console.WriteLine($"CountVowels(\"aeiou\"): {CountVowels("aeiou")} (should be 5)");
            
            // TASK 4: Fix this function to reverse a string correctly
            // Test cases
            Console.WriteLine($"ReverseString(\"hello\"): {ReverseString("hello")} (should be \"olleh\")");
            Console.WriteLine($"ReverseString(\"C#\"): {ReverseString("C#")} (should be \"#C\")");
            Console.WriteLine($"ReverseString(\"\"): {ReverseString("")} (should be \"\")");
            
            // VERIFICATION (DO NOT MODIFY)
            bool task1Correct = VerifyTask1();
            bool task2Correct = VerifyTask2();
            bool task3Correct = VerifyTask3();
            bool task4Correct = VerifyTask4();
            
            if (task1Correct && task2Correct && task3Correct && task4Correct)
            {
                Console.WriteLine("You've crafted perfect functions!");
                Console.WriteLine("You receive a key with the code: ARRAY-9876");
                Console.WriteLine("Use this code to access the final puzzle!");
            }
            else
            {
                Console.WriteLine("Your functions need more work. Check your code and try again!");
                Console.WriteLine($"Function 1: {(task1Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Function 2: {(task2Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Function 3: {(task3Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Function 4: {(task4Correct ? "Correct" : "Incorrect")}");
            }
        }
        
        // TASK 1: Implement this function to return the maximum of three integers
        static int Max3(int a, int b, int c)
        {
            // YOUR CODE HERE
            return 0; // This is wrong - implement the correct solution
        }
        
        // TASK 2: Fix this function to correctly check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return true; // This is wrong - fix it
                
            if (number == 2)
                return true;
                
            if (number % 2 == 0)
                return false;
                
            for (int i = 3; i < number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            
            return true;
        }
        
        // TASK 3: Implement this function to count vowels in a string
        static int CountVowels(string text)
        {
            // YOUR CODE HERE
            return 0; // This is wrong - implement the correct solution
        }
        
        // TASK 4: Fix this function to reverse a string correctly
        static string ReverseString(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;
                
            string reversed = "";
            for (int i = 0; i < text.Length; i++)
            {
                reversed += text[i]; // This is wrong - fix it
            }
            
            return reversed;
        }
        
        // Verification methods (implement these for a real application)
        static bool VerifyTask1() { return true; } // Placeholder
        static bool VerifyTask2() { return true; } // Placeholder
        static bool VerifyTask3() { return true; } // Placeholder
        static bool VerifyTask4() { return true; } // Placeholder
    }
}


// Task 2:
// Change "return true" to "return false" in the first if statement (if number <= 1)

// Task 3:
// static int CountVowels(string text)
// {
//     int count = 0;
//     foreach (char c in text.ToLower())
//     {
//         if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//             count++;
//     }
//     return count;
// }

// Task 4:
// Change the for loop to:
// for (int i = text.Length - 1; i >= 0; i--)
// {
//     reversed += text[i];
// }

// =============================================================================
// PUZZLE 5: ARRAY ABYSS - ARRAYS & LISTS
// =============================================================================

/*
Welcome to the Array Abyss!
This is the final challenge. You must navigate through arrays and lists
to find the exit code and escape the room.

INSTRUCTIONS:
1. Complete the code to process arrays and lists
2. Fix the broken implementations
3. Implement missing functionality
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace EscapeRoom.Puzzle5
{
    class ArrayAbyss
    {
        static void Main(string[] args)
        {
            // This code requires the access code from Puzzle 4
            Console.WriteLine("ARRAY ABYSS: Arrays & Lists");
            Console.WriteLine("===========================");
            Console.WriteLine("Enter the access code from the previous room:");
            string accessCode = Console.ReadLine();
            
            if (accessCode != "ARRAY-9876")
            {
                Console.WriteLine("Invalid access code. You cannot enter this room!");
                return;
            }
            
            Console.WriteLine("The door opens... you step into the Array Abyss.");
            Console.WriteLine("This is the final challenge! Process the arrays correctly to escape!");
            
            // TASK 1: Fix this code to find the sum of all elements in the array
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;
            // The loop below is wrong - fix it
            for (int i = 0; i <= numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of array elements: {sum} (should be 150)");
            
            // TASK 2: Implement code to find the average of the array elements
            double average = 0.0;
            // YOUR CODE HERE
            Console.WriteLine($"Average of array elements: {average} (should be 30.0)");
            
            // TASK 3: Fix this code to reverse the array
            int[] reversed = new int[numbers.Length];
            // The code below is wrong - fix it
            for (int i = 0; i < numbers.Length; i++)
            {
                reversed[i] = numbers[i];
            }
            Console.Write("Reversed array: ");
            foreach (int num in reversed)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("(should be 50 40 30 20 10)");
            
            // TASK 4: Implement code to filter even numbers from the array
            List<int> evenNumbers = new List<int>();
            // YOUR CODE HERE
            Console.Write("Even numbers: ");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("(should be 10 20 30 40 50)");
            
            // TASK 5: Fix this code to find the largest element in the array
            int largest = numbers[0];
            // The code below is wrong - fix it
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine($"Largest element: {largest} (should be 50)");
            
            // VERIFICATION (DO NOT MODIFY)
            bool task1Correct = (sum == 150);
            bool task2Correct = Math.Abs(average - 30.0) < 0.001;
            bool task3Correct = VerifyReversed(reversed, numbers);
            bool task4Correct = VerifyEvenNumbers(evenNumbers);
            bool task5Correct = (largest == 50);
            
            if (task1Correct && task2Correct && task3Correct && task4Correct && task5Correct)
            {
                Console.WriteLine("\nCONGRATULATIONS!");
                Console.WriteLine("=================");
                Console.WriteLine("You've successfully navigated all the puzzles and escaped the room!");
                Console.WriteLine("Final escape code: C#-MASTER-2023");
                Console.WriteLine("Share this code with your instructor to confirm your completion!");
            }
            else
            {
                Console.WriteLine("\nYou're still trapped in the Array Abyss. Check your code and try again!");
                Console.WriteLine($"Task 1 (Sum): {(task1Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Task 2 (Average): {(task2Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Task 3 (Reverse): {(task3Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Task 4 (Even numbers): {(task4Correct ? "Correct" : "Incorrect")}");
                Console.WriteLine($"Task 5 (Largest): {(task5Correct ? "Correct" : "Incorrect")}");
            }
        }
        
        // Verification methods
        static bool VerifyReversed(int[] reversed, int[] original)
        {
            if (reversed.Length != original.Length)
                return false;
                
            for (int i = 0; i < original.Length; i++)
            {
                if (reversed[i] != original[original.Length - 1 - i])
                    return false;
            }
            
            return true;
        }
        
        static bool VerifyEvenNumbers(List<int> evenNumbers)
        {
            int[] expected = { 10, 20, 30, 40, 50 };
            if (evenNumbers.Count != expected.Length)
                return false;
                
            for (int i = 0; i < expected.Length; i++)
            {
                if (evenNumbers[i] != expected[i])
                    return false;
            }
            
            return true;
        }
    }
}
