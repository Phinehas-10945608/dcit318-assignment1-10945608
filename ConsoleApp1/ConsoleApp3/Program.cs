using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to enter the sides of the triangle
            Console.Write("Enter the length of side A: ");
            string inputA = Console.ReadLine();

            Console.Write("Enter the length of side B: ");
            string inputB = Console.ReadLine();

            Console.Write("Enter the length of side C: ");
            string inputC = Console.ReadLine();

            // Validate the inputs
            if (double.TryParse(inputA, out double sideA) &&
                double.TryParse(inputB, out double sideB) &&
                double.TryParse(inputC, out double sideC))
            {
                // Determine and display the type of the triangle
                string triangleType = DetermineTriangleType(sideA, sideB, sideC);
                Console.WriteLine($"The triangle is {triangleType}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter valid numbers for the sides of the triangle.");
            }

            // Prevent console from closing immediately
            Console.ReadLine();
        }

        static string DetermineTriangleType(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
