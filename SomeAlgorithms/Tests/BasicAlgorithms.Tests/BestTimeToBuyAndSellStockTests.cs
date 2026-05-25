namespace BasicAlgorithms.Tests;

public class BestTimeToBuyAndSellStockTests
{
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
    [InlineData(new[] { 2, 4, 1 }, 2)]
    [InlineData(new[] { 3, 3, 3 }, 0)]
    [InlineData(new[] { 5 }, 0)]
    public void MaxProfit_Returns_Expected_Result(int[] prices, int expected)
    {
        // Act
        var result = BestTimeToBuyAndSellStock.MaxProfit(prices);

        // Assert
        Assert.Equal(expected, result);
    }
}
