using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        // Arrange
        string[] input = { "hello" };
        string expected = "hellohellohellohellohello";

        // Act
        string actual = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        // Arrange
        string[] input = { "hello", "asd", "1"};
        string expected = "hellohellohellohellohelloasdasdasd1";

        // Act
        string actual = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
