using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = { "Gardenia" };
        string expected = $"Plants with 8 letters:{Environment.NewLine}Gardenia";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = { "Gardenia", "Gerber", "Kalanchoe" };
        string expected = $"Plants with 6 letters:{Environment.NewLine}Gerber{Environment.NewLine}Plants with 8 letters:{Environment.NewLine}Gardenia{Environment.NewLine}Plants with 9 letters:{Environment.NewLine}Kalanchoe";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = { "GaRdEnia", "gerber", "KALANCHOE" };
        string expected = $"Plants with 6 letters:{Environment.NewLine}gerber{Environment.NewLine}Plants with 8 letters:{Environment.NewLine}GaRdEnia{Environment.NewLine}Plants with 9 letters:{Environment.NewLine}KALANCHOE";

        // Act
        string actual = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
