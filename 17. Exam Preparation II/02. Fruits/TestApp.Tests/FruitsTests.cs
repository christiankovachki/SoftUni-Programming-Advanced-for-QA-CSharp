using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new()
        {
            { "Apple", 3 },
            { "Orange", 5 },
            { "Banana", 2 },
            { "Kiwi", 13 },
        };
        string fruitName = "Kiwi";
        int expected = 13;

        // Act
        int actual = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new()
        {
            { "Apple", 3 },
            { "Orange", 5 },
            { "Banana", 2 },
            { "Kiwi", 13 },
        };
        string fruitName = "Mango";

        // Act
        int actual = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new() { };
        string fruitName = "Apple";

        // Act
        int actual = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = null;
        string fruitName = "Apple";

        // Act
        int actual = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new() 
        {
            { "Apple", 3 },
            { "Orange", 5 },
            { "Banana", 2 },
            { "Kiwi", 13 },
        };
        string? fruitName = null;

        // Act
        int actual = Fruits.GetFruitQuantity(fruitDictionary, fruitName);

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }
}