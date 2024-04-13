using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    { 
        _article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = { "Title1 Content1 Author1", "Title2 Content2 Author2", "Title3 Content3 Author3" };
        List<Article> expectedArticleList = new List<Article>()
        { 
            new Article() 
            {
                Title = "Title1",
                Content = "Content1",
                Author = "Author1"
            },
            new Article()
            {

                Title = "Title2",
                Content = "Content2",
                Author = "Author2"
            },
            new Article()
            {

                Title = "Title3",
                Content = "Content3",
                Author = "Author3"
            }
        };
        
        // Act
        Article actual = _article.AddArticles(articles);

        // Assert
        Assert.That(actual.ArticleList, Has.Count.EqualTo(3));
        for (int i = 0; i < actual.ArticleList.Count; i++)
        {
            Assert.That(actual.ArticleList[i].Title, Is.EqualTo(expectedArticleList[i].Title));
            Assert.That(actual.ArticleList[i].Content, Is.EqualTo(expectedArticleList[i].Content));
            Assert.That(actual.ArticleList[i].Author, Is.EqualTo(expectedArticleList[i].Author));
        }
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article article = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Title = "ATitle",
                    Content = "ContentA",
                    Author = "AuthorA"
                },
                new Article()
                {
                    Title = "BTitle",
                    Content = "ContentB",
                    Author = "AuthorB"
                },
                new Article()
                {
                    Title = "CTitle",
                    Content = "ContentC",
                    Author = "AuthorC"
                }
            }
        };
        string printCriteria = "title";
        string expected = $"ATitle - ContentA: AuthorA{Environment.NewLine}" + 
                          $"BTitle - ContentB: AuthorB{Environment.NewLine}" +
                          $"CTitle - ContentC: AuthorC";

        // Act
        string actual = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article article = new Article()
        {
            ArticleList = new()
            {
                new Article()
                {
                    Title = "ATitle",
                    Content = "ContentA",
                    Author = "AuthorA"
                },
                new Article()
                {
                    Title = "BTitle",
                    Content = "ContentB",
                    Author = "AuthorB"
                },
                new Article()
                {
                    Title = "CTitle",
                    Content = "ContentC",
                    Author = "AuthorC"
                }
            }
        };
        string printCriteria = "else";

        // Act
        string actual = _article.GetArticleList(article, printCriteria);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}
