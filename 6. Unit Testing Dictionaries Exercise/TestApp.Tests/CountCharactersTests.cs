using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "" };

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "t" };
        string expected = "t -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "texttext" };
        string expected = "t -> 4" + Environment.NewLine + "e -> 2" + Environment.NewLine + "x -> 2";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "@#@#!" };
        string expected = "@ -> 2" + Environment.NewLine + "# -> 2" + Environment.NewLine + "! -> 1";

        // Act
        string actual = CountCharacters.Count(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
