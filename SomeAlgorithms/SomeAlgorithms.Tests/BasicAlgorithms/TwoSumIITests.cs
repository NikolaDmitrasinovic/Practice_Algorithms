using SomeAlgorithms.BasicAlgorithms;

namespace SomeAlgorithms.Tests.BasicAlgorithms;

public class TwoSumIITests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4 }, 6, new int[] { 0, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { -5, -4, -3, -2, -1 }, -8, new int[] { 0, 2 })]
    public void TwoSum_MultipleScenarios_ReturnsExpectedIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var result = TwoSumII.Find(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}