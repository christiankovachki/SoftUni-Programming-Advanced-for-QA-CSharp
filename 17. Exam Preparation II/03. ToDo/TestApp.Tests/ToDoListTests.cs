using System;
using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        _toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {
        // Arrange
        string title = "Exam Prep";
        DateTime dueDate = new DateTime(2024, 04, 10);
        string expected = $"To-Do List:{Environment.NewLine}" +
                          $"[ ] Exam Prep - Due: 04/10/2024";

        // Act
        _toDoList.AddTask(title, dueDate);
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        // Arrange
        string title = "Exam Prep";
        DateTime dueDate = new DateTime(2024, 04, 10);
        string expected = $"To-Do List:{Environment.NewLine}" +
                          $"[✓] Exam Prep - Due: 04/10/2024";

        // Act
        _toDoList.AddTask(title, dueDate);
        _toDoList.CompleteTask(title);
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange
        string title = "Exam Prep";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _toDoList.CompleteTask(title), "Task with given title does not exist.");
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange
        string expected = "To-Do List:";

        // Act
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        // Arrange
        string firstTitle = "Exam Prep";
        string secondTitle = "Exam Prep 2";
        DateTime firstDueDate = new DateTime(2024, 04, 10);
        DateTime secondDueDate = new DateTime(2024, 04, 11);
        string expected = $"To-Do List:{Environment.NewLine}" +
                          $"[ ] Exam Prep - Due: 04/10/2024{Environment.NewLine}" +
                          $"[ ] Exam Prep 2 - Due: 04/11/2024";

        // Act
        _toDoList.AddTask(firstTitle, firstDueDate);
        _toDoList.AddTask(secondTitle, secondDueDate);
        string actual = _toDoList.DisplayTasks();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}