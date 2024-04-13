using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("random", 1, "rAnDoM")]
    [TestCase("rAnDoM", 1, "rAnDoM")]
    [TestCase("random", 2, "rAnDoMrAnDoM")]
    [TestCase("random", 3, "rAnDoMrAnDoMrAnDoM")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string actual = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetitionFactor = 1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor), "Input string cannot be empty, and repetition factor must be positive.");
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "randomString";
        int repetitionFactor = -1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor), "Input string cannot be empty, and repetition factor must be positive.");
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "randomString";
        int repetitionFactor = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor), "Input string cannot be empty, and repetition factor must be positive.");
    }
}
