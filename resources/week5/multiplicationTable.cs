using System;

namespace MultiplicationTableGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int number;
            string input;
            bool continueProgram = true;
            
            // Main program loop
            while (continueProgram)
            {
                // Reset input validation
                bool isValidInput = false;
                
                // Input validation loop
                do
                {
                    // Prompt user for input
                    Console.WriteLine("\nMultiplication Table Generator");
                    Console.Write("Enter a positive integer: ");
                    input = Console.ReadLine();
                    
                    // Check if input is a valid positive integer
                    if (int.TryParse(input, out number) && number > 0)
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a positive integer.");
                    }
                    
                } while (!isValidInput);
                
                // Display header
                Console.WriteLine($"\nMultiplication Table for {number}:\n");
                
                // Generate multiplication table using a for loop
                for (int i = 1; i <= 10; i++)
                {
                    int result = number * i;
                    Console.WriteLine($"{number} × {i} = {result}");
                }
                
                // Ask if user wants to continue
                Console.Write("\nWould you like to see another multiplication table? (y/n): ");
                string response = Console.ReadLine().ToLower();
                
                // Check user's response
                if (response != "y" && response != "yes")
                {
                    continueProgram = false;
                }
            }
            
            Console.WriteLine("\nThank you for using the Multiplication Table Generator!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}