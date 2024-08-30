using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Features.Demo
{
    [Experimental(diagnosticId: "Test001")]
    public class ExperimentalClass
    {
        [Experimental(diagnosticId: "Test002")]
        public void ExperimentalMethod()
        {
            Console.WriteLine("This is an experimental method.");
        }
    }
}
