using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> expected = new ();

        // Act
        var actual = DictionaryIntersection.Intersect(new Dictionary<string, int>(), new Dictionary<string, int>());

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> postalCodes = new()
        {
            {"Sofia", 1000},
            {"Plovdiv", 4000},
            {"Varna", 9000},
            {"Burgas", 8000}
        };
        Dictionary<string, int> emptyDictionary = new();
        Dictionary<string, int> expected = new();

        // Act
        var actual = DictionaryIntersection.Intersect(postalCodes, emptyDictionary);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> postalCodes1 = new()
        {
            {"Sofia", 1000},
            {"Plovdiv", 4000}
        };
        Dictionary<string, int> postalCodes2 = new()
        {
            {"Varna", 9000},
            {"Burgas", 8000}
        };
        Dictionary<string, int> expected = new();

        // Act
        var actual = DictionaryIntersection.Intersect(postalCodes1, postalCodes2);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        Dictionary<string, int> postalCodes1 = new()
        {
            {"Sofia", 1000},
            {"Plovdiv", 4000},
            {"Varna", 9000},
            {"Burgas", 8000}
        };
        Dictionary<string, int> postalCodes2 = new()
        {
            {"Sofia", 1000},
            {"Plovdiv", 4000},
            {"Varna", 9000},
            {"Burgas", 8000}
        };
        Dictionary<string, int> expected = new()
        {
            {"Sofia", 1000},
            {"Plovdiv", 4000},
            {"Varna", 9000},
            {"Burgas", 8000}
        };

        // Act
        var actual = DictionaryIntersection.Intersect(postalCodes1, postalCodes2);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> validPostalCodes = new()
        {
            {"Sofia", 1000},
            {"Plovdiv", 4000}
        };
        Dictionary<string, int> invalidPostalCodes = new()
        {
            {"Sofia", 10000},
            {"Plovdiv", 40000}
        };
        Dictionary<string, int> expected = new();

        // Act
        var actual = DictionaryIntersection.Intersect(validPostalCodes, invalidPostalCodes);

        // Assert
        CollectionAssert.AreEqual(actual, expected);
    }
}