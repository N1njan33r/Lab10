using System;

namespace Lab10
{
    class Circle
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }

        public string CalculateFormattedCircumference()
        {
            return CalculateCircumference().ToString();
        }

        public double CalculateArea()
        {
            double area = Math.PI * Math.Pow(Radius, 2);
            return area;
        }

        public string CalculateFormattedArea()
        {
            return CalculateArea().ToString();
        }

        private string FormatNumber(double x)
        {
            return x.ToString();
        }
    }
}
