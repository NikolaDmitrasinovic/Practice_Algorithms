namespace BasicAlgorithms;

public static class BestTimeToBuyAndSellStock
{
    /*
     * You are given an array where each number represents the stock price on a given day.
     * You may:
     *  buy once
     *  sell once later
     * Return the maximum profit possible.
    */

    public static int MaxProfit(int[] prices)
    {
        var minPrice = int.MaxValue;
        var maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < minPrice)
                minPrice = price;
            
            var profit = price - minPrice;

            maxProfit = Math.Max(maxProfit, profit);
        }

        return maxProfit;
    }

    // Time complexity: O(n) - we traverse the array once
    // Space complexity: O(1) - we use a constant amount of space
}
