using System;
using System.Threading;

namespace Lab10
{
    class Circle
    {
        private double Radius { get; set; }
        public static int counter = 0;

        public Circle(double radius)
        {
            Interlocked.Increment(ref counter);
            Radius = radius;
        }

        ~Circle()
        {
            Interlocked.Decrement(ref counter);
        }

        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            return (Math.Truncate(CalculateCircumference()*100)/100).ToString();
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public string CalculateFormattedArea()
        {
            return (Math.Truncate(CalculateArea()*100)/100).ToString();
        }

        private string FormatNumber(double x)
        {
            return x.ToString();
        }
    }
}
