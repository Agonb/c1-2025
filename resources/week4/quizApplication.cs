// Task 1: Simple Quiz Application
// Instructions:
// 1. Complete the missing code in this program to make a working quiz
// 2. Make sure to use if/else or switch statements to check answers
// 3. Add comments to explain your code

using System;

namespace QuizApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables to track score and responses
            int score = 0;
            string answer;

            // Welcome message
            Console.WriteLine("Welcome to the C# Quiz!");
            Console.WriteLine("Answer the following questions to test your knowledge.");
            Console.WriteLine("---------------------------------------------");

            // Question 1
            Console.WriteLine("Question 1: What does C# stand for?");
            Console.WriteLine("a) C Sharp");
            Console.WriteLine("b) C Hash");
            Console.WriteLine("c) C Plus Plus Plus");
            Console.WriteLine("d) C Number");
            Console.Write("Your answer: ");
            answer = Console.ReadLine().ToLower();

            // TODO: Check if the answer is correct
            // If the answer is 'a', increment the score and display "Correct!"
            // Otherwise, display "Incorrect. The right answer is a) C Sharp."

            // Question 2
            Console.WriteLine("\nQuestion 2: Which company developed C#?");
            Console.WriteLine("a) Apple");
            Console.WriteLine("b) Google");
            Console.WriteLine("c) Microsoft");
            Console.WriteLine("d) Oracle");
            Console.Write("Your answer: ");
            answer = Console.ReadLine().ToLower();

            // TODO: Check if the answer is correct
            // If the answer is 'c', increment the score and display "Correct!"
            // Otherwise, display "Incorrect. The right answer is c) Microsoft."

            // Question 3
            Console.WriteLine("\nQuestion 3: Which statement is used to create a decision in C#?");
            Console.WriteLine("a) for");
            Console.WriteLine("b) if");
            Console.WriteLine("c) switch");
            Console.WriteLine("d) both b and c");
            Console.Write("Your answer: ");
            answer = Console.ReadLine().ToLower();

            // TODO: Check if the answer is correct
            // If the answer is 'd', increment the score and display "Correct!"
            // Otherwise, display "Incorrect. The right answer is d) both b and c."

            // Display final score
            // TODO: Calculate percentage score
            // Display appropriate message based on their score:
            // If score is 3/3: "Perfect! You're a C# expert!"
            // If score is 2/3: "Good job! You know your C# basics."
            // If score is 1/3: "You need some more practice with C#."
            // If score is 0/3: "Time to study C# fundamentals."

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

// Task 2: Weather Outfit Suggester
// Instructions:
// 1. Complete this program to suggest appropriate clothing based on weather conditions
// 2. Use nested if-else statements to handle different combinations of conditions
// 3. Test with different inputs to make sure all conditions work correctly

using System;

namespace WeatherOutfitSuggester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Outfit Suggester");
            Console.WriteLine("------------------------");

            // Get temperature
            Console.Write("What is the current temperature (°F)? ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            // Get weather conditions
            Console.WriteLine("What is the current weather condition?");
            Console.WriteLine("1. Sunny");
            Console.WriteLine("2. Rainy");
            Console.WriteLine("3. Snowy");
            Console.WriteLine("4. Cloudy");
            Console.Write("Enter the number of your choice: ");
            int weatherCondition = Convert.ToInt32(Console.ReadLine());

            // Get wind conditions
            Console.Write("Is it windy? (yes/no): ");
            string windInput = Console.ReadLine().ToLower();
            bool isWindy = (windInput == "yes" || windInput == "y");

            // TODO: Implement the outfit suggestion logic using if/else and switch statements
            // Consider the following rules:
            // - If temperature is above 80°F and sunny, suggest light clothing and sunscreen
            // - If temperature is between 60°F and 80°F, suggest a light jacket
            // - If temperature is below 60°F, suggest a heavy coat
            // - If it's rainy, suggest bringing an umbrella regardless of temperature
            // - If it's snowy, suggest winter boots and gloves
            // - If it's windy, suggest bringing a windbreaker or wearing clothes that won't blow around
            
            // Example output: "We recommend wearing a light jacket and bringing an umbrella. Watch out for the wind!"

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

// Task 3: Restaurant Bill Calculator
// Instructions:
// 1. Calculate the total bill with tip based on user inputs
// 2. Use conditional statements to apply different tip percentages
// 3. Add appropriate comments and handle potential input errors

using System;

namespace RestaurantBillCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Restaurant Bill Calculator");
            Console.WriteLine("--------------------------");

            // Get the bill amount
            Console.Write("Enter the bill amount: $");
            double billAmount;
            
            // TODO: Add input validation to ensure the user enters a valid number
            // If the input is invalid, display an error message and ask them to enter again
            
            billAmount = Convert.ToDouble(Console.ReadLine());

            // Ask for service rating
            Console.WriteLine("How would you rate the service?");
            Console.WriteLine("1. Excellent (20% tip)");
            Console.WriteLine("2. Good (15% tip)");
            Console.WriteLine("3. Average (10% tip)");
            Console.WriteLine("4. Poor (5% tip)");
            Console.Write("Enter your choice (1-4): ");
            int serviceRating = Convert.ToInt32(Console.ReadLine());

            // TODO: Calculate the tip amount based on the service rating
            // Use a switch statement to determine the tip percentage
            // Calculate the total bill (bill amount + tip)
            
            // TODO: Display the bill details
            // - Original bill amount
            // - Tip percentage and amount
            // - Total bill with tip
            
            // BONUS: Ask if they want to split the bill with friends
            // If yes, ask how many people and calculate the amount per person

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

// Task 4: Game Character Creator
// Instructions:
// 1. Create a simple character creator that assigns attributes based on class choice
// 2. Use a switch statement to handle different character classes
// 3. Use if statements to apply bonuses based on other selections

using System;

namespace GameCharacterCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPG Character Creator");
            Console.WriteLine("---------------------");

            // Get character name
            Console.Write("Enter your character's name: ");
            string characterName = Console.ReadLine();

            // Get character class
            Console.WriteLine("Choose your character's class:");
            Console.WriteLine("1. Warrior (high strength, low intelligence)");
            Console.WriteLine("2. Mage (high intelligence, low strength)");
            Console.WriteLine("3. Rogue (high dexterity, balanced stats)");
            Console.WriteLine("4. Cleric (high wisdom, balanced stats)");
            Console.Write("Enter your choice (1-4): ");
            int characterClass = Convert.ToInt32(Console.ReadLine());

            // Get character race
            Console.WriteLine("Choose your character's race:");
            Console.WriteLine("1. Human (balanced bonus to all stats)");
            Console.WriteLine("2. Elf (+2 intelligence, +1 dexterity)");
            Console.WriteLine("3. Dwarf (+2 strength, +1 constitution)");
            Console.WriteLine("4. Halfling (+2 dexterity, +1 charisma)");
            Console.Write("Enter your choice (1-4): ");
            int characterRace = Convert.ToInt32(Console.ReadLine());

            // TODO: Declare variables for stats (strength, intelligence, dexterity, etc.)
            // Initialize them with base values
            
            // TODO: Use a switch statement to assign stats based on character class
            // Each class should have different starting stats
            
            // TODO: Use if statements to apply racial bonuses to the stats
            
            // TODO: Display character information including:
            // - Character name
            // - Class and Race
            // - All stats with bonuses applied
            // - A special ability based on the class

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}