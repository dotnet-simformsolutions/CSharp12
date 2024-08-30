using System.Drawing;

namespace CSharp12Features.Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Folks! \n Welcome to the demo of C# 12 features!");


            #region Ref Readonly Parameters

            Console.WriteLine("\n ============= Ref Readonly Parameters =============");
            var point = new Point(3, 4);
            var geometry = new Geometry();
            geometry.DisplayPoint(ref point);

            #endregion

            #region Default Lambda Parameters

            Console.WriteLine("\n ============= Default Lambda Parameters =============");
            int add(int x, int y = 5) => x + y;
            Console.WriteLine(add(10)); // Outputs 15
            Console.WriteLine(add(10, 20)); // Outputs 30

            //Filtering Odd Numbers with a Default Threshold
            IEnumerable<int> FilterOddNumbers(IEnumerable<int> numbers, int threshold = 15) => numbers.Where(x => x % 2 != 0 && x >= threshold);
            int[] numbers = { 5, 9, 15, 21, 33 };
            var filteredNumbers = FilterOddNumbers(numbers); // filteredNumbers: { 15, 21, 33 }
            Console.WriteLine(string.Join(", ", filteredNumbers)); // Output: 15, 21, 33

            //Conditional Logging Action
            Action LogAction(bool shouldLog = true)
            {
                return shouldLog ?
                    () => Console.WriteLine("Logging action performed!") :
                    () => Console.WriteLine("Logging skipped!");
            }
            LogAction()();   // Output: Logging action performed!
            LogAction(false)(); // Output: Logging skipped!

            #endregion

            #region Alias Any Type

            Console.WriteLine("\n ============= Alias Any Type =============");

            var game = new Game();
            game.AddScore("Alice", 10);
            game.AddScore("Alice", 20);
            game.AddScore("Bob", 15);

            game.DisplayScores();

            #endregion

            #region Inline Arrays

            Console.WriteLine("\n =============  Inline Arrays =============");
            InlineCharArray inlineArray = new InlineCharArray();

            // Assign characters to each element of the inline array
            inlineArray[0] = 'H';
            inlineArray[1] = 'e';
            inlineArray[2] = 'l';
            inlineArray[3] = 'l';
            inlineArray[4] = 'o';
            inlineArray[5] = '!';

            // Print the characters in the inline array as a string
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(inlineArray[i]);
            }

            #endregion

            #region Primary Constructors

            Console.WriteLine("\n =============  Primary Constructors =============");
            // 1. Person Class Example

            Person person1 = new Person("John", "Smith");
            Person person2 = new Person("Jane");
            Person person3 = new Person();
            var newPoint = new Point(5, 10);

            Console.WriteLine(person1.FullName); // Output: John Smith
            Console.WriteLine(person2.FullName); // Output: Jane Doe
            Console.WriteLine(person3.FullName); // Output: Anonymous Doe

            // 2. Car Class Example
            Car car1 = new Car("Toyota", "Corolla");
            Car car2 = new Car("Honda");

            Console.WriteLine(car1.Description); // Output: Toyota Corolla
            Console.WriteLine(car2.Description); // Output: Honda Standard Model

            // 3. Point3D Struct Example
            Point3D point1 = new Point3D(3, 4, 5);
            Point3D point2 = new Point3D(3, 4);

            Console.WriteLine(point1.DistanceFromOrigin); // Output: 7.0710678118654755
            Console.WriteLine(point2.DistanceFromOrigin); // Output: 5

            // 4. Transaction Class Example
            Transaction transaction1 = new Transaction(100.50m, new DateTime(2024, 8, 1));
            Transaction transaction2 = new Transaction(200.75m);

            Console.WriteLine(transaction1.IsRecent); // Output depends on current date
            Console.WriteLine(transaction2.IsRecent); // Output depends on current date

            #endregion

            #region Collection Expressions

            Console.WriteLine("\n =============  Collection Expressions =============");
            List<int> numList = [1, 2, 3, 4, 5];
            List<string> nameList = ["Alice", "Bob", "Charlie"];
            int[] a1 = [1, 2, 3];


            List<int> baseNumbers = new List<int> { 1, 2, 3 };
            // Create a second list by combining the first list with new numbers using spread operator (..)
            List<int> combinedNumbers = [.. baseNumbers, 4, 5, 6];


            Console.WriteLine(string.Join(", ", numList));
            Console.WriteLine(string.Join(", ", nameList));
            Console.WriteLine(string.Join(", ", a1));
            Console.WriteLine(string.Join(", ", baseNumbers));
            Console.WriteLine("Extended numbers list:");
            Console.WriteLine(string.Join(", ", combinedNumbers));

            #endregion

            #region Experimental Attribute

            Console.WriteLine("\n =============  Experimental Attribute =============");

#pragma warning disable Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
            var experimentalClass = new ExperimentalClass();
#pragma warning restore Test001 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

#pragma warning disable Test002 // To supress the warning
            experimentalClass.ExperimentalMethod();
#pragma warning restore Test002

            #endregion

            #region Interceptors

            Console.WriteLine("\n =============  Interceptors =============");

            var interceptableMethods = new InterceptableMethods();

            interceptableMethods.DisplayValue1(); // Output: Value 1
            interceptableMethods.DisplayValue2(); // Output: The method is intercepted!
            interceptableMethods.DisplayValue3(); // Output: Value 3

            #endregion
        }
    }
}
