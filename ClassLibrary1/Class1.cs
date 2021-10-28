using System;

namespace ClassLibrary1
{
    public class Cone
    {
        private double Radius { get; set; }
        private double High { get; set; }

        public Cone(double r, double h)
        {
            Radius = r;
            High = h;
        }

        public double SurfaceArea()
        {
            return (Math.PI * (Math.Pow(Radius, 2)));
        }

        public double FullArea()
        {
            return (Math.PI * Radius * (Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(High, 2)) + Radius));
        }

    }
}
