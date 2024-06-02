using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade between 0 and 100");
            string input = Console.ReadLine();

            // Attempt to parse the input to an integer
            if (int.TryParse(input, out int grade))
            {
                // Check if the grade is within the valid range
                if (grade >= 0 && grade <= 100)
                {
                    // Determine the letter grade
                    string letterGrade;
                    if (grade >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = "B";
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = "C";
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }

                    // Display the letter grade
                    Console.WriteLine($"The letter grade for {grade} is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Error: Grade must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a numerical grade.");
            }

            // Wait for the user to press a key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
        
    

