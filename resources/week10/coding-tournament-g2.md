# Beginner-Friendly C# Coding Tournament 
## Student Handout - Group 2

Welcome to the Coding Tournament! Today you'll solve fun programming challenges that let you practice your C# skills in a friendly competition. This handout contains all the information you need to participate.

## Tournament Overview

### Structure
- **3 Rounds** of challenges (20 minutes each)
- **4 Challenges** per round (varying difficulty)
- **Team-based** (2-3 students per team)
- **Points** awarded for each solution
- Short breaks between rounds for review

### Scoring
- **Level 1 Challenge**: 5 points each (super easy)
- **Level 2 Challenge**: 10 points each (moderate)
- **Level 3 Challenge**: 15 points each (tricky)
- **Bonus Points**: +3 points for especially creative or elegant solutions

### How to Participate
1. Form a team of 2-3 students
2. Choose a fun team name
3. In each round, work on the challenges in any order you prefer
4. Complete as many challenges as you can within the time limit
5. Submit your solutions as instructed by your teacher

## Tips for Success

- **Read each problem carefully** before starting to code
- **Plan your solution** before typing
- **Test your code** with the example inputs
- **Ask for hints** if you get stuck (no penalty!)
- **Take turns** writing code with your teammates
- **Comment your code** to explain your thinking
- **Have fun!** Remember, the goal is learning, not just winning

---

# Challenge Problems

## ROUND 1: WARM-UP CHALLENGES

### Challenge 1-1: GREETING GENERATOR (Level 1 - 5 points)
Write a program that asks for the time of day (morning, afternoon, or evening) and the user's name, then prints an appropriate greeting.

**Example:**
```
Input: "morning" and "Jamie"
Output: "Good morning, Jamie! Have a great day!"
```

**Requirements:**
- Ask for the time of day and the user's name
- Print an appropriate greeting based on the time of day
- Include the user's name in the greeting

### Challenge 1-2: AGE CALCULATOR (Level 1 - 5 points)
Write a program that asks for the user's birth year and calculates their age in the current year.

**Example:**
```
Input: 2005 (assuming current year is 2025)
Output: "You are 20 years old this year."
```

**Requirements:**
- Ask for the birth year using Console.ReadLine()
- Calculate the age (current year - birth year)
- Display the result in a complete sentence

### Challenge 1-3: TIP CALCULATOR (Level 2 - 10 points)
Write a program that calculates the tip for a restaurant bill.

**Example:**
```
Input: Bill amount: 50, Tip percentage: 15
Output: "For a $50.00 bill, a 15% tip is $7.50. Total amount: $57.50"
```

**Requirements:**
- Ask for the bill amount and tip percentage
- Calculate the tip amount (bill * percentage / 100)
- Calculate the total amount (bill + tip)
- Display the results formatted with 2 decimal places

### Challenge 1-4: GRADE CALCULATOR (Level 3 - 15 points)
Write a program that takes three test scores and calculates the average grade and letter grade.

**Example:**
```
Input: 85, 90, 78
Output: "Average score: 84.33, Letter grade: B"
```

**Requirements:**
- Ask for three test scores
- Calculate the average score
- Determine the letter grade based on:
  - A: 90-100
  - B: 80-89
  - C: 70-79
  - D: 60-69
  - F: below 60
- Display the average score (with 2 decimal places) and letter grade

## ROUND 2: LOGIC AND LOOPS

### Challenge 2-1: EVEN NUMBER COUNTER (Level 1 - 5 points)
Write a program that counts and displays all even numbers from 2 to a given limit.

**Example:**
```
Input: 10
Output: "Even numbers: 2 4 6 8 10"
```

**Requirements:**
- Ask the user for a positive number as the upper limit
- Use a loop to find all even numbers from 2 to the limit
- Display the even numbers with spaces between them

### Challenge 2-2: DIGIT COUNTER (Level 1 - 5 points)
Write a program that counts the number of digits in an integer.

**Example:**
```
Input: 3542
Output: "The number 3542 has 4 digits."
```

**Requirements:**
- Ask for a positive integer
- Count how many digits it has
- Display the result

### Challenge 2-3: COUNTDOWN TIMER (Level 2 - 10 points)
Write a program that counts down from a specified number to 1, and then prints "Blast off!"

**Example:**
```
Input: 5
Output:
5...
4...
3...
2...
1...
Blast off!
```

**Requirements:**
- Ask for a positive starting number
- Print each number in the countdown with "..." after it
- Print "Blast off!" after reaching 1
- Add a small delay between numbers (using Thread.Sleep())

### Challenge 2-4: NUMBER PATTERN (Level 3 - 15 points)
Write a program that prints a pattern of numbers in a triangular format based on user input.

**Example:**
```
Input: 4
Output:
1
22
333
4444
```

**Requirements:**
- Ask for a positive integer N
- Print N lines forming a pattern
- Each line i should show the number i repeated i times
- Format the output as shown in the example

## ROUND 3: ARRAYS AND STRINGS

### Challenge 3-1: VOWEL COUNTER (Level 1 - 5 points)
Write a program that counts the number of vowels (a, e, i, o, u) in a word.

**Example:**
```
Input: "programming"
Output: "The word 'programming' has 3 vowels."
```

**Requirements:**
- Ask for a word using Console.ReadLine()
- Count the vowels (a, e, i, o, u) in the word (case insensitive)
- Display the count in a complete sentence

### Challenge 3-2: INITIALS GENERATOR (Level 1 - 5 points)
Write a program that takes a full name and generates the initials.

**Example:**
```
Input: "John Michael Smith"
Output: "Initials: JMS"
```

**Requirements:**
- Ask for a full name
- Extract the first letter of each part of the name
- Convert the letters to uppercase
- Display the initials

### Challenge 3-3: NUMBER FINDER (Level 2 - 10 points)
Write a program that finds the largest and smallest numbers in an array of 5 integers.

**Example:**
```
Input: 12, 5, 27, 8, 15
Output: "Smallest number: 5, Largest number: 27"
```

**Requirements:**
- Ask the user to enter 5 numbers one at a time
- Store the numbers in an array
- Find the smallest and largest numbers
- Display both results

### Challenge 3-4: WORD CAPITALIZER (Level 3 - 15 points)
Write a program that capitalizes the first letter of each word in a sentence.

**Example:**
```
Input: "welcome to c# programming"
Output: "Welcome To C# Programming"
```

**Requirements:**
- Ask the user to enter a sentence
- Capitalize the first letter of each word
- Keep the rest of the letters in their original case
- Handle special cases like "c#" correctly (don't change "#" to uppercase)
- Display the capitalized sentence

## BONUS CHALLENGE (For early finishers)

### WORD GUESSING GAME (Level 3 - 15 points)
Create a simple word guessing game where:
- The program has a list of at least 5 words
- It randomly selects one of the words
- Shows the word as underscores (one for each letter)
- The player guesses one letter at a time
- If the letter is in the word, reveal all occurrences
- The game ends when the entire word is revealed

**Example:**
```
Word to guess: "APPLE"
Initial display: "_ _ _ _ _"

Player guesses: "A"
Display: "A _ _ _ _"

Player guesses: "P"
Display: "A P P _ _"

...and so on until the word is complete
```

**Requirements:**
- Create an array with at least 5 words
- Randomly select a word
- Use a loop to allow multiple guesses
- Track and display the current state of the word
- End the game when the word is fully revealed

---

# C# Quick Reference

## Reading Input
```csharp
// Read text
string input = Console.ReadLine();

// Read and convert to number
int number = int.Parse(Console.ReadLine());
double value = double.Parse(Console.ReadLine());
```

## Writing Output
```csharp
// Simple output
Console.WriteLine("Hello!");

// With variables
Console.WriteLine($"The answer is {result}");
```

## Loops
```csharp
// For loop
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// While loop
int count = 1;
while (count <= 5)
{
    Console.WriteLine(count);
    count++;
}
```

## Conditions
```csharp
if (number > 0)
{
    Console.WriteLine("Positive");
}
else if (number < 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Zero");
}
```

## Arrays
```csharp
// Create array
int[] numbers = new int[5];

// Set values
numbers[0] = 10;
numbers[1] = 20;

// Get array length
int length = numbers.Length;
```

## String Operations
```csharp
// Get string length
int length = text.Length;

// Get character at position
char firstChar = text[0];

// Convert to uppercase/lowercase
string upper = text.ToUpper();
string lower = text.ToLower();

// Split string
string[] words = text.Split(' ');
```

## Random Numbers
```csharp
// Create random number generator
Random random = new Random();

// Generate random number between 1 and 100
int number = random.Next(1, 101);
```

Good luck and have fun! Remember, the goal is to learn and enjoy coding together.