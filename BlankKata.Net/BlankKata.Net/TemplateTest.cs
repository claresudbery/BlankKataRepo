using NUnit.Framework.Constraints;

namespace BlankKata.Net;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        // Arrange
        var thing = 5;
        
        // Act
        var result = thing + 1;
        
        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
}