using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = { "Gold 8", "Silver 30" };
        string expected = $"gold -> 8{Environment.NewLine}silver -> 30";

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = { "Gold 18", "Silver 310", "Platinum 7", "Bronze 564", "Platinum 0" };
        string expected = $"gold -> 18{Environment.NewLine}silver -> 310{Environment.NewLine}platinum -> 7{Environment.NewLine}bronze -> 564";

        // Act
        string actual = Miner.Mine(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
