using System;
using ClassLibrary1;

namespace lesson5Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            Cone cone = new Cone(3.0, 1.0);
            double x = cone.SurfaceArea();
            Console.WriteLine(x);
            double y = cone.FullArea();
            Console.WriteLine(y);
        }
    }
}
