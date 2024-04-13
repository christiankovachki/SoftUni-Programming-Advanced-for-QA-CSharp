using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringModifierTests
{
    [Test]
    public void Test_Modify_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Modify_SingleWordWithEvenLength_ReturnsUppperCaseWord()
    {
        // Arrange
        string input = "test";
        string expected = "TEST";

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_SingleWordWithOddLength_ReturnsToLowerCaseWord()
    {
        // Arrange
        string input = "SoftUni";
        string expected = "softuni";

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Modify_MultipleWords_ReturnsModifiedString()
    {
        // Arrange
        string input = "Chelsea Football Club";
        string expected = "chelsea FOOTBALL CLUB";

        // Act
        string actual = StringModifier.Modify(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}