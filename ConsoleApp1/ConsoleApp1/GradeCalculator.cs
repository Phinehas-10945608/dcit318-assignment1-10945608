using System;

namespace GradeCalculator
{
    class GradeCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade (0-100): ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int grade))
            {
                if (grade >= 0 && grade <= 100)
                {
                    string letterGrade = GetLetterGrade(grade);
                    Console.WriteLine($"The letter grade is: {letterGrade}");
                }
                else
                {
                    Console.WriteLine("Please enter a grade between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numerical grade.");
            }

            // Prevent console from closing immediately
            Console.ReadLine();
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}
