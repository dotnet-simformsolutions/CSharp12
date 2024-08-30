# **C# 12 Features Demo**

Welcome to the C# 12 Features Demo project! This repository showcases the new features introduced in C# 12 with examples and explanations to help you understand and utilize them in your development.

# **Overview**

C# 12, the newest version of Microsoft's popular programming language, builds on the strong foundation of previous versions with a variety of new features aimed at boosting productivity, performance, and versatility for developers. Officially released in November 2023, C# 12 introduces updates such as primary constructors for non-record classes, collection literals, default lambda parameters, and more. These features make your code simpler, clearer, and more expressive.

This project showcases the new features introduced in C# 12, released in November 2023. These features aim to enhance developer productivity, simplify code, and introduce new capabilities that were not possible in earlier versions. This demo will help you explore these features with practical examples, providing a hands-on way to see how they work and how they can be applied in your own projects.


## C# 12 Features

### 1. Ref Readonly Parameters
- **Description:** Allows passing values by reference while ensuring that they cannot be modified within the method. Useful for avoiding the overhead of copying large structures while maintaining immutability.
- **Example:**
    ```csharp
    public void DisplayPoint(ref readonly Point point) {
        // point.X = 10; // This would cause a compile-time error
        Console.WriteLine($"Point: ({point.X}, {point.Y})");
    }
    ```
    **Output:**
    ```
    Point: (3, 4)
    ```
- **Benefits:** Provides performance optimization by avoiding unnecessary copies while maintaining safety.

### 2. Default Lambda Parameters
- **Description:** Allows you to specify default values for lambda parameters, enabling more flexible and concise code.
- **Example:**
    ```csharp
    int multiply(int x, int y = 2) => x * y;
    Console.WriteLine(multiply(5)); // Outputs 10
    Console.WriteLine(multiply(5, 3)); // Outputs 15
    ```
- **Benefits:** Simplifies lambda expressions by allowing optional parameters.

### 3. Alias Any Type
- **Description:** Enables creating aliases for any type, improving code readability, especially with complex types.
- **Example:**
    ```csharp
    using Coordinates = System.ValueTuple<int, int>;
    public Coordinates GetCoordinates() {
        return (10, 20);
    }
    ```
- **Benefits:**  Improves readability and flexibility when dealing with complex types.

### 4. Inline Arrays
- **Description:** Introduces a new way to define arrays with a more concise syntax.
- **Example:**
    ```csharp
    [System.Runtime.CompilerServices.InlineArray(3)]
    public struct InlineFloatArray {
        private float num;
    }
    ```
    **Output:**
    ```
    Element 0: 0
    Element 1: 1.1
    Element 2: 2.2
    Element 3: 3.3
    Element 4: 4.4
    ```
- **Benefits:** Improves performance by avoiding heap allocations and enhances type safety.

### 5. Primary Constructors
- **Description:** Allows defining constructors directly in the class definition, reducing boilerplate code.
- **Example:**
    ```csharp
    public class Book(string title, string author, int publicationYear) {
        public string Title { get; init; } = title;
        public string Author { get; init; } = author;
        public int PublicationYear { get; init; } = publicationYear;
    }
    ```
- **Benefits:** Reduces boilerplate code, improves readability, and ensures immutability after object initialization.

### 6. Collection Expressions
- **Description:** Provides a more concise syntax for initializing collections.
- **Example:**
    ```csharp
    var numbers = [1, 2, 3, 4, 5];
    var names = ["Alice", "Bob", "Charlie"];
    ```
- **Benefits:** Reduces boilerplate code and enhances code readability.

### 7. Experimental Attribute
- **Description:** Marks certain APIs as experimental, signaling that they may change or be removed in future versions.
- **Example:**
    ```csharp
    [Experimental(diagnosticId: "Test001")]
    public void ExperimentalMethod() {
        Console.WriteLine("This is an experimental method.");
    }
    ```
- **Benefits:**  Allows developers to signal that a feature or API is still under development.

### 8. Interceptors
- **Description:** Allows intercepting and replacing method calls at compile-time, enabling modifications to behavior without altering the original code.
- **Example:**
    ```csharp
    public static class InterceptMethod {
        [System.Runtime.CompilerServices.InterceptsLocation(@"C:\Path\To\Your\Project\Program.cs", 158, 34)]
        public static void InterceptMethodDisplayValue2(this InterceptableMethods example) {
            Console.WriteLine("The method is intercepted!");
        }
    }
    ```
- **Benefits:** Separates cross-cutting concerns, promotes reusability, and provides flexibility in modifying behaviors.

## Getting Started
To run the demo, ensure you have the following:
- **.NET 8 SDK**: Download and install from the [.NET Download page](https://dotnet.microsoft.com/download/dotnet/8.0).
- **Visual Studio 2022**: Make sure it is updated to the latest version, which includes support for C# 12.

## Running the Demo
1. Clone the repository.
   ```bash
   git clone https://github.com/Ksheth0496/CSharp12Features.Demo.git


## Happy Coding!
