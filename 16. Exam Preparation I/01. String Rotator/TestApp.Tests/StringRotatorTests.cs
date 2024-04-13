using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;
        int positions = 3;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "test input";
        int positions = 0;
        string expected = input;

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        int positions = 2;
        string expected = "efabcd";

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcdef";
        int positions = -2;
        string expected = "efabcd";

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "xyz";
        int positions = 5;
        string expected = "yzx";

        // Act
        string actual = StringRotator.RotateRight(input, positions);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}