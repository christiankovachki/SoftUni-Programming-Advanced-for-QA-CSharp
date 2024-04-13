using NUnit.Framework;
using System;
using TestApp.Library;

namespace TestApp.Tests;

[TestFixture]
public class LibraryCatalogTests
{
    private LibraryCatalog _catalog = null!;

    [SetUp]
    public void SetUp()
    {
        _catalog = new();
    }

    [Test]
    public void Test_AddBook_BookAddedToCatalog()
    {
        // Arrange
        string isbn = "9780374600303";
        string title = "The Bee Sting";
        string author = "Paul Murray";
        string expected = $"Library Catalog:{Environment.NewLine}" +
                          $"{title} by {author} (ISBN: {isbn})";

        // Act
        _catalog.AddBook(isbn, title, author);
        string actual = _catalog.DisplayCatalog();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBook_BookExists_ReturnsBook()
    {
        // Arrange
        string isbn = "9780374600303";
        string title = "The Bee Sting";
        string author = "Paul Murray";

        // Act
        _catalog.AddBook(isbn, title, author);
        Book book = _catalog.GetBook(isbn);

        // Assert
        Assert.That(book.Isbn, Is.EqualTo(isbn));
        Assert.That(book.Title, Is.EqualTo(title));
        Assert.That(book.Author, Is.EqualTo(author));
    }

    [Test]
    public void Test_GetBook_BookDoesNotExist_ThrowsArgumentException()
    {
        // Arrange
        string isbn = "9781250831910";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _catalog.GetBook(isbn), "Book with given ISBN does not exist.");
    }

    [Test]
    public void Test_DisplayCatalog_NoBooks_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string actual = _catalog.DisplayCatalog();

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_DisplayCatalog_WithBooks_ReturnsFormattedCatalog()
    {
        // Arrange
        string isbn1 = "9780374600303";
        string title1 = "The Bee Sting";
        string author1 = "Paul Murray";
        string isbn2 = "9781250831910";
        string title2 = "All the Sinners Bleed";
        string author2 = "S. A. Cosby";
        string isbn3 = "9780525558965";
        string title3 = "The Fraud";
        string author3 = "Zadie Smith";
        string expected = $"Library Catalog:{Environment.NewLine}" +
                          $"{title1} by {author1} (ISBN: {isbn1}){Environment.NewLine}" +
                          $"{title2} by {author2} (ISBN: {isbn2}){Environment.NewLine}" +
                          $"{title3} by {author3} (ISBN: {isbn3})";

        // Act
        _catalog.AddBook(isbn1, title1, author1);
        _catalog.AddBook(isbn2, title2, author2);
        _catalog.AddBook(isbn3, title3, author3);
        string actual = _catalog.DisplayCatalog();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}