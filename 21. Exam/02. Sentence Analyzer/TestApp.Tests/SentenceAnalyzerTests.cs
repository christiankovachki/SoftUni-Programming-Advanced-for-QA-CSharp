using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class SentenceAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyString_ReturnsEmptyDictionary()
    {
        // Arrange
        string sentence = string.Empty;

        // Act
        var actualDict = SentenceAnalyzer.Analyze(sentence);

        // Assert
        CollectionAssert.IsEmpty(actualDict);
    }

    [Test]
    public void Test_Analyze_SingleLetter_ReturnsDictionaryWithSingleLetterEntry()
    {
        // Arrange
        string sentence = "C";
        var expectedDict = new Dictionary<string, int>()
        {
            { "letters", 1 }
        };

        // Act
        var actualDict = SentenceAnalyzer.Analyze(sentence);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actualDict);
    }

    [Test]
    public void Test_Analyze_SingleDigit_ReturnsDictionaryWithSingleDigitEntry()
    {
        // Arrange
        string sentence = "8";
        var expectedDict = new Dictionary<string, int>()
        {
            { "digits", 1 }
        };

        // Act
        var actualDict = SentenceAnalyzer.Analyze(sentence);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actualDict);
    }

    [Test]
    public void Test_Analyze_WholeSentence_ReturnsDictionaryWithAllSymbolTypesCount()
    {
        // Arrange
        string sentence = "Unit testing is the 1st step!!!";
        var expectedDict = new Dictionary<string, int>()
        {
            { "letters", 22 },
            { "digits", 1 },
            { "special characters", 3 }
        };

        // Act
        var actualDict = SentenceAnalyzer.Analyze(sentence);

        // Assert
        CollectionAssert.AreEqual(expectedDict, actualDict);
    }
}