namespace MergeExample.Tests;

using Xunit;
using MergeExample;

public class MergeExampleTest1
{
    [Fact]
    public void Basic_NoIntersections_ReturnsMerged()
    {
        // Arange
        var a = new List<int> {1, 2, 3, 4, 4};
        var b = new List<int> {2, 5, 5, 10};
        var expected = new List<int> {1, 2, 2, 3, 4, 4, 5, 5, 10};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Basic_Intersections_ReturnsMerged()
    {
        // Arange
        var a = new List<int> {1, 10, 20};
        var b = new List<int> {5, 6, 30};
        var expected = new List<int> {1, 5, 6, 10, 20, 30};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void More_Intersections_ReturnsMerged()
    {
        // Arange
        var a = new List<int> {1, 4, 5};
        var b = new List<int> {2, 3, 6};
        var expected = new List<int> {1, 2, 3, 4, 5, 6};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Empty_FirstPart_ReturnsMerged()
    {
        // Arange
        var a = new List<int> {};
        var b = new List<int> {1, 4, 5};
        var expected = new List<int> {1, 4, 5};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Empty_SecondPart_ReturnsMerged()
    {
        // Arange
        var a = new List<int> {1, 4, 5};
        var b = new List<int> {};
        var expected = new List<int> {1, 4, 5};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Both_Empty_ReturnsEmpty()
    {
        // Arange
        var a = new List<int> {};
        var b = new List<int> {};
        var expected = new List<int> {};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Jagged_Arrays_ReturnsMerges()
    {
        // Arange
        var a = new List<int> {1, 100};
        var b = new List<int> {2, 3, 4};
        var expected = new List<int> {1, 2, 3, 4, 100};

        // Act
        var result = Merger.MergeArrays(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
