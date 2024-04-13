using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 5 };
        string expected = "5 -> 1";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 5, 1, 5, 2, 10, 10 };
        string expected = "1 -> 1" + Environment.NewLine + "2 -> 1" + Environment.NewLine + "5 -> 2" + Environment.NewLine + "10 -> 2";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { -5, -1, -5, -2, -10, -10 };
        string expected = "-10 -> 2" + Environment.NewLine + "-5 -> 2" + Environment.NewLine + "-2 -> 1" + Environment.NewLine + "-1 -> 1";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = { 5, 1, 0, 0, 5, 2, 10, 10 };
        string expected = "0 -> 2" + Environment.NewLine + "1 -> 1" + Environment.NewLine + "2 -> 1" + Environment.NewLine + "5 -> 2" + Environment.NewLine + "10 -> 2";

        // Act
        string actual = CountRealNumbers.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
