using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> input = new List<int>();

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { -6, 8, 2, 10, 4, - 1, 3, 1, 11, 41 };
        string expected = "Even numbers: -6, 8, 2, 10, 4" + Environment.NewLine + "Odd numbers: -1, 3, 1, 11, 41";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 6, 8, 2, 10, 4 };
        string expected = "Even numbers: 6, 8, 2, 10, 4";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { 1, 3, 1, 11, 41 };
        string expected = "Odd numbers: 1, 3, 1, 11, 41";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> input = new List<int> { -1, -2, -3, -71, -11, -41 };
        string expected = "Odd numbers: -1, -3, -71, -11, -41" + Environment.NewLine + "Even numbers: -2";

        // Act
        string actual = Grouping.GroupNumbers(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
