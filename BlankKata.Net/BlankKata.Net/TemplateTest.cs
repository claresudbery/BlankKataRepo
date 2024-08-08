using NUnit.Framework.Constraints;

namespace BlankKata.Net;

/*
 * Tests for Twelve Days of Christmas:
 * 
 * x First line of first verse
 * x First line of second verse
 * First line of any verse
 * First two lines of first verse
 * First two lines of second verse
 * First two lines of any verse
 * "Gift" line of first verse
 * "Gift" line of second verse
 * "Gift" line of any verse
 * Format verse body as array of lines
 * Verse body of first verse
 * Verse body of second verse
 * Verse body of any verse
 * Whole paragraph (Header and body) of any verse
 * Entire song
 */

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void First_line_of_first_verse()
    {
        // Arrange
        var song = new ChristmasSong();
        
        // Act
        String result = song.FirstLineOf(1);
        
        // Assert
        var expected = 
            @"On the first day of Christmas";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void First_line_of_second_verse()
    {
        // Arrange
        var song = new ChristmasSong();
        
        // Act
        String result = song.FirstLineOf(2);
        
        // Assert
        var expected = 
            @"On the second day of Christmas";
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void First_line_of_any_verse()
    {
        // Arrange
        var song = new ChristmasSong();
        
        // Act
        String result = song.FirstLineOf(4);
        
        // Assert
        var expected = 
            @"On the fourth day of Christmas";
        Assert.That(result, Is.EqualTo(expected));
    }
}

public class ChristmasSong
{   
    public string FirstLineOf(int verseNumber)
    {
        List<string> days = new List<string>
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "ninth",
            "tenth",
            "eleventh",
            "twelfth",
        };
        return $"On the {days[verseNumber - 1]} day of Christmas";
    }
}