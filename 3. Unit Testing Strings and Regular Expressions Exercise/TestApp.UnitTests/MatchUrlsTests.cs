using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string input = string.Empty;

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string input = "softuni.bg, softuni, .bg";

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string input = "https://softuni.bg/";
        List<string> expected = new List<string> { "https://softuni.bg" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string input = "https://softuni.bg/ http://softuni.bg/ http://www.softuni.bg/";
        List<string> expected = new List<string> { "https://softuni.bg", "http://softuni.bg", "http://www.softuni.bg" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        string input = "\"https://softuni.bg/\" \"http://softuni.bg/\" \"http://www.softuni.bg/\"";
        List<string> expected = new List<string> { @"https://softuni.bg", @"http://softuni.bg", @"http://www.softuni.bg" };

        // Act
        List<string> actual = MatchUrls.ExtractUrls(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
