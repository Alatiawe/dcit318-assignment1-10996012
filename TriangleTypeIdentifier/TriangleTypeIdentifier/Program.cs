using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the sides of the triangle
            Console.Write("Enter the length of the first side: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the length of the second side: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter the length of the third side: ");
            string input3 = Console.ReadLine();

            // Attempt to parse the inputs to integers
            if (int.TryParse(input1, out int side1) &&
                int.TryParse(input2, out int side2) &&
                int.TryParse(input3, out int side3))
            {
                // Check if the sides form a valid triangle
                if (side1 > 0 && side2 > 0 && side3 > 0 &&
                    side1 + side2 > side3 &&
                    side1 + side3 > side2 &&
                    side2 + side3 > side1)
                {
                    // Determine the type of the triangle
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("The triangle is Equilateral.");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("The triangle is Isosceles.");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is Scalene.");
                    }
                }
                else
                {
                    Console.WriteLine("The entered sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numerical lengths for the sides.");
            }

            // Wait for the user to press a key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
