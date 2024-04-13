using NUnit.Framework;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        _exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "SoftUni";
        string expected = "inUtfoS";

        // Act
        string actual = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string? input = null;

        // Act & Assert
        //Assert.That(() => _exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
        Assert.Throws<ArgumentNullException>(() => _exceptions.ArgumentNullReverse(input), "String cannot be null.");
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal totalPrice = 101.25m;
        decimal discount = 8.1m;
        decimal expected = 93.04875m;

        // Act
        decimal actual = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 101.25m;
        decimal discount = -0.1m;

        // Act & Assert
        Assert.That(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 101.25m;
        decimal discount = 100.1m;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(totalPrice, discount), "Discount must be between 0 and 100.");
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 1, 5, -1, 100, 19 };
        int index = 2;
        int expected = -1;

        // Act
        int actual = _exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 1, 5, -1, 100, 19 };
        int index = -1;

        // Act & Assert
        Assert.That(() => _exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index), "Index is out of range.");
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 1;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(array, index), "Index is out of range.");
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;
        string expected = "User logged in.";

        // Act
        string actual = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        // Assert
        Assert.IsTrue(expected.Equals(actual));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn), "User must be logged in to perform this operation.");
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "10";
        int expected = 10;

        // Act
        int actual = _exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "10.";

        // Act & Assert
        Assert.Throws<FormatException>(() => _exceptions.FormatExceptionParseInt(input), "Input is not in the correct format for an integer.");
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            { "Day of Birth", 18 },
            { "Month of Birth", 9 },
            { "Year of Birth", 1995 }
        };
        string key = "Day of Birth";
        int expected = 18;

        // Act
        int actual = _exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            { "Day of Birth", 18 },
            { "Month of Birth", 9 },
            { "Year of Birth", 1995 }
        };
        string key = "EGN";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(dictionary, key), "The specified key was not found in the dictionary.");
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 2147483646;
        int b = 1;
        int expected = int.MaxValue;

        // Act
        int actual = _exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = 2147483647;
        int b = 2147483647;

        // Act & Assert
        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(a, b), "Arithmetic overflow occurred during addition.");
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = -2147483648;
        int b = -2147483648;

        // Act & Assert
        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(a, b), "Arithmetic overflow occurred during addition.");
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int dividend = 100;
        int divisor = 2;
        int expected = 50;

        // Act
        int actual = _exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 100;
        int divisor = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _exceptions.DivideByZeroDivideNumbers(dividend, divisor), "Division by zero is not allowed.");
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 10, 20, 30, 40, 50};
        int index = 0;
        int expected = 150;

        // Act
        int actual = _exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? collection = null;
        int index = 0;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _exceptions.SumCollectionElements(collection, index), "Collection cannot be null.");
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 10, 20, 30, 40, 50 };
        int index = -1;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.SumCollectionElements(collection, index), "Index has to be within bounds.");
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            { "Day of Birth", "18" },
            { "Month of Birth", "9" },
            { "Year of Birth", "1995" }
        };
        string key = "Day of Birth";
        int expected = 18;

        // Act
        int actual = _exceptions.GetElementAsNumber(dictionary, key);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            { "Day of Birth", "18" },
            { "Month of Birth", "9" },
            { "Year of Birth", "1995" }
        };
        string key = "EGN";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(dictionary, key), "Key not found in the dictionary.");
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            { "Day of Birth", "Invalid" },
            { "Month of Birth", "9" },
            { "Year of Birth", "1995" }
        };
        string key = "Day of Birth";

        // Act & Assert
        Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(dictionary, key), "Can't parse string.");
    }
}
