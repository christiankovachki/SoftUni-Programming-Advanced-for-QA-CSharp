using System;
using NUnit.Framework;
using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;
    
    [SetUp]
    public void Setup()
    {
        _chatRoom = new();
    }
    
    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange
        string sender = "christian825";
        string message = "Hello, my friend!";
        string timestamp = DateTime.Now.Date.ToString("d");
        string expected = $"Chat Room Messages:{Environment.NewLine}" +
                          $"{sender}: {message} - Sent at {timestamp}";

        // Act
        _chatRoom.SendMessage(sender, message);
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange

        // Act
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange
        string sender1 = "christian825";
        string message1 = "Hello, my friend!";
        string sender2 = "sonya98";
        string message2 = "Hello to you, too!";
        string timestamp = DateTime.Now.Date.ToString("d");
        string expected = $"Chat Room Messages:{Environment.NewLine}" +
                          $"{sender1}: {message1} - Sent at {timestamp}{Environment.NewLine}" +
                          $"{sender2}: {message2} - Sent at {timestamp}";

        // Act
        _chatRoom.SendMessage(sender1, message1);
        _chatRoom.SendMessage(sender2, message2);
        string actual = _chatRoom.DisplayChat();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}