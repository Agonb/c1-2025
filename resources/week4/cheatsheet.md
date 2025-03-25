# C# Control Structures Cheatsheet

## If-Else Statements

### Basic If Statement
```csharp
if (condition)
{
    // Code to execute when condition is true
}
```

### If-Else Statement
```csharp
if (condition)
{
    // Code to execute when condition is true
}
else
{
    // Code to execute when condition is false
}
```

### If-Else-If Ladder
```csharp
if (condition1)
{
    // Code to execute when condition1 is true
}
else if (condition2)
{
    // Code to execute when condition1 is false and condition2 is true
}
else if (condition3)
{
    // Code to execute when condition1 and condition2 are false and condition3 is true
}
else
{
    // Code to execute when all conditions are false
}
```

### Ternary Operator (Shorthand for If-Else)
```csharp
variable = (condition) ? valueIfTrue : valueIfFalse;
```

Example:
```csharp
string status = (age >= 18) ? "Adult" : "Minor";
```

## Switch Statements

### Basic Switch
```csharp
switch (expression)
{
    case value1:
        // Code to execute when expression equals value1
        break;
    case value2:
        // Code to execute when expression equals value2
        break;
    default:
        // Code to execute when no case matches
        break;
}
```

### Switch with Multiple Cases
```csharp
switch (expression)
{
    case value1:
    case value2:
        // Code to execute when expression equals value1 OR value2
        break;
    case value3:
        // Code to execute when expression equals value3
        break;
    default:
        // Code to execute when no case matches
        break;
}
```

## Common Operators for Conditions

| Operator | Description               | Example                |
|----------|---------------------------|------------------------|
| ==       | Equal to                  | if (x == 5)            |
| !=       | Not equal to              | if (x != 5)            |
| >        | Greater than              | if (x > 5)             |
| <        | Less than                 | if (x < 5)             |
| >=       | Greater than or equal to  | if (x >= 5)            |
| <=       | Less than or equal to     | if (x <= 5)            |
| &&       | Logical AND               | if (x > 5 && x < 10)   |
| \|\|     | Logical OR                | if (x < 5 \|\| x > 10) |
| !        | Logical NOT               | if (!isTrue)           |

## Nested Conditions

```csharp
if (outerCondition)
{
    if (innerCondition)
    {
        // Code to execute when both conditions are true
    }
    else
    {
        // Code to execute when outerCondition is true but innerCondition is false
    }
}
```

## Best Practices

1. **Use braces** even for single-line blocks (improves readability and prevents errors):
   ```csharp
   // Good practice
   if (condition) {
       DoSomething();
   }
   
   // Avoid this
   if (condition)
       DoSomething();
   ```

2. **Simplify complex conditions** using variables:
   ```csharp
   // Hard to read
   if (age >= 18 && (income > 30000 || hasParentalConsent) && !hasRestrictions)

   // Better approach
   bool isAdult = age >= 18;
   bool hasSufficientIncome = income > 30000 || hasParentalConsent;
   bool isEligible = isAdult && hasSufficientIncome && !hasRestrictions;
   
   if (isEligible)
   ```

3. **Use switch** instead of long if-else chains when comparing a single variable against multiple constants

4. **Always include a default case** in switch statements

5. **Be careful with equality checks** for floating-point numbers (use a small epsilon/tolerance)

## Common Mistakes to Avoid

1. Using `=` (assignment) instead of `==` (comparison) in conditions
   ```csharp
   // Wrong (assigns value 5 to x)
   if (x = 5) { ... }
   
   // Correct (checks if x equals 5)
   if (x == 5) { ... }
   ```

2. Forgetting `break` statements in switch cases (causes fall-through)

3. Overly complex nested conditions (consider refactoring)

4. Off-by-one errors when checking ranges:
   ```csharp
   // Checks 0-99 (not 100)
   if (number >= 0 && number < 100) { ... }
   
   // Checks 0-100
   if (number >= 0 && number <= 100) { ... }
   ```

5. Using String.Equals incorrectly:
   ```csharp
   // Wrong (throws exception if input is null)
   if (input.Equals("yes")) { ... }
   
   // Better (null-safe)
   if ("yes".Equals(input)) { ... }
   
   // Alternative
   if (input != null && input == "yes") { ... }
   ```

## Code Snippets for Common Tasks

### Input Validation
```csharp
Console.Write("Enter your age: ");
int age;
while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 120)
{
    Console.Write("Invalid input. Please enter a valid age (0-120): ");
}
```

### Grade Assignment
```csharp
string grade;
if (score >= 90) grade = "A";
else if (score >= 80) grade = "B";
else if (score >= 70) grade = "C";
else if (score >= 60) grade = "D";
else grade = "F";
```

### Menu Selection
```csharp
Console.WriteLine("1. New Game");
Console.WriteLine("2. Load Game");
Console.WriteLine("3. Settings");
Console.WriteLine("4. Exit");
Console.Write("Enter your choice: ");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1:
        StartNewGame();
        break;
    case 2:
        LoadGame();
        break;
    case 3:
        ShowSettings();
        break;
    case 4:
        Exit();
        break;
    default:
        Console.WriteLine("Invalid option!");
        break;
}
```