# C# Variables and Data Types Cheatsheet

## Variable Declaration Syntax
```csharp
dataType variableName = initialValue;
```

## Common Data Types

### Integer Types
| Type | Size | Range | Example |
|------|------|-------|---------|
| `byte` | 1 byte | 0 to 255 | `byte age = 25;` |
| `sbyte` | 1 byte | -128 to 127 | `sbyte temperature = -10;` |
| `short` | 2 bytes | -32,768 to 32,767 | `short population = 30000;` |
| `ushort` | 2 bytes | 0 to 65,535 | `ushort productCode = 4500;` |
| `int` | 4 bytes | -2.1B to 2.1B | `int salary = 75000;` |
| `uint` | 4 bytes | 0 to 4.2B | `uint views = 3000000;` |
| `long` | 8 bytes | -9.2E+18 to 9.2E+18 | `long worldPopulation = 8000000000L;` |
| `ulong` | 8 bytes | 0 to 1.8E+19 | `ulong distance = 9460730472580800UL;` |

### Floating-Point Types
| Type | Size | Precision | Example |
|------|------|-----------|---------|
| `float` | 4 bytes | ~7 digits | `float price = 29.99f;` |
| `double` | 8 bytes | ~15-16 digits | `double pi = 3.14159265359;` |
| `decimal` | 16 bytes | 28-29 digits | `decimal tax = 8.25m;` |

### Other Types
| Type | Description | Example |
|------|-------------|---------|
| `bool` | Boolean (true/false) | `bool isComplete = false;` |
| `char` | Single Unicode character | `char grade = 'A';` |
| `string` | Sequence of characters | `string name = "John Smith";` |

## Type Conversion

### Implicit Conversion (Widening)
```csharp
int num = 100;
double biggerNum = num;  // int fits inside double, no data loss
```

### Explicit Conversion (Narrowing)
```csharp
double pi = 3.14159;
int roundedPi = (int)pi;  // Loses decimal portion, becomes 3
```

### Using Convert Class
```csharp
string input = "42";
int number = Convert.ToInt32(input);

bool success = Convert.ToBoolean("true");
```

### Using Parse Methods
```csharp
string ageText = "25";
int age = int.Parse(ageText);

string priceText = "19.99";
double price = double.Parse(priceText);
```

### TryParse (Safer Conversion)
```csharp
string input = "123";
int result;
bool success = int.TryParse(input, out result);
// if success is true, result contains 123
// if input was invalid, success is false and result is 0
```

## Naming Conventions

### Rules
- Names can contain letters, digits, and underscore
- Names must begin with a letter or underscore
- Names are case-sensitive
- Cannot use C# keywords (unless prefixed with @)

### Best Practices
- Use camelCase for local variables and parameters
- Use PascalCase for classes, methods, and properties
- Choose descriptive names that explain purpose
- Avoid abbreviations and single-letter names (except for simple loops)

## Variable Declaration Examples
```csharp
// Single declaration
int age = 25;

// Multiple variables of same type
string firstName = "Jane", lastName = "Doe";

// Declaration without initialization
double discount;
discount = 0.15;  // Initialize later

// Constants (cannot be changed after declaration)
const double PI = 3.14159265359;

// Implicitly typed variables (compiler determines type)
var count = 10;          // int
var name = "John";       // string
var price = 29.99m;      // decimal
```

## Common Pitfalls
- Using a variable before it's assigned a value
- Type mismatch in assignments
- Losing precision in conversions
- Using reserved keywords as variable names
- Not using the correct suffix for numeric literals (f for float, m for decimal)