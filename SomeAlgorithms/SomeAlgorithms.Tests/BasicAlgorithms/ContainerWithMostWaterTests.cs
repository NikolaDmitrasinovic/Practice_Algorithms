using SomeAlgorithms.BasicAlgorithms;

namespace Algorithms.Tests;

public class ContainerWithMostWaterTests
{
    [Theory]
    [InlineData(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    [InlineData(new[] { 1, 1 }, 1)]
    [InlineData(new[] { 4, 3, 2, 1, 4 }, 16)]
    [InlineData(new[] { 1, 2, 1 }, 2)]
    [InlineData(new[] { 2, 3, 4, 5, 18, 17, 6 }, 17)]
    public void MaxArea_Returns_Expected_Result(int[] height, int expected)
    {
        // Act
        var result = ContainerWithMostWater.MaxArea(height);

        // Assert
        Assert.Equal(expected, result);
    }
}