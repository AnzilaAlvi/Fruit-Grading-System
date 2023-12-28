using System;

/// <summary>
/// Represents a text-based fruit grading system.
/// </summary>
class Program
{
    /// <summary>
    /// The main entry point of the application.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Text-Based Fruit Grading System");

        // User input for fruit details
        Console.Write("Enter the name of the fruit: ");
        string name = Console.ReadLine();

        Console.Write("Enter the weight of the fruit (in grams): ");
        double weight = double.Parse(Console.ReadLine());

        Console.Write("Enter the sweetness level of the fruit: ");
        double sweetness = double.Parse(Console.ReadLine());

        Console.Write("Enter the freshness level of the fruit (1-5): ");
        int freshness = int.Parse(Console.ReadLine());

        // Grade the fruit
        int grade = GradeFruit(weight, sweetness, freshness);

        // Display the result
        Console.WriteLine($"Grade for {name}: {GetGradeText(grade)}");
    }

    /// <summary>
    /// Grades a fruit based on its weight, sweetness, and freshness.
    /// </summary>
    /// <param name="weight">The weight of the fruit in grams.</param>
    /// <param name="sweetness">The sweetness level of the fruit.</param>
    /// <param name="freshness">The freshness level of the fruit (1-5).</param>
    /// <returns>The grade of the fruit (1: Excellent, 2: Good, 3: Poor).</returns>
    static int GradeFruit(double weight, double sweetness, int freshness)
    {
        // Grading logic based on weight, sweetness, and freshness
        if (weight >= 150 && sweetness >= 4.0 && freshness >= 4)
        {
            return 1; // Excellent
        }
        else if (weight >= 100 && sweetness >= 3.0 && freshness >= 3)
        {
            return 2; // Good
        }
        else
        {
            return 3; // Poor
        }
    }

    /// <summary>
    /// Gets the text representation of the fruit grade.
    /// </summary>
    /// <param name="grade">The numeric grade of the fruit.</param>
    /// <returns>The text representation of the fruit grade.</returns>
    static string GetGradeText(int grade)
    {
        // Translate numeric grade to text
        switch (grade)
        {
            case 1:
                return "Excellent";
            case 2:
                return "Good";
            case 3:
                return "Poor";
            default:
                return "Unknown";
        }
    }
}