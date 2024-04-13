using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    private Vehicles _vehicles;

    [SetUp]
    public void SetUp()
    { 
        _vehicles = new Vehicles();
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        string[] vehicles = { "Car/Ford/Focus/120", "Car/Toyota/Camry/150", "Truck/Volvo/VNL/500" };
        string expected = $"Cars:{Environment.NewLine}" +
                          $"Ford: Focus - 120hp{Environment.NewLine}" +
                          $"Toyota: Camry - 150hp{Environment.NewLine}" +
                          $"Trucks:{Environment.NewLine}" +
                          $"Volvo: VNL - 500kg";

        // Act
        string actual = _vehicles.AddAndGetCatalogue(vehicles);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        string[] vehicles = Array.Empty<string>();
        string expected = $"Cars:{Environment.NewLine}" + $"Trucks:";

        // Act
        string actual = _vehicles.AddAndGetCatalogue(vehicles);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
