using NUnit.Framework;
using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double initialBalance = 100000;

        // Act
        BankAccount bankAccount = new BankAccount(initialBalance);
        double accountBalance = bankAccount.Balance;

        // Assert
        Assert.That(accountBalance, Is.EqualTo(initialBalance));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double initialBalance = 100000;
        double depositAmount = 20000;
        double expectedBalance = initialBalance + depositAmount;

        // Act
        BankAccount bankAccount = new BankAccount(initialBalance);
        bankAccount.Deposit(depositAmount);
        double accountBalance = bankAccount.Balance;

        // Assert
        Assert.That(accountBalance, Is.EqualTo(expectedBalance));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100000;
        double depositAmount = -20000;

        // Act & Assert
        BankAccount bankAccount = new BankAccount(initialBalance);
        Assert.Throws<ArgumentException>(() => bankAccount.Deposit(depositAmount), "Deposit amount must be greater than zero.");
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double initialBalance = 100000;
        double withdrawAmount = 20000.45;
        double expectedBalance = initialBalance - withdrawAmount;

        // Act
        BankAccount bankAccount = new BankAccount(initialBalance);
        bankAccount.Withdraw(withdrawAmount);
        double accountBalance = bankAccount.Balance;

        // Assert
        Assert.That(accountBalance, Is.EqualTo(expectedBalance));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100000.0;
        double withdrawAmount = -20000.50;

        // Act & Assert
        BankAccount bankAccount = new BankAccount(initialBalance);
        Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(withdrawAmount), "Invalid withdrawal amount.");
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double initialBalance = 100000;
        double withdrawAmount = 100000.01;

        // Act & Assert
        BankAccount bankAccount = new BankAccount(initialBalance);
        Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(withdrawAmount), "Invalid withdrawal amount.");
    }
}