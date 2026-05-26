namespace BasicAlgorithms.Tests;

public class ThreeSumTests
{
    [Fact]
    public void ThreeSum_Returns_Expected_Triplets()
    {
        // Arrange
        var nums = new[] { -1, 0, 1, 2, -1, -4 };

        // Act
        var result = ThreeSum.Find(nums);

        // Assert
        var expected = new List<IList<int>>
        {
            new List<int> { -1, -1, 2 },
            new List<int> { -1, 0, 1 }
        };

        Assert.Equal(expected.Count, result.Count);

        foreach (var triplet in expected)
        {
            Assert.Contains(result, r => r.SequenceEqual(triplet));
        }
    }

    [Fact]
    public void ThreeSum_Returns_Empty_When_No_Solution()
    {
        // Arrange
        var nums = new[] { 1, 2, -2, -1 };

        // Act
        var result = ThreeSum.Find(nums);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void ThreeSum_Handles_Duplicate_Triplets_Correctly()
    {
        // Arrange
        var nums = new[] { 0, 0, 0, 0 };

        // Act
        var result = ThreeSum.Find(nums);

        // Assert
        var expected = new List<IList<int>>
        {
            new List<int> { 0, 0, 0 }
        };

        Assert.Equal(expected.Count, result.Count);

        foreach (var triplet in expected)
        {
            Assert.Contains(result, r => r.SequenceEqual(triplet));
        }
    }
}