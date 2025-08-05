using System;

namespace GradeCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("=== Grade Calculator ===");
      Console.WriteLine("Enter a numerical grade between 0 and 100:");

      try
      {
        // Get user input
        string input = Console.ReadLine();
        double grade = Convert.ToDouble(input);

        // Validate input range
        if (grade < 0 || grade > 100)
        {
          Console.WriteLine("Error: Grade must be between 0 and 100.");
          return;
        }

        // Determine letter grade
        string letterGrade = GetLetterGrade(grade);

        // Display result
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
      }
      catch (FormatException)
      {
        Console.WriteLine("Error: Please enter a valid numerical grade.");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"An error occurred: {ex.Message}");
      }

      Console.WriteLine("Press any key to exit...");
      Console.ReadKey();
    }

    static string GetLetterGrade(double grade)
    {
      if (grade >= 90)
        return "A";
      else if (grade >= 80)
        return "B";
      else if (grade >= 70)
        return "C";
      else if (grade >= 60)
        return "D";
      else
        return "F";
    }
  }
}