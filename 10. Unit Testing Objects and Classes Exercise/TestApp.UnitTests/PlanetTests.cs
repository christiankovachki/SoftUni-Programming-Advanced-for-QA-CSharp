using NUnit.Framework;

using System;
using System.Net;
using System.Xml.Linq;

namespace TestApp.UnitTests;

public class PlanetTests
{
    private Planet _earth;

    [SetUp]
    public void SetUp()
    { 
        _earth = new Planet("Earth", 12742, 149600000, 1);
    }

    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        double mass = 1000;
        double expectedGravity = mass * 6.67430e-11 / Math.Pow(_earth.Diameter / 2, 2);

        // Act
        double actualGravity = _earth.CalculateGravity(mass);

        // Assert
        Assert.That(actualGravity, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        string expected = $"Planet: Earth{Environment.NewLine}" +
                          $"Diameter: 12742 km{Environment.NewLine}" +
                          $"Distance from the Sun: 149600000 km{Environment.NewLine}" +
                          $"Number of Moons: 1";

        // Act
        string actual = _earth.GetPlanetInfo();

        // Assert
        Assert.That (actual, Is.EqualTo(expected));
    }
}
