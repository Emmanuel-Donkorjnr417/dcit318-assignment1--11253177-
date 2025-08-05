using System;

namespace TicketPriceCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== Movie Ticket Price Calculator ===");
      Console.WriteLine();

      // Define ticket prices
      const double regularPrice = 10.00;
      const double discountedPrice = 7.00;

      // Prompt user for age input
      Console.Write("Enter your age: ");

      // Read and validate input
      if (int.TryParse(Console.ReadLine(), out int age))
      {
        // Validate age
        if (age < 0)
        {
          Console.WriteLine("Error: Age cannot be negative.");
        }
        else
        {
          double ticketPrice;
          string priceCategory;

          // Determine ticket price based on age
          if (age <= 12)
          {
            ticketPrice = discountedPrice;
            priceCategory = "Child (12 and below)";
          }
          else if (age >= 65)
          {
            ticketPrice = discountedPrice;
            priceCategory = "Senior Citizen (65 and above)";
          }
          else
          {
            ticketPrice = regularPrice;
            priceCategory = "Regular";
          }

          // Display result
          Console.WriteLine($"Age: {age}");
          Console.WriteLine($"Category: {priceCategory}");
          Console.WriteLine($"Ticket Price: GHC{ticketPrice:F2}");
        }
      }
      else
      {
        Console.WriteLine("Error: Please enter a valid age.");
      }

      Console.WriteLine();
      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }
  }
}   