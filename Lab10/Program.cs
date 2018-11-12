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
            do
            {
                Console.Write("Enter radius: ");
                var _radius = Validator.ValidatedRadius(Console.ReadLine());
                var circle = new Circle(_radius);
                Console.WriteLine($"Circumference: {circle.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {circle.CalculateFormattedArea()}");
                Console.Write("Try again? (y/n): ");
                ConsoleKeyInfo repeat = Console.ReadKey();
                Console.WriteLine();
                if (!repeat.KeyChar.Equals('y'))
                {
                    break;
                }
            } while (true);
            Console.WriteLine("¡Adios! You created {0} Circle object(s)", Circle.counter);
            Console.ReadKey();
        }

        public static void StartUp()
        {
            Console.WriteLine("Welcome to the Circle calculator!");
        }

        class Square
        {

        }

        class Triangle
        {
            // Perimeter = P = A + B + C
            // Area = sqrt(P/2 * (P - A) * (P - B) * (P - C))
        }

        abstract class Shape
        {

        }
    }
}
