using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class AcronymGeneratorTests
{
    [Test]
    public void Test_GenerateAcronym_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string phrase = string.Empty;

        // Act
        string actual = AcronymGenerator.GenerateAcronym(phrase);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GenerateAcronym_SingleWord_ReturnsUpperCaseFirstLetter()
    {
        // Arrange
        string phrase = "chelsea";
        string expected = "C";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(phrase);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_MultipleWords_ReturnsUpperCaseFirstLetters()
    {
        // Arrange
        string phrase = "chelsea football club";
        string expected = "CFC";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(phrase);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_WordsWithNonLetters_ReturnsAcronymWithoutNonLetters()
    {
        // Arrange
        string phrase = "chelsea football club 1905";
        string expected = "CFC";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(phrase);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GenerateAcronym_PhraseWithSpecialCharacters_ReturnsUpperCaseFirstLetters()
    {
        // Arrange
        string phrase = "international business machines (IBM)";
        string expected = "IBM";

        // Act
        string actual = AcronymGenerator.GenerateAcronym(phrase);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}