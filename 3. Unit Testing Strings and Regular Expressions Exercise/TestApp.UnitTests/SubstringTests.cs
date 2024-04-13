using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "The quick brown jumps over the lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Remove";
        string input = "RemoveThe quick brown fox jumps over the lazy dog";
        string expected = "The quick brown fox jumps over the lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "Remove";
        string input = "The quick brown fox jumps over the lazy dogRemove";
        string expected = "The quick brown fox jumps over the lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "The";
        string input = "The quick brown fox jumps over the lazy dog";
        string expected = "quick brown fox jumps over lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
