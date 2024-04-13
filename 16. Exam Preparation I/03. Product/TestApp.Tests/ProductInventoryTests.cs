using NUnit.Framework;
using TestApp.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        _inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string name = "Legion 5 Pro";
        double price = 2799.99;
        int quantity = 1;
        string expected = $"Product Inventory:{Environment.NewLine}" + 
                          $"{name} - Price: ${price} - Quantity: {quantity}";

        // Act
        _inventory.AddProduct(name, price , quantity);
        string actual = _inventory.DisplayInventory();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = $"Product Inventory:";

        // Act
        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        List<string> products = new() 
        {
            "Legion5Pro 2799.99 1",
            "Zephyrus 2899.99 1",
            "Nitro5 2999.99 1",
        };
        string expected = $"Product Inventory:{Environment.NewLine}" +
                          $"Legion5Pro - Price: $2799.99 - Quantity: 1{Environment.NewLine}" +
                          $"Zephyrus - Price: $2899.99 - Quantity: 1{Environment.NewLine}" +
                          "Nitro5 - Price: $2999.99 - Quantity: 1";

        // Act
        for (int i = 0; i < products.Count; i++)
        {
            string[] data = products[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = data[0];
            double price = double.Parse(data[1]);
            int quantity = int.Parse(data[2]);

            _inventory.AddProduct(name, price, quantity);
        }

        string actual = _inventory.DisplayInventory();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange

        // Act
        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        List<string> products = new()
        {
            "Legion5Pro 2799.99 1",
            "Zephyrus 2899.99 1",
            "Nitro5 2999.99 1",
        };
        double expected = 8699.97;

        // Act
        for (int i = 0; i < products.Count; i++)
        {
            string[] data = products[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name = data[0];
            double price = double.Parse(data[1]);
            int quantity = int.Parse(data[2]);

            _inventory.AddProduct(name, price, quantity);
        }

        double actual = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}