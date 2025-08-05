using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Triangle Type Identifier ===");
            Console.WriteLine();
            
            // Prompt user for triangle sides
            Console.WriteLine("Enter the three sides of the triangle:");
            
            Console.Write("Side 1: ");
            if (!double.TryParse(Console.ReadLine(), out double side1) || side1 <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive number for side 1.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }
            
            Console.Write("Side 2: ");
            if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive number for side 2.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }
            
            Console.Write("Side 3: ");
            if (!double.TryParse(Console.ReadLine(), out double side3) || side3 <= 0)
            {
                Console.WriteLine("Error: Please enter a valid positive number for side 3.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }
            
            // Check if the sides can form a valid triangle
            if (!IsValidTriangle(side1, side2, side3))
            {
                Console.WriteLine("Error: The given sides cannot form a valid triangle.");
                Console.WriteLine("(The sum of any two sides must be greater than the third side)");
            }
            else
            {
                // Determine triangle type
                string triangleType = DetermineTriangleType(side1, side2, side3);
                
                // Display result
                Console.WriteLine();
                Console.WriteLine($"Side 1: {side1}");
                Console.WriteLine($"Side 2: {side2}");
                Console.WriteLine($"Side 3: {side3}");
                Console.WriteLine($"Triangle Type: {triangleType}");
            }
            
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        
        /// <summary>
        /// Checks if three sides can form a valid triangle
        /// </summary>
        static bool IsValidTriangle(double side1, double side2, double side3)
        {
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }
        
        /// <summary>
        /// Determines the type of triangle based on side lengths
        /// </summary>
        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            // Check for equilateral triangle (all sides equal)
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral (All three sides are equal)";
            }
            // Check for isosceles triangle (two sides equal)
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                return "Isosceles (Two sides are equal)";
            }
            // Scalene triangle (no sides equal)
            else
            {
                return "Scalene (No sides are equal)";
            }
        }
    }
}