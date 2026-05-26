namespace BasicAlgorithms.Tests;

public class PalindromeTests
{
    public class ValidPalindromeTests
    {
        [Theory]
        [InlineData("A man, a plan, a canal: Panama", true)]
        [InlineData("race a car", false)]
        [InlineData(" ", true)]
        [InlineData("Aa", true)]
        [InlineData("Aba", true)]
        [InlineData("0P", false)]
        public void IsPalindrome_Returns_Expected_Result(string input, bool expected)
        {
            // Act
            var result = Palindrome.IsPalindrome(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}