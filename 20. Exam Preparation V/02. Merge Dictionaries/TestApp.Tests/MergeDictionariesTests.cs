using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class MergeDictionariesTests
{
    [Test]
    public void Test_Merge_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new ();
        Dictionary<string, int> dict2 = new ();

        // Act
        var actual = MergeDictionaries.Merge(dict1, dict2);

        // Assert
        CollectionAssert.IsEmpty(actual);
    }

    [Test]
    public void Test_Merge_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsNonEmptyDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Christian", 95},
            { "Krasi", 98},
            { "Sonya", 98}
        };
        Dictionary<string, int> dict2 = new();
        Dictionary<string, int> expectedDict = new()
        {
            { "Christian", 95},
            { "Krasi", 98},
            { "Sonya", 98}
        };

        // Act
        var actual = MergeDictionaries.Merge(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actual);
    }

    [Test]
    public void Test_Merge_TwoNonEmptyDictionaries_ReturnsMergedDictionary()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Christian", 95},
            { "Krasi", 98},
            { "Sonya", 98}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Atanas", 93},
            { "Dimitar", 94 }
        };
        Dictionary<string, int> expectedDict = new()
        {
            { "Christian", 95},
            { "Krasi", 98},
            { "Sonya", 98},
            { "Atanas", 93},
            { "Dimitar", 94 }
        };

        // Act
        var actual = MergeDictionaries.Merge(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actual);
    }

    [Test]
    public void Test_Merge_OverlappingKeys_ReturnsMergedDictionaryWithValuesFromDict2()
    {
        // Arrange
        Dictionary<string, int> dict1 = new()
        {
            { "Christian", 1995},
            { "Krasi", 1998},
            { "Sonya", 1998}
        };
        Dictionary<string, int> dict2 = new()
        {
            { "Christian", 95},
            { "Krasi", 98},
            { "Sonya", 98}
        };
        Dictionary<string, int> expectedDict = new()
        {
            { "Christian", 95},
            { "Krasi", 98},
            { "Sonya", 98}
        };

        // Act
        var actual = MergeDictionaries.Merge(dict1, dict2);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actual);
    }
}