# Cyber Detective: C# Code Mystery Cheatsheet

## Variables & Data Types (Environment 1)

### Common Data Types
| Type | Description | Example |
|------|-------------|---------|
| `int` | Whole numbers | `int accessLevel = 5;` |
| `double` | Decimal numbers | `double securityLevel = 9.5;` |
| `bool` | True/false values | `bool isLocked = false;` |
| `char` | Single characters | `char initial = 'C';` |
| `string` | Text | `string password = "secure123";` |

### Type Conversion
```csharp
// String to number
int number = int.Parse("42");
double value = double.Parse("3.14");

// Alternative safer parsing
if (int.TryParse("42", out int result))
{
    // Use result variable
}

// Number to string
string text = number.ToString();

// Type casting
int wholeNumber = (int)3.75;  // Result: 3
```

### Variable Declaration Best Practices
- Use descriptive variable names
- Initialize variables when declaring them
- Use the appropriate type for the data
- Consider access requirements (public, private)

## Control Structures (Environment 2)

### If-Else Statements
```csharp
if (condition)
{
    // Code executed when condition is true
}
else if (anotherCondition)
{
    // Code executed when anotherCondition is true
}
else
{
    // Code executed when all conditions are false
}
```

### Logical Operators
| Operator | Description | Example |
|----------|-------------|---------|
| `&&` | AND - Both conditions must be true | `if (isAdmin && hasPermission)` |
| `\|\|` | OR - At least one condition must be true | `if (isEmergency \|\| isOverride)` |
| `!` | NOT - Inverts a boolean value | `if (!isLocked)` |

### Switch Statements
```csharp
switch (variable)
{
    case value1:
        // Code for value1
        break;
    case value2:
        // Code for value2
        break;
    default:
        // Code for all other values
        break;
}
```

### Common Logical Patterns
- Guard clauses (early returns):
  ```csharp
  if (input == null) return false;
  ```
- Condition chaining:
  ```csharp
  if (isEmergency) 
      return "PRIORITY";
  else if (isUrgent)
      return "EXPEDITE";
  else
      return "NORMAL";
  ```

## Loops & Iterations (Environment 3)

### For Loop
```csharp
// for (initialization; condition; iteration)
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);  // Prints 0 to 9
}
```

### While Loop
```csharp
// Checks condition before executing the block
int i = 0;
while (i < 10)
{
    Console.WriteLine(i);
    i++;
}
```

### Do-While Loop
```csharp
// Always executes the block at least once
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 10);
```

### Foreach Loop
```csharp
string[] sectors = { "North", "East", "South", "West" };
foreach (string sector in sectors)
{
    Console.WriteLine(sector);
}
```

### Nested Loops
```csharp
// For iterating through a 2D grid
for (int row = 0; row < grid.Length; row++)
{
    for (int col = 0; col < grid[row].Length; col++)
    {
        // Access grid[row][col]
    }
}
```

### Loop Control
```csharp
// Break - exit the loop
for (int i = 0; i < 10; i++)
{
    if (i == 5) break;  // Exit when i equals 5
}

// Continue - skip to next iteration
for (int i = 0; i < 10; i++)
{
    if (i % 2 == 0) continue;  // Skip even numbers
    Console.WriteLine(i);  // Only prints odd numbers
}
```

## Functions & Methods (Environment 4)

### Method Declaration
```csharp
// Return type, name, and parameters
returnType MethodName(parameterType parameterName)
{
    // Method body
    return returnValue;  // Must match return type
}
```

### Common Function Patterns
```csharp
// Void method (no return value)
void PrintMessage(string message)
{
    Console.WriteLine(message);
}

// Function with return value
bool IsValidPassword(string password)
{
    return password.Length >= 8;
}

// Function with default parameter
string Encrypt(string text, int key = 3)
{
    // Encryption logic here
    return encryptedText;
}
```

### String Manipulation Functions
```csharp
// String concatenation
string fullName = firstName + " " + lastName;

// String interpolation
string greeting = $"Hello, {name}!";

// String methods
string upper = text.ToUpper();
string lower = text.ToLower();
string trimmed = text.Trim();
bool contains = text.Contains("search");
string replaced = text.Replace("old", "new");
string[] parts = text.Split(',');
```

### Common Encryption Patterns
```csharp
// Simple character substitution
char Substitute(char c, int shift)
{
    if (!char.IsLetter(c)) return c;
    
    char offset = char.IsUpper(c) ? 'A' : 'a';
    return (char)((c - offset + shift) % 26 + offset);
}

// Basic authentication code generation
string GenerateAuthCode(string data)
{
    int hash = 0;
    foreach (char c in data)
    {
        hash = (hash * 31) + c;
    }
    return hash.ToString("X8");  // 8-character hex string
}
```

## Arrays & Collections (Environment 5)

### Arrays
```csharp
// Declaration and initialization
int[] numbers = new int[5];  // Array of 5 integers
string[] names = { "Alice", "Bob", "Charlie" };  // Initialize with values

// Accessing elements (zero-based)
int first = numbers[0];
int last = numbers[numbers.Length - 1];

// Array methods
Array.Sort(numbers);  // Sort in ascending order
Array.Reverse(numbers);  // Reverse the order
int index = Array.IndexOf(numbers, searchValue);  // Find position of value
```

### Lists
```csharp
// Declaration and initialization
List<string> names = new List<string>();  // Empty list
List<int> scores = new List<int> { 90, 85, 92 };  // With values

// Common operations
names.Add("Dave");  // Add to end
names.Insert(0, "Alice");  // Insert at position
names.Remove("Bob");  // Remove specific item
names.RemoveAt(1);  // Remove at position
bool exists = names.Contains("Charlie");  // Check if exists
```

### Dictionaries
```csharp
// Key-value pairs
Dictionary<string, int> scores = new Dictionary<string, int>();
scores.Add("Alice", 95);
scores["Bob"] = 87;  // Alternative syntax

// Checking keys
if (scores.ContainsKey("Charlie"))
{
    int charlieScore = scores["Charlie"];
}

// Safe access
if (scores.TryGetValue("Dave", out int daveScore))
{
    // Key exists, use daveScore
}
```

### LINQ Operations (Language Integrated Query)
```csharp
using System.Linq;

// Filtering
int[] evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();

// Sorting
var sorted = names.OrderBy(n => n);
var sortedDesc = scores.OrderByDescending(p => p.Value);

// Projection
var firstLetters = names.Select(n => n[0]).ToArray();

// Aggregation
int sum = numbers.Sum();
double average = numbers.Average();
int max = numbers.Max();
```

### Common Collection Operations
```csharp
// Filtering with conditions
List<string> admins = users.Where(u => u.Contains("admin")).ToList();

// Finding elements
string first = names.FirstOrDefault(n => n.StartsWith("A"));

// Combining collections
List<string> combined = listA.Concat(listB).ToList();

// Counting with conditions
int count = numbers.Count(n => n > 100);
```

## System Utilities

### Console Input/Output
```csharp
// Output
Console.WriteLine("Message");  // With newline
Console.Write("No newline");   // Without newline

// Color output
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Success!");
Console.ResetColor();  // Reset to default

// Input
string input = Console.ReadLine();
ConsoleKeyInfo key = Console.ReadKey();
```

### DateTime Operations
```csharp
// Current time
DateTime now = DateTime.Now;
DateTime today = DateTime.Today;  // Just the date, time is 00:00:00

// Creating specific dates
DateTime date = new DateTime(2023, 4, 15);  // April 15, 2023

// Formatting
string formatted = now.ToString("yyyy-MM-dd HH:mm:ss");

// Date calculations
DateTime tomorrow = today.AddDays(1);
DateTime lastWeek = today.AddDays(-7);
TimeSpan difference = date1.Subtract(date2);
```

### Random Number Generation
```csharp
Random rng = new Random();

// Random integer between 0 and max-1
int dice = rng.Next(6);  // 0-5

// Random integer between min and max-1
int roll = rng.Next(1, 7);  // 1-6

// Random double between 0.0 and 1.0
double probability = rng.NextDouble();
```

## Debugging Tips

### Common Error Types
1. **Syntax Errors**: Missing semicolons, brackets, or typos
2. **Runtime Errors**: NullReferenceException, IndexOutOfRangeException
3. **Logic Errors**: Code runs but produces incorrect results

### Debugging Techniques
```csharp
// Print debugging
Console.WriteLine($"DEBUG: x = {x}, y = {y}");

// Condition checking
if (x < 0 || y < 0)
{
    Console.WriteLine("ERROR: Negative values not allowed");
    return;
}

// Tracing a list
foreach (var item in list)
{
    Console.WriteLine($"Item: {item}");
}
```

### Common Pitfalls
- **Off-by-one errors**: Check loop boundaries (< vs <=)
- **Null references**: Initialize objects before use
- **Type mismatches**: Ensure compatible types in operations
- **Infinite loops**: Verify loop termination conditions
- **Case sensitivity**: C# is case-sensitive (count != Count)

## Quick Reference for Cyber Detective Challenges

### Environment 1: Compromised Network
- Focus on proper variable declarations and initializations
- Check data type compatibility
- Use correct type conversion methods

### Environment 2: Logic Gateway
- Check logical operators (&&, ||, !)
- Verify if-else flow and conditions
- Ensure proper switch-case structure

### Environment 3: Automated Defense System
- Verify loop boundaries and conditions
- Check increment/decrement operations
- Ensure loops terminate properly
- Pay attention to nested loop structure

### Environment 4: Encryption Vault
- Focus on function parameters and return types
- Implement string manipulation correctly
- Check character conversions
- Maintain data integrity during transformations

### Environment 5: Core System Access
- Work with different collection types appropriately
- Implement filtering and transformation operations
- Manage key-value relationships carefully
- Use appropriate collection methods for specific tasks