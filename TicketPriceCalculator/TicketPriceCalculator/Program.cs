using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Constants for ticket prices
            const int regularPrice = 10;
            const int discountedPrice = 7;

            // Prompt the user to enter their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Attempt to parse the input to an integer
            if (int.TryParse(input, out int age))
            {
                // Determine the ticket price based on the age
                int ticketPrice;
                if (age >= 65 || age <= 12)
                {
                    ticketPrice = discountedPrice;
                }
                else
                {
                    ticketPrice = regularPrice;
                }

                // Display the ticket price
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid age.");
            }

            // Wait for the user to press a key before closing the console
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
        
    

