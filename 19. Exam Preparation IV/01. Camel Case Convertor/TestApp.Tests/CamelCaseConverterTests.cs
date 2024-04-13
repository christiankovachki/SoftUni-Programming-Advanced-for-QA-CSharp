using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class CamelCaseConverterTests
{
    [Test]
    public void Test_ConvertToCamelCase_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ConvertToCamelCase_SingleWord_ReturnsLowercaseWord()
    {
        // Arrange
        string input = "SoftUni";
        string expected = "softuni";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWords_ReturnsCamelCase()
    {
        // Arrange
        string input = "exam preparation number four";
        string expected = "examPreparationNumberFour";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ConvertToCamelCase_MultipleWordsWithMixedCase_ReturnsCamelCase()
    {
        // Arrange
        string input = "EXAM PreparatioN nUmBeR FoUR";
        string expected = "examPreparationNumberFour";

        // Act
        string actual = CamelCaseConverter.ConvertToCamelCase(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}