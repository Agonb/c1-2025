# C# Beginner Cheatsheet

## Program Structure

Every C# program starts with this basic structure:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        // Your code goes here!
        Console.WriteLine("Hello, World!");
    }
}
```

## Console Input and Output

### Displaying Text
```csharp
// Print text with a new line at the end
Console.WriteLine("Hello!");

// Print text without a new line
Console.Write("Enter your name: ");

// Print with values inserted (string interpolation)
Console.WriteLine($"Hello, {name}!");

// Print with multiple values
Console.WriteLine($"The sum of {a} and {b} is {a + b}");
```

### Getting User Input
```csharp
// Read a line of text from the user
string name = Console.ReadLine();

// Read and convert to a number
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// Read and convert to a decimal
Console.Write("Enter price: ");
double price = double.Parse(Console.ReadLine());
```

## Variables and Data Types

### Common Data Types
```csharp
int age = 25;             // Whole numbers
double price = 19.99;     // Decimal numbers
string name = "Emma";     // Text
bool isStudent = true;    // True/False values
char grade = 'A';         // Single character
```

### Variable Declaration and Assignment
```csharp
// Declare without initial value
int score;

// Assign a value later
score = 95;

// Declare and assign at once
int highScore = 100;

// Change the value
highScore = 105;
```

## Basic Operations

### Math Operations
```csharp
int a = 10;
int b = 3;

int sum = a + b;        // Addition: 13
int difference = a - b; // Subtraction: 7
int product = a * b;    // Multiplication: 30
int quotient = a / b;   // Division: 3 (integer division)
int remainder = a % b;  // Modulo (remainder): 1

// Increment/decrement
a++;  // Increase by 1 (a is now 11)
b--;  // Decrease by 1 (b is now 2)
```

### String Operations
```csharp
string firstName = "John";
string lastName = "Smith";

// Combine strings (concatenation)
string fullName = firstName + " " + lastName;  // "John Smith"

// Get string length
int length = firstName.Length;  // 4

// Access a character by index (zero-based)
char firstChar = firstName[0];  // 'J'

// Convert to uppercase/lowercase
string upper = firstName.ToUpper();  // "JOHN"
string lower = lastName.ToLower();   // "smith"
```

## Conditional Statements

### If-Else Statement
```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (score >= 80)
{
    Console.WriteLine("Grade: B");
}
else if (score >= 70)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Grade: F");
}
```

### Comparison Operators
```csharp
x == y  // Equal to
x != y  // Not equal to
x > y   // Greater than
x < y   // Less than
x >= y  // Greater than or equal to
x <= y  // Less than or equal to
```

### Logical Operators
```csharp
// AND: both conditions must be true
if (age >= 18 && hasID == true)
{
    Console.WriteLine("Can enter");
}

// OR: at least one condition must be true
if (isMember || hasInvitation)
{
    Console.WriteLine("Welcome!");
}

// NOT: inverts a condition
if (!isClosed)  // Same as: if (isClosed == false)
{
    Console.WriteLine("Shop is open");
}
```

## Loops

### For Loop
```csharp
// Count from 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

// Count backwards from 5 to 1
for (int i = 5; i >= 1; i--)
{
    Console.WriteLine(i);
}
```

### While Loop
```csharp
// Keep going while a condition is true
int count = 1;
while (count <= 5)
{
    Console.WriteLine(count);
    count++;
}
```

### Do-While Loop
```csharp
// Always runs at least once
int num = 1;
do
{
    Console.WriteLine(num);
    num++;
} while (num <= 5);
```

### Breaking Out of Loops
```csharp
// Exit the loop early with break
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;  // Exit when i reaches 5
    }
    Console.WriteLine(i);
}

// Skip the current iteration with continue
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;  // Skip 3
    }
    Console.WriteLine(i);
}
```

## Arrays

### Creating Arrays
```csharp
// Create and initialize an array
int[] scores = {95, 80, 75, 90, 85};

// Create an empty array of a specific size
string[] names = new string[3];

// Set values by index
names[0] = "Alice";
names[1] = "Bob";
names[2] = "Charlie";
```

### Accessing Array Elements
```csharp
// Get the first element (index 0)
int firstScore = scores[0];  // 95

// Get the last element
int lastScore = scores[scores.Length - 1];  // 85

// Get the array length
int count = scores.Length;  // 5
```

### Looping Through Arrays
```csharp
// Using a for loop
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"Score {i+1}: {scores[i]}");
}

// Using foreach (easier but can't modify elements)
foreach (int score in scores)
{
    Console.WriteLine($"Score: {score}");
}
```

## Common String Methods

```csharp
string text = "Hello, World!";

// Check if contains a substring
bool contains = text.Contains("World");  // true

// Replace part of a string
string newText = text.Replace("World", "Friends");  // "Hello, Friends!"

// Split a string into parts
string data = "Apple,Banana,Cherry";
string[] fruits = data.Split(',');  // ["Apple", "Banana", "Cherry"]

// Join array elements into a string
string combined = string.Join(" | ", fruits);  // "Apple | Banana | Cherry"

// Check start/end
bool startsWithHello = text.StartsWith("Hello");  // true
bool endsWithWorld = text.EndsWith("World!");     // true

// Remove whitespace
string padded = "  trim me  ";
string trimmed = padded.Trim();  // "trim me"
```

## Character Methods

```csharp
// Character type checking
char.IsDigit('5');      // true
char.IsLetter('A');     // true
char.IsUpper('A');      // true
char.IsLower('a');      // true
char.IsWhiteSpace(' '); // true

// Character conversion
char.ToUpper('a');      // 'A'
char.ToLower('A');      // 'a'
```

## Random Numbers

```csharp
// Create a random number generator
Random random = new Random();

// Random integer between 1 and 100 (inclusive)
int randomNumber = random.Next(1, 101);

// Random integer between 0 and 9 (inclusive)
int digit = random.Next(10);

// Random double between 0.0 and 1.0
double randomValue = random.NextDouble();
```

## Converting Between Types

```csharp
// String to number
int num = int.Parse("123");
double price = double.Parse("19.99");

// Number to string
string str1 = number.ToString();
string str2 = 42.ToString();

// With error handling
if (int.TryParse(input, out int result))
{
    // Conversion succeeded, use result
    Console.WriteLine($"Parsed: {result}");
}
else
{
    // Conversion failed
    Console.WriteLine("Invalid number");
}
```

## Common Errors and Fixes

### Cannot Convert Error
```
Cannot implicitly convert type 'string' to 'int'
```
**Fix**: Use `int.Parse()` to convert strings to numbers:
```csharp
int age = int.Parse(Console.ReadLine());
```

### Index Out of Range Error
```
Index was outside the bounds of the array
```
**Fix**: Make sure your index is within array bounds (0 to Length-1):
```csharp
// Correct way to access the last element
int last = array[array.Length - 1];
```

### Object Reference Error
```
Object reference not set to an instance of an object
```
**Fix**: Make sure the object is initialized before using it:
```csharp
// Initialize the array first
string[] names = new string[3];
// Then use it
names[0] = "Alice";
```

### Format Exception
```
Input string was not in a correct format
```
**Fix**: Ensure the string can be converted to the desired type:
```csharp
// Better approach with error handling
if (int.TryParse(input, out int number))
{
    // Use number safely
}
else
{
    Console.WriteLine("Please enter a valid number");
}
```

## Tips for Success

1. **Read the error messages** - They give clues about what's wrong
2. **Check your spelling** - C# is case-sensitive
3. **Use meaningful variable names** - `playerScore` is better than `x`
4. **Indent your code** - Makes it easier to read
5. **Test frequently** - Run your code after adding a few lines
6. **Break problems down** - Solve one piece at a time
7. **Use comments** - Explain what your code does
8. **Don't panic!** - Everyone makes mistakes when coding