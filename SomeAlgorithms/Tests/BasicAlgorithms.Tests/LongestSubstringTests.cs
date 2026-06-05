namespace BasicAlgorithms.Tests;

public class LongestSubstringTests
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("a", 1)]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    [InlineData("dvdf", 3)]
    [InlineData("abba", 2)]
    [InlineData("abcdef", 6)]
    [InlineData("tmmzuxt", 5)]
    public void LengthOfLongestSubstring_Returns_Correct_Length(
        string input,
        int expected)
    {
        // Act
        var result = LongestSubstring
            .LengthOfLongestSubstring(input);

        // Assert
        Assert.Equal(expected, result);
    }
}