using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp();
            Console.Write("Enter radius: ");
            var _radius = Validator.ValidatedRadius(Console.ReadLine());
            var circle = new Circle(_radius);
            Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
            Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
            Console.ReadKey();
        }

        public static void StartUp()
        {
            Console.WriteLine("Welcome to the Circlejerk!");
        }
    }
}
