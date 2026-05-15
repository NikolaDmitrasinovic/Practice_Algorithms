using SomeAlgorithms.BasicAlgorithms;

namespace SomeAlgorithms.Tests.BasicAlgorithms;

public class TwoSumTests
{
    [Fact]
    public void TwoSum_ValidInput_ReturnsCorrectIndices()
    {
        // Arrange
        int[] nums = [2, 7, 11, 15];
        const int target = 9;
        int[] expected = [0, 1];

        // Act
        var result = TwoSum.FindBruteForce(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void TwoSum_NoSolutionExists_ThrowsInvalidOperationException()
    {
        // Arrange
        int[] nums = [1, 2, 3];
        const int target = 10;

        // Act & Assert
        Assert.Throws<Exception>(() => TwoSum.Find(nums, target));
    }
    
    [Fact]
    public void TwoSum_ArrayTooShort_ThrowsArgumentException()
    {
        // Arrange
        int[] nums = [5];
        const int target = 5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => TwoSum.Find(nums, target));
    }
    
    [Theory]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { -3, -2, -1, -4, -5 }, -8, new int[] { 2, 4 })]
    public void TwoSum_MultipleScenarios_ReturnsExpectedIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var result = TwoSum.Find(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }
}