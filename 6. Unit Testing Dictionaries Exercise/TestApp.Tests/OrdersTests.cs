using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 3.99 1", "banana 3.75 2", "orange 1.98 11" };
        string expected = $"apple -> 3.99{Environment.NewLine}banana -> 7.50{Environment.NewLine}orange -> 21.78";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 4.0 3", "banana 3.0 3", "orange 2.0 1" };
        string expected = $"apple -> 12.00{Environment.NewLine}banana -> 9.00{Environment.NewLine}orange -> 2.00";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = { "apple 3 1.99", "banana 3 2.75", "orange 1 11.98" };
        string expected = $"apple -> 5.97{Environment.NewLine}banana -> 8.25{Environment.NewLine}orange -> 11.98";

        // Act
        string actual = Orders.Order(input);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
