using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp12Features.Demo
{

    public class Geometry
    {
        public void DisplayPoint(ref readonly Point point)
        {
            //point.X = 10; // This would cause a compile-time error
            Console.WriteLine($"Point: ({point.X}, {point.Y})");
        }
    }

    

   
}
