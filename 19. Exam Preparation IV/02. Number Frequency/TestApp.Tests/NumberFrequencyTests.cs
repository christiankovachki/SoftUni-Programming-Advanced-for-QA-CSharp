using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;

        // Act
        var actualDict = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(actualDict, Is.Empty);
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 3;
        Dictionary<int, int> expectedDict = new ()
        {
            {3, 1}
        };

        // Act
        var actualDict = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actualDict);
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = 3123;
        Dictionary<int, int> expectedDict = new()
        {
            {3, 2},
            {1, 1},
            {2, 1}
        };

        // Act
        var actualDict = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actualDict);
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        // Arrange
        int number = -3123;
        Dictionary<int, int> expectedDict = new()
        {
            {3, 2},
            {1, 1},
            {2, 1}
        };

        // Act
        var actualDict = NumberFrequency.CountDigits(number);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actualDict);
    }
}