# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Overview

A CIS273 C# warm-up exercise. The task is to implement the method bodies in
[PracticeExercise0/Program.cs](PracticeExercise0/Program.cs); everything else (tests, project
scaffolding) already exists and should not need structural changes.

## Solution layout

Two-project .NET solution ([PracticeExercise0.sln](PracticeExercise0.sln)), target framework `net10.0`:

- **PracticeExercise0** — the exe project. All exercise logic lives in the single static class
  `Program` in [PracticeExercise0/Program.cs](PracticeExercise0/Program.cs). Each method has a
  doc-comment describing the algorithm to implement; stub bodies currently return placeholder
  values (`false`, `i`, `true`, `null`, etc.) that must be replaced.
- **UnitTests** — an MSTest project ([UnitTests/UnitTests.cs](UnitTests/UnitTests.cs)) referencing
  the exe project directly and calling `Program.<Method>` statically. This is the grading harness:
  correctness is judged by these tests passing, not by `Main`. Do not weaken or rewrite the test
  assertions to make a broken implementation pass.

## Commands

```bash
# Build the whole solution
dotnet build

# Run all tests
dotnet test

# Run one category of tests (categories: Palindrome, IntReversal, IsUnique, NeilNumbers, Convert)
dotnet test --filter TestCategory=Palindrome

# Run a single test method
dotnet test --filter Name=TestConvert1

# Run the exe (Main is a manual scratch area, not the grading path)
dotnet run --project PracticeExercise0
```

## The methods to implement

- `IsPalindrome(string s)` — case-insensitive, ignores all spaces.
- `ReverseInt(int i)` — reverses the digits, preserves the sign.
- `IsUnique(string s)` — true if no character repeats; case-insensitive, ignores spaces.
- `IsNeilNumber(int i)` — true if the sum of the digits, each raised to the power of the digit
  count, equals the number itself (e.g. 371 → 3³+7³+1³ = 371).
- `Convert(string s)` — rewrites a phone number where some digits are spelled out as words
  (e.g. `"7three1-6zero8-3one35"` → `"731-608-3135"`) into all-digit `###-###-####` form.

[UnitTests/UnitTests.cs](UnitTests/UnitTests.cs) is the source of truth for expected behavior and
edge cases (empty strings, negatives, punctuation, etc.) for each method above.
