# F# Mutable Variable Bug

This example demonstrates a potential issue when working with mutable variables in F# functions.  The `add` function modifies the input variable `x` in an unexpected way, leading to different results than might be anticipated.

## Problem Description
The provided F# code uses mutable variables within a function, leading to unintended side effects that are not immediately obvious.  The function call and the use of mutable variables may result in incorrect output if the developer does not fully understand the side effects of mutation.

## Solution
The solution shows how to achieve the desired result using immutable variables and avoiding side effects in the function.

## How to Reproduce
1. Copy the code in `bug.fs`.
2. Compile and run the code using an F# compiler (like the one in .NET SDK).
3. Observe the unexpected output.
4. Compare with the corrected code in `bugSolution.fs`.