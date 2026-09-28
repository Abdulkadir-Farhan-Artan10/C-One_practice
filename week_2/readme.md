## Chapter 2: Processing Data — Important Concepts

> This README contains concepts only. Code examples are intentionally excluded.


# Reading Input with TextBox Controls

• A TextBox is a Windows Forms control that accepts keyboard
input.
• Its Text property stores the entered content as a string.
• TextBox content can be cleared by assigning an empty string or using
its Clear method.

# Variables and Data Types

• A variable is a named storage location in memory.
• A variable must be declared before it is used.
• A data type determines what kind of value a variable can store.
• Choose meaningful variable names. Names cannot contain spaces or be
reserved keywords; they begin with a letter or underscore.
• A string stores a sequence of characters, such as names or   phone numbers.
• String concatenation joins strings together. The + operator is used for this purpose.
• A variable must be assigned a value before it is read.
• Variables declared inside a method are local variables. Their
scope is limited to that method, and their lifetime ends when the method finishes.
• Two variables cannot have the same name in the same scope, but different methods may have local variables with the same name.
• Assignment is allowed only when the value is compatible with the variable’s data type.
• Multiple variables of the same type can be declared in one
declaration statement.

# Numeric Data Types

• int: stores whole numbers.
• double: stores real numbers, including fractional values.
• decimal: stores real numbers with greater precision and is
commonly used for financial values.
• Numeric literals are written as numbers, not quoted strings. A decimal literal uses the m or M suffix.
• C# does not allow every numeric type to be assigned to every other numeric type implicitly. Explicit conversion (casting) can be used where appropriate.
• var lets the compiler infer a local variable’s type from its
initialization value. It must be initialized when declared and is limited to local variables.

# Performing Calculations

• Arithmetic operators include addition, subtraction, multiplication, division, and modulus (remainder).
• Parentheses can clarify or control the order of operations.
• Mixed numeric operations follow type-conversion rules; an operation combining double and decimal is not allowed directly.
• Integer division of two integers produces an integer result,
discarding any fractional part. Use a floating-point operand when a fractional result is needed.

# Numeric Input and Output

• Keyboard input read through a TextBox is a string, even when it looks numeric.
• Convert numeric text to a numeric type with the appropriate Parse method, such as int.Parse, double.Parse, or decimal.Parse.
• A control’s Text property expects text. Convert numeric values to strings with ToString() before assigning them to a TextBox or Label.
• ToString() can also apply number formats, including number,
fixed-point, exponential, currency, and percentage formats.

# Exception Handling

• An exception is an error that occurs while a program is running.
Examples include invalid numeric input, division by zero, or
attempting to open a missing file.
• An unhandled exception can cause an application to stop
unexpectedly.
• A try block contains statements that may cause an exception.
• A catch block contains the response when an exception occurs.
• An exception object has a Message property that provides a
description of the error.
• Throwing means an exception occurs; catching means the
program handles it.

# Named Constants

• A named constant represents a value that cannot be changed
during program execution.
• Constants are declared with the const keyword.
• Uppercase names are a common convention, not a requirement.

>All of those concepts which were talking about above
are the concepts we took this week.