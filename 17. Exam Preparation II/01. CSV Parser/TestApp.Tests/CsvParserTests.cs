using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "test";
        string[] expected = { "test" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual.Length, Is.EqualTo(1));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "test,demo,qa";
        string[] expected = { "test", "demo", "qa" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual.Length, Is.EqualTo(3));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "     test,demo,qa ";
        string[] expected = { "test", "demo", "qa" };

        // Act
        string[] actual = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
        Assert.That(actual.Length, Is.EqualTo(3));
    }
}
