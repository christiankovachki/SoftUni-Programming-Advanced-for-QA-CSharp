using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[]? input = Array.Empty<string>();

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[]? input = { "word" };
        string expected = "word";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[]? input = { "word", "software", "jobless" };
        string expected = "joblesssoftwareword";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[]? input = null;

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[]? input = { "word", "software", "jobless", "" };
        string expected = "joblesssoftwareword";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[]? input = { "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless", "word", "software", "jobless" };
        string expected = "joblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwarewordjoblesssoftwareword";

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
