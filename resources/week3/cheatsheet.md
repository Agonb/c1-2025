# C# Operators Quick Reference Guide

## Arithmetic Operators
| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `+` | Addition | `5 + 3` | `8` |
| `-` | Subtraction | `5 - 3` | `2` |
| `*` | Multiplication | `5 * 3` | `15` |
| `/` | Division | `15 / 3` | `5` |
| `%` | Modulus (Remainder) | `10 % 3` | `1` |
| `++` | Increment | `int x = 5; x++;` | `x` becomes `6` |
| `--` | Decrement | `int x = 5; x--;` | `x` becomes `4` |

### Important Division Notes
- Integer division truncates the result: `5 / 2` results in `2`, not `2.5`
- For decimal division, at least one operand must be a decimal type: `5.0 / 2` or `5 / 2.0` results in `2.5`

## Assignment Operators
| Operator | Example | Equivalent To |
|----------|---------|---------------|
| `=` | `x = 5` | Assigns `5` to `x` |
| `+=` | `x += 5` | `x = x + 5` |
| `-=` | `x -= 5` | `x = x - 5` |
| `*=` | `x *= 5` | `x = x * 5` |
| `/=` | `x /= 5` | `x = x / 5` |
| `%=` | `x %= 5` | `x = x % 5` |

## Comparison Operators
| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `==` | Equal to | `5 == 5` | `true` |
| `!=` | Not equal to | `5 != 3` | `true` |
| `>` | Greater than | `5 > 3` | `true` |
| `<` | Less than | `5 < 3` | `false` |
| `>=` | Greater than or equal to | `5 >= 5` | `true` |
| `<=` | Less than or equal to | `5 <= 3` | `false` |

⚠️ **Common Mistake**: Don't confuse `=` (assignment) with `==` (comparison)!

## Logical Operators
| Operator | Name | Example | Result |
|----------|------|---------|--------|
| `&&` | Logical AND | `true && true` | `true` |
| `\|\|` | Logical OR | `true \|\| false` | `true` |
| `!` | Logical NOT | `!true` | `false` |

### Truth Tables

**Logical AND (`&&`):**
| A | B | A && B |
|---|---|--------|
| `true` | `true` | `true` |
| `true` | `false` | `false` |
| `false` | `true` | `false` |
| `false` | `false` | `false` |

**Logical OR (`||`):**
| A | B | A \|\| B |
|---|---|---------|
| `true` | `true` | `true` |
| `true` | `false` | `true` |
| `false` | `true` | `true` |
| `false` | `false` | `false` |

**Logical NOT (`!`):**
| A | !A |
|---|---|
| `true` | `false` |
| `false` | `true` |

### Short-Circuit Evaluation
- For `&&`: If the first operand is `false`, the second operand is never evaluated
- For `||`: If the first operand is `true`, the second operand is never evaluated

## Other Important Operators

### Conditional (Ternary) Operator
```csharp
condition ? trueValue : falseValue
```

Example:
```csharp
string status = (age >= 18) ? "Adult" : "Minor";
```

### Null Coalescing Operator (`??`)
Returns the left-hand operand if it isn't null, or the right-hand operand if it is.

```csharp
string name = username ?? "Guest";
```

### Null Conditional Operator (`?.`)
Checks for null before accessing a member:

```csharp
int? length = text?.Length; // Returns null if text is null
```

## Operator Precedence (Simplified)

Operations are performed in this order (highest to lowest):

1. Parentheses `()`
2. Increment/decrement `++`, `--`
3. Arithmetic operators `*`, `/`, `%` (then `+`, `-`)
4. Comparison operators `<`, `>`, `<=`, `>=`, `==`, `!=`
5. Logical operators `&&` (then `||`)
6. Assignment operators `=`, `+=`, `-=`, etc.

**When in doubt, use parentheses to control the order of operations!**

## Common Patterns and Examples

### Temperature Conversion
```csharp
// Celsius to Fahrenheit
double fahrenheit = (celsius * 9 / 5) + 32;

// Fahrenheit to Celsius
double celsius = (fahrenheit - 32) * 5 / 9;
```

### Check if a number is even or odd
```csharp
bool isEven = (number % 2 == 0);
bool isOdd = (number % 2 != 0);
```

### Calculate average
```csharp
double average = (a + b + c) / 3.0; // Note the decimal point to avoid integer division
```

### Finding the larger of two numbers
```csharp
int max = (a > b) ? a : b;
```

### Input validation
```csharp
bool isValidAge = (age >= 0 && age <= 120);
bool isValidUsername = (username != null && username.Length >= 3);
```

### Combining conditions
```csharp
bool canVote = (age >= 18 && isCitizen && !isFelon);
bool needsParentalConsent = (age < 18 || hasGuardian);
```