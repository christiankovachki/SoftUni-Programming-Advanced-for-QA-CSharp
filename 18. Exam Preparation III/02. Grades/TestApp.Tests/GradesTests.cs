using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            { "Plamen", 3 },
            { "Dimitar", 2 },
            { "Atanas", 2 },
            { "Christian", 6 },
            { "Margarita", 5 },
            { "Sonya", 4 }
        };
        string expected = $"Christian with average grade 6.00{Environment.NewLine}" +
                          $"Margarita with average grade 5.00{Environment.NewLine}" +
                          $"Sonya with average grade 4.00";

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>() { };

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            { "Christian", 6 },
            { "Sonya", 5 }
        };
        string expected = $"Christian with average grade 6.00{Environment.NewLine}" +
                          $"Sonya with average grade 5.00";

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        // Arrange
        Dictionary<string, int> grades = new()
        {
            { "Christian", 6 },
            { "Sofia", 6 },
            { "Sonya", 6 },
            { "Alex", 6 }
        };
        string expected = $"Alex with average grade 6.00{Environment.NewLine}" +
                          $"Christian with average grade 6.00{Environment.NewLine}" +
                          $"Sofia with average grade 6.00";

        // Act
        string actual = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
