using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class EmployeeManagementSystemTests
{
    private EmployeeManagementSystem _ems;

    [SetUp]
    public void SetUp()
    { 
        _ems = new EmployeeManagementSystem();
    }

    [Test]
    public void Test_Constructor_CheckInitialEmptyEmployeeCollectionAndCount()
    {
        // Arrange

        // Act
        int count = _ems.EmployeeCount;
        List<string> employees = _ems.GetAllEmployees();

        // Assert
        Assert.That(count, Is.EqualTo(0));
        CollectionAssert.IsEmpty(employees);
    }

    [Test]
    public void Test_AddEmployee_ValidEmployeeName_AddNewEmployee()
    {
        // Arrange
        string employeeName = "Christian";
        List<string> expectedEmployees = new () { "Christian" };

        // Act
        _ems.AddEmployee(employeeName);
        int count = _ems.EmployeeCount;
        List<string> employees = _ems.GetAllEmployees();

        // Assert
        Assert.That(count, Is.EqualTo(1));
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_AddEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string employeeName)
    {
        // Arrange

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _ems.AddEmployee(employeeName), "Employee name cannot be empty or whitespace.");
    }

    [Test]
    public void Test_RemoveEmployee_ValidEmployeeName_RemoveFirstEmployeeName()
    {
        // Arrange
        string employeeName = "Christian";

        // Act
        _ems.AddEmployee(employeeName);
        _ems.RemoveEmployee(employeeName);
        int count = _ems.EmployeeCount;
        List<string> employees = _ems.GetAllEmployees();

        // Assert
        Assert.That(count, Is.EqualTo(0));
        CollectionAssert.IsEmpty(employees);
    }

    [TestCase(null)]
    [TestCase("")]
    public void Test_RemoveEmployee_NullOrEmptyEmployeeName_ThrowsArgumentException(string employeeName)
    {
        // Arrange

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _ems.RemoveEmployee(employeeName), "Employee not found in the system.");
    }

    [Test]
    public void Test_GetAllEmployees_AddedAndRemovedEmployees_ReturnsExpectedEmployeeCollection()
    {
        // Arrange
        string employeeName1 = "Christian";
        string employeeName2 = "Gabriela";
        string employeeName3 = "Sonya";
        List<string> expectedEmployees = new () { "Gabriela", "Sonya" };

        // Act
        _ems.AddEmployee(employeeName1);
        _ems.AddEmployee(employeeName2);
        _ems.AddEmployee(employeeName3);
        _ems.RemoveEmployee(employeeName1);
        int count = _ems.EmployeeCount;
        List<string> employees = _ems.GetAllEmployees();

        // Assert
        Assert.That(count, Is.EqualTo(2));
        CollectionAssert.AreEqual(expectedEmployees, employees);
    }   
}