using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = { "first", "second", "third", "first", "second", "third" };

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = { "first", "second", "third", "first", "second", "third", "first" };
        string expected = "first";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = { "first", "second", "third", "first", "second", "third", "first", "second", "third" };
        string expected = "first second third";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "firsT", "Second", "ThIrD", "first", "second", "third", "FIRST", "SECOND", "THIRD" };
        string expected = "first second third";

        // Act
        string actual = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
