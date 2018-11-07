using System;

namespace Lab10
{
    static class Validator
    {
        public static double ValidatedRadius(string input)
        {
            double output;
            while (true)
            {
                if (double.TryParse(input, out double rad))
                {
                    output = rad;
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot parse string input.");
                    input = Console.ReadLine();
                }
            }

            return output;
        }
    }
}
