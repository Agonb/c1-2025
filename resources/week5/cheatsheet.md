# C# Loops Cheatsheet

## Loop Types

### For Loop
```csharp
for (initializer; condition; iterator)
{
    // Code to execute repeatedly
}
```

**Example:**
```csharp
// Count from 1 to 5
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

**Components:**
- **Initializer**: Runs once before the loop starts (e.g., `int i = 1`)
- **Condition**: Checked before each iteration; loop continues while true (e.g., `i <= 5`)
- **Iterator**: Runs after each iteration (e.g., `i++`)

### While Loop
```csharp
while (condition)
{
    // Code to execute repeatedly
}
```

**Example:**
```csharp
// Count from 1 to 5
int i = 1;
while (i <= 5)
{
    Console.WriteLine(i);
    i++;
}
```

**Key Points:**
- Checks condition before executing code
- If initial condition is false, loop body never executes
- You must update the condition variable inside the loop

### Do-While Loop
```csharp
do
{
    // Code to execute repeatedly
} while (condition);
```

**Example:**
```csharp
// Count from 1 to 5
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 5);
```

**Key Points:**
- Executes code first, then checks condition
- Always runs at least once
- Semicolon required after the condition

## Loop Control Statements

### Break
```csharp
// Exit loop immediately
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        break; // Exits when i equals 5
    Console.WriteLine(i);
}
```

### Continue
```csharp
// Skip current iteration
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
        continue; // Skips even numbers
    Console.WriteLine(i);
}
```

## Common Loop Patterns

### Looping Through Arrays
```csharp
int[] numbers = { 2, 4, 6, 8, 10 };

// Using for loop
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

// Using foreach (preview of later topic)
foreach (int num in numbers)
{
    Console.WriteLine(num);
}
```

### Nested Loops
```csharp
// Print a 3x3 grid
for (int i = 1; i <= 3; i++)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"({i},{j})");
    }
}
```

### Infinite Loop (with exit condition)
```csharp
while (true)
{
    Console.Write("Enter 'exit' to quit: ");
    string input = Console.ReadLine();
    
    if (input.ToLower() == "exit")
        break;
}
```

### Input Validation
```csharp
int number;
bool isValid;

do
{
    Console.Write("Enter a number between 1-10: ");
    isValid = int.TryParse(Console.ReadLine(), out number) 
              && number >= 1 && number <= 10;
              
    if (!isValid)
        Console.WriteLine("Invalid input! Try again.");
        
} while (!isValid);
```

## When to Use Each Loop Type

| Loop Type | Best Used When |
|-----------|----------------|
| For       | - You know the exact number of iterations<br>- Iterating through arrays or collections<br>- Need a counter variable |
| While     | - Number of iterations is unknown<br>- Loop depends on external conditions<br>- Early exit may be needed |
| Do-While  | - Code must execute at least once<br>- Input validation<br>- Menu systems requiring initial display |

## Common Pitfalls to Avoid

1. **Infinite Loops**: Always ensure the condition will eventually become false
   ```csharp
   // BAD: i never changes
   while (i < 10)
   {
       Console.WriteLine(i);
       // Missing i++
   }
   ```

2. **Off-by-One Errors**: Be careful with your loop bounds
   ```csharp
   // Prints 0-9, not 1-10
   for (int i = 0; i < 10; i++)
   {
       Console.WriteLine(i);
   }
   ```

3. **Modifying Loop Variables Inside the Loop**
   ```csharp
   // BAD: Unpredictable behavior
   for (int i = 0; i < 10; i++)
   {
       Console.WriteLine(i);
       if (i == 5)
           i = i + 2; // Dangerous!
   }
   ```

4. **Forgetting Curly Braces**: Without braces, only the next line is part of the loop
   ```csharp
   // BAD: Only prints numbers, "Done!" prints once
   for (int i = 1; i <= 3; i++)
       Console.WriteLine(i);
       Console.WriteLine("Done!"); // Not part of the loop!
   ```

## Performance Tips

1. Avoid unnecessary calculations in the loop condition
2. Move invariant operations outside the loop
3. Use `break` to exit early when appropriate
4. Consider loop unrolling for simple, performance-critical loops
5. Use the correct loop type for your situation

## Debugging Tips

1. Print counter variables to trace execution
2. Add temporary output to track loop progress
3. Use Visual Studio's debugging tools (breakpoints, watch window)
4. Start with small iteration counts when testing