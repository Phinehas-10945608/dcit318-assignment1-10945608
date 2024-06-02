using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                int ticketPrice = CalculateTicketPrice(age);
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }

            // Prevent console from closing immediately
            Console.ReadLine();
        }

        static int CalculateTicketPrice(int age)
        {
            if (age >= 65 || age <= 12)
            {
                return 7;  // Discounted price
            }
            else
            {
                return 10; // Regular price
            }
        }
    }
}
