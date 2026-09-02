# CIS273-FA25-PracticeExercise0

A C# warm-up activity

Complete the missing methods in [PracticeExercise0/Program.cs](PracticeExercise0/Program.cs).

## Directions

Fork the starter repo and complete the missing methods below.

### 1. Is Palindrome

Write a method that will take a string and determine if the string is a palindrome (the same
forwards and backward). Ignore the case and all spaces.

**Signature**

```csharp
public static bool IsPalindrome(string s)
```

**Examples**

```csharp
IsPalindrome("racecar") => true
IsPalindrome("Racecar") => true
IsPalindrome("Race car") => true
IsPalindrome("A man a plan a canal  Panama") => true
IsPalindrome("Never odd or even") => true
IsPalindrome("Mom") => true
IsPalindrome("Mama") => false
```

### 2. Reversal

Write a method that accepts an integer (positive or negative) and returns the "reversed" number,
but retains the sign (positive or negative).

**Signature**

```csharp
public static int ReverseInt(int i)
```

**Examples**

```csharp
ReverseInt(3579) => 9753
ReverseInt(0) => 0
ReverseInt(-3579) => -9753
```

### 3. Is Unique Character Set

Write a function that will accept a string of alphabetic and symbolic 
characters and determine if all the characters are unique (i.e., no 
characters are duplicated). This comparison should be case-insensitive and 
ignore spaces and non-alphabetic characters. The method should conform to 
this API. 

**Signature**

```csharp
public static bool IsUnique(string s)
```

**Examples**

```csharp
IsUnique("abcdefg") => true
IsUnique("abababab") => false
IsUnique("abA") => false
IsUnique("") => true
IsUnique("        ") => true
IsUnique(" wisdom    ") => true
IsUnique("kenan") => false
IsUnique("I do not like this") => false
```

### 4. Neil Numbers

A Neil number of *m* digits is an integer such that the sum of its digits, each raised to the
*m*th power, is equal to the number itself. For example, 371 is a Neil number since
3³ + 7³ + 1³ = 371. Write the following method to test an integer for this property.

**Signature**

```csharp
public static bool IsNeilNumber(int i)
```

**Examples**

```csharp
IsNeilNumber(1) => true
IsNeilNumber(2) => true
IsNeilNumber(3) => true
IsNeilNumber(370) => true
IsNeilNumber(371) => true
IsNeilNumber(153) => true
IsNeilNumber(1634) => true
```

### 5. Funky Phone Number Format Decoding

Write a function that converts phone numbers from this format:

```
"7three1-6zero8-3one35"
```

to the standard format:

```
"731-608-3135"
```

**Signature**

```csharp
public static string Convert(string s)
```

**Examples**

```csharp
Convert("7three1-6zero8-3one35") => "731-608-3135"
Convert("five5five-six0three-two7four9") => "555-603-2749"
Convert("nine0one-4five2-80eight3") => "901-452-8083"
Convert("3two3-8six7-5three0nine") => "323-867-5309"
Convert("20nine-five5two-five2six4") => "209-552-5264"
```
