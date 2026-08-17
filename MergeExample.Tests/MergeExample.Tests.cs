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
}
