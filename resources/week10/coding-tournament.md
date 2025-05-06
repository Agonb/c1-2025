# Beginner-Friendly C# Coding Tournament 
## Student Handout

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

### Challenge 1-1: HELLO PROGRAMMER (Level 1 - 5 points)
Write a program that asks for the programmer's name and prints a personalized welcome message.

**Example:**
```
Input: "Alex"
Output: "Hello, Alex! Ready to code?"
```

**Requirements:**
- Ask for the user's name using Console.ReadLine()
- Print a welcome message that includes their name
- Keep it simple!

### Challenge 1-2: NUMBER DOUBLER (Level 1 - 5 points)
Write a program that takes a number as input and prints double its value.

**Example:**
```
Input: 7
Output: "Double of 7 is 14"
```

**Requirements:**
- Ask for a number using Console.ReadLine()
- Convert the input to a number using int.Parse()
- Calculate and display the doubled value

### Challenge 1-3: TEMPERATURE CONVERTER (Level 2 - 10 points)
Write a program that converts Celsius temperature to Fahrenheit.
Formula: F = C * 9/5 + 32

**Example:**
```
Input: 25
Output: "25°C is equal to 77°F"
```

**Requirements:**
- Ask for a temperature in Celsius
- Convert it to Fahrenheit using the formula
- Display the result with both units

### Challenge 1-4: NUMBER CLASSIFIER (Level 3 - 15 points)
Write a program that takes a number and classifies it as:
- "Even Positive" if it's an even number greater than zero
- "Odd Positive" if it's an odd number greater than zero
- "Even Negative" if it's an even number less than zero
- "Odd Negative" if it's an odd number less than zero
- "Zero" if it equals zero

**Example:**
```
Input: -4
Output: "-4 is Even Negative"
```

**Requirements:**
- Get a number from the user
- Use if/else statements to classify the number
- Check both sign (positive/negative) and parity (odd/even)
- Display the result with the original number

## ROUND 2: LOGIC AND LOOPS

### Challenge 2-1: COUNTING MACHINE (Level 1 - 5 points)
Write a program that counts from 1 to a number provided by the user, printing each number on a new line.

**Example:**
```
Input: 5
Output:
1
2
3
4
5
```

**Requirements:**
- Ask the user for a positive number
- Use a loop to count from 1 to that number
- Print each number on a new line

### Challenge 2-2: SUM CALCULATOR (Level 1 - 5 points)
Write a program that calculates the sum of all numbers from 1 to N, where N is provided by the user.

**Example:**
```
Input: 5
Output: "The sum of numbers from 1 to 5 is 15"
```

**Requirements:**
- Ask for a positive integer N
- Calculate the sum: 1 + 2 + ... + N
- Display the result

### Challenge 2-3: MULTIPLICATION TABLE (Level 2 - 10 points)
Write a program that prints a multiplication table for a number provided by the user.

**Example:**
```
Input: 3
Output:
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
3 x 4 = 12
3 x 5 = 15
```

**Requirements:**
- Ask for a number
- Print its multiplication table from 1 to 5
- Format the output as shown in the example

### Challenge 2-4: FIZZBUZZ (Level 3 - 15 points)
Write a program that prints numbers from 1 to N, where N is provided by the user.
But for multiples of 3, print "Fizz" instead of the number,
for multiples of 5, print "Buzz", and for multiples of both 3 and 5, print "FizzBuzz".

**Example:**
```
Input: 15
Output:
1
2
Fizz
4
Buzz
Fizz
7
8
Fizz
Buzz
11
Fizz
13
14
FizzBuzz
```

**Requirements:**
- Ask for a positive integer N
- Use a loop to iterate from 1 to N
- Apply the FizzBuzz rules for each number
- Print each result on a new line

## ROUND 3: ARRAYS AND STRINGS

### Challenge 3-1: WORD REVERSER (Level 1 - 5 points)
Write a program that takes a word as input and prints it reversed.

**Example:**
```
Input: "hello"
Output: "Reversed: olleh"
```

**Requirements:**
- Ask for a word using Console.ReadLine()
- Reverse the characters in the word
- Print the reversed word

### Challenge 3-2: NAME FORMATTER (Level 1 - 5 points)
Write a program that asks for a first name and a last name separately, then displays them in "Last, First" format.

**Example:**
```
Input: "John" and "Smith"
Output: "Name formatted: Smith, John"
```

**Requirements:**
- Ask for first name and last name separately
- Combine them in the format "Last, First"
- Display the formatted name

### Challenge 3-3: ARRAY AVERAGER (Level 2 - 10 points)
Write a program that calculates the average of 5 numbers entered by the user.

**Example:**
```
Input: 10, 20, 30, 40, 50
Output: "The average is 30"
```

**Requirements:**
- Ask the user to enter 5 numbers one at a time
- Store the numbers in an array
- Calculate the average of the numbers
- Display the result

### Challenge 3-4: PASSWORD VALIDATOR (Level 3 - 15 points)
Write a program that checks if a password is strong enough based on these rules:
- At least 8 characters long
- Contains at least one digit
- Contains at least one uppercase letter

**Example 1:**
```
Input: "Password1"
Output: "Password is strong!"
```

**Example 2:**
```
Input: "password"
Output: "Password is weak! Missing: uppercase letter, digit"
```

**Requirements:**
- Ask the user to enter a password
- Check all three password requirements
- If the password is strong, print a success message
- If not, tell the user which requirements were not met

## BONUS CHALLENGE (For early finishers)

### NUMBER GUESSING GAME (Level 3 - 15 points)
Create a simple number guessing game where:
- The program "thinks" of a number between 1 and 100
- The player has to guess the number
- After each guess, the program gives a hint: "too high" or "too low"
- The game ends when the player guesses correctly

**Requirements:**
- Generate a random number between 1 and 100
- Use a loop to allow multiple guesses
- Give appropriate hints after each guess
- Count and display the number of guesses it took

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

Good luck and have fun! Remember, the goal is to learn and enjoy coding together.