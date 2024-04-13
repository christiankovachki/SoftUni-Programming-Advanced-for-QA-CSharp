using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PersonTests
{
    private Person _person;

    [SetUp]
    public void SetUp()
    { 
        _person = new Person();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new List<Person>()
        {
            new Person()
            {
                Name = "Alice",
                Id = "A001",
                Age = 35
            },
            new Person()
            {
                Name = "Bob",
                Id = "B002",
                Age = 30
            }
        };

        // Act
        List<Person> actualPeopleList = _person.AddPeople(peopleData);

        // Assert
        Assert.That(actualPeopleList, Has.Count.EqualTo(2));
        for (int i = 0; i < actualPeopleList.Count; i++)
        {
            Assert.That(actualPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(actualPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(actualPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> peopleData = new List<Person>()
        {
            new Person()
            {
                Name = "Alice",
                Id = "A001",
                Age = 25
            },
            new Person()
            {
                Name = "Bob",
                Id = "B002",
                Age = 30
            },
            new Person()
            {
                Name = "Christian",
                Id = "C003",
                Age = 28
            }
        };
        string expected = $"Alice with ID: A001 is 25 years old.{Environment.NewLine}" +
                          $"Christian with ID: C003 is 28 years old.{Environment.NewLine}" +
                          $"Bob with ID: B002 is 30 years old.";

        // Act
        string actual = _person.GetByAgeAscending(peopleData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
