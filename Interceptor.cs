using System.Runtime.CompilerServices;

// The InterceptsLocationAttribute can be defined either in this file or in a separate file.
namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
    {
    }
}

namespace CSharp12Features.Demo
{
    public class InterceptableMethods
    {
        public void DisplayValue1() => Console.WriteLine("Value 1");
        public void DisplayValue2() => Console.WriteLine("Value 2");
        public void DisplayValue3() => Console.WriteLine("Value 3");
    }

    public static class InterceptMethod
    {
        [InterceptsLocation(
            filePath: @"C:\Karishma\Projects\CSharp12Features.Demo\CSharp12Features.Demo\Program.cs",
            line: 160,
            character: 34)]
        public static void InterceptMethodDisplayValue2(this InterceptableMethods example)
        {
            Console.WriteLine("The method is intercepted!");
        }
    }
}
