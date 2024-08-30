using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Features.Demo
{
    //Primary Constructor with this and Default Values
    public class Person(string firstName, string lastName)
    {
        // Secondary constructor for initializing with only a first name
        public Person(string firstName) : this(firstName, "Doe") { }

        // Default constructor using "Anonymous" as the name
        public Person() : this("Anonymous", "Doe") { }

        public string FirstName { get; } = firstName;
        public string LastName { get; } = lastName;

        public string FullName => $"{FirstName} {LastName}";
    }

    // Primary Constructor with this and Property Initialization
    public class Car(string make, string model)
    {
        public Car(string make) : this(make, "Standard Model") { }

        public string Make { get; } = make;
        public string Model { get; } = model;

        // Property with custom logic
        public string Description => $"{Make} {Model}";
    }

    //Primary Constructor with Struct and this Keyword

    public struct Point3D(int x, int y, int z)
    {
        // Secondary constructor for a 2D point
        public Point3D(int x, int y) : this(x, y, 0) { }

        public int X { get; } = x;
        public int Y { get; } = y;
        public int Z { get; } = z;

        public double DistanceFromOrigin => Math.Sqrt(X * X + Y * Y + Z * Z);
    }

    // Primary Constructor with Complex Initialization
    public class Transaction(decimal amount, DateTime date)
    {
        // Secondary constructor for initializing with today's date
        public Transaction(decimal amount) : this(amount, DateTime.Today) { }

        public decimal Amount { get; } = amount;
        public DateTime Date { get; } = date;

        public bool IsRecent => (DateTime.Today - Date).Days <= 30;
    }




}
