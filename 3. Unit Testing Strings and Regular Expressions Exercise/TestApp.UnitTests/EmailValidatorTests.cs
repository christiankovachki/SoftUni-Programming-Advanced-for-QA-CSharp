using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    [TestCase("christian@abv.bg")]
    [TestCase("christian123@123.bg")]
    [TestCase("123321@abv.bg")]
    [TestCase("chris.tian@abv.bg")]
    [TestCase("christian_@abv.bg")]
    [TestCase("chris+tian@abv.bg")]
    [TestCase("chris%tian@abv.bg")]
    [TestCase("chris-tian@abv.bg")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("christian@abv.b")]
    [TestCase("christian123@.bg")]
    [TestCase("123321@g")]
    [TestCase("@abv.bg")]
    [TestCase("abv.bg")]
    [TestCase("abv")]
    [TestCase("@")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
