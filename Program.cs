using System;
using System.Collections.Generic;
using NUnit.Framework;

class Program
{
    static void Main()
    {
        Console.WriteLine("Text-Based Fruit Grading System");

        List<Fruit> fruits = new List<Fruit>
        {
            new Fruit("Apple", 150, 1.0),
            new Fruit("Banana", 120, 2.0),
            new Fruit("Orange", 180, 3.5),
            new Fruit("Mango", 140, 5.0)
        };

        DisplayAvailableFruits(fruits);

        int selectedIndex = GetUserInputForFruitSelection(fruits);

        if (selectedIndex != -1)
        {
            Fruit selectedFruit = fruits[selectedIndex];
            int grade = GradeFruit(selectedFruit);
            DisplayResult(selectedFruit, grade);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    static void DisplayAvailableFruits(List<Fruit> fruits)
    {
        Console.WriteLine("Available Fruits:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"{fruit.Name} - Weight: {fruit.Weight}g, Sweetness: {fruit.Sweetness}");
        }
    }

    static int GetUserInputForFruitSelection(List<Fruit> fruits)
    {
        Console.Write("Enter the index of the fruit you want to grade: ");
        if (int.TryParse(Console.ReadLine(), out int selectedIndex) && selectedIndex >= 0 && selectedIndex < fruits.Count)
        {
            return selectedIndex;
        }
        return -1;
    }

    static int GradeFruit(Fruit fruit)
    {
        double weight = fruit.Weight;
        double sweetness = fruit.Sweetness;

        // Grading logic based on weight and sweetness
        if (weight >= 150 && sweetness >= 4.0)
        {
            return 1; // Excellent
        }
        else if (weight >= 100 && sweetness >= 3.0)
        {
            return 2; // Good
        }
        else
        {
            return 3; // Poor
        }
    }

    static void DisplayResult(Fruit selectedFruit, int grade)
    {
        Console.WriteLine($"Grade for {selectedFruit.Name}: {grade}");
    }
}

[TestFixture]
class ProgramTests
{
    [Test]
    public void GradeFruit_Excellent()
    {
        Fruit fruit = new Fruit("TestFruit", 160, 4.5);
        int grade = Program.GradeFruit(fruit);
        Assert.AreEqual(1, grade);
    }

    // Add more test cases for Good and Poor scenarios
}

class Fruit
{
    public string Name { get; }
    public double Weight { get; }
    public double Sweetness { get; }

    public Fruit(string name, double weight, double sweetness)
    {
        Name = name;
        Weight = weight;
        Sweetness = sweetness;
    }
}
