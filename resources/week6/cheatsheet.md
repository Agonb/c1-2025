# C# Functions Cheatsheet

## Function Declaration

```csharp
// Basic function structure
returnType FunctionName(parameterType parameterName)
{
    // Function body
    return value; // If non-void function
}
```

## Common Function Types

```csharp
// Void function (no return value)
void DisplayMessage(string message)
{
    Console.WriteLine(message);
}

// Function that returns a value
int AddNumbers(int a, int b)
{
    return a + b;
}

// Static function (called directly from class)
public static double CalculateAverage(int[] numbers)
{
    return numbers.Sum() / (double)numbers.Length;
}
```

## Parameter Types

```csharp
// Basic parameters (passed by value)
void ModifyValue(int x)
{
    x = 10; // Only changes local copy
}

// Reference parameters (ref)
void ModifyReference(ref int x)
{
    x = 10; // Changes original variable
}
int num = 5;
ModifyReference(ref num); // num is now 10

// Output parameters (out)
void GetValues(out int x, out int y)
{
    x = 10; // Must assign value
    y = 20; // Must assign value
}
int a, b;
GetValues(out a, out b); // a=10, b=20

// Optional parameters (with default values)
void Configure(string name, bool enabled = true, int priority = 1)
{
    // Implementation
}
Configure("Service"); // Uses defaults for enabled and priority
```

## Named Arguments

```csharp
void SendEmail(string to, string subject, string body, bool highPriority = false)
{
    // Implementation
}

// Using named arguments (can be in any order)
SendEmail(
    subject: "Meeting Reminder",
    body: "Don't forget our meeting today",
    to: "colleague@example.com",
    highPriority: true
);
```

## Return Values

```csharp
// Single return value
string FormatName(string first, string last)
{
    return $"{last}, {first}";
}

// Multiple return values using tuple (C# 7+)
(int min, int max, double average) AnalyzeData(int[] data)
{
    return (
        data.Min(),
        data.Max(),
        data.Average()
    );
}

// Using the returned tuple
var results = AnalyzeData(new[] { 1, 5, 3, 9, 7 });
Console.WriteLine($"Min: {results.min}, Max: {results.max}, Avg: {results.average}");

// Discarding unwanted tuple values
var (_, onlyMax, _) = AnalyzeData(new[] { 1, 5, 3, 9, 7 });
```

## Method Overloading

```csharp
// Same method name, different parameters
int Add(int a, int b)
{
    return a + b;
}

double Add(double a, double b)
{
    return a + b;
}

string Add(string a, string b)
{
    return a + b;
}
```

## Extension Methods

```csharp
// Must be in a static class
public static class StringExtensions
{
    // Extension method for string type
    public static bool IsValidEmail(this string text)
    {
        // Simplified validation
        return text != null && text.Contains("@") && text.Contains(".");
    }
}

// Using the extension method
string email = "user@example.com";
bool isValid = email.IsValidEmail();
```

## Lambda Functions (Anonymous Methods)

```csharp
// Lambda expression
Func<int, int, int> add = (a, b) => a + b;
int result = add(5, 3); // result = 8

// Using lambda with LINQ
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
```

## Common Mistakes to Avoid

1. Forgetting to return a value in non-void functions
2. Not handling all possible code paths in returns
3. Unintended side effects when modifying parameters
4. Function does too much (violates single responsibility)
5. Inconsistent naming conventions
6. Poor/missing parameter validation

## Best Practices

1. Functions should have a single responsibility
2. Name functions clearly based on what they do
3. Keep functions relatively short (15-30 lines is a good target)
4. Validate input parameters at the start
5. Use XML comments to document parameters and return values
6. Be consistent with your style and naming conventions