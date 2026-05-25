namespace PracticeLibrary;

internal class Class2
{
    public static bool IsPalindrome(string str)
    {
        if (str.Length <= 1)
            return true;

        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(str[left]))
            {
                left++;
                continue;
            }
            if (!char.IsLetterOrDigit(str[right]))
            {
                right--;
                continue;
            }                

            if (char.ToLower(str[left]) != char.ToLower(str[right]))
                return false;

            left++;
            right--;
        }
        return true;
    }

    public static int MaxArea(int[] heights)
    {
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            var height = Math.Min(heights[left], heights[right]);
            var width = right - left;
            var area = height * width;

            if (area > maxArea)
                maxArea = area;

            if (heights[left] > heights[right])
                right--;
            else
                left++;
        }
        return maxArea;
    }

    public static int BestTimeToBuyAndSellStock(int[] prices)
    {
        // [7,1,5,3,6,4]
        var buyPrice = int.MaxValue;
        var maxProfit = 0;

        foreach (var price in prices)
        {
            if (price < buyPrice)
                buyPrice = price;

            maxProfit = Math.Max(maxProfit, price - buyPrice);
        }

        return maxProfit;
    }
}
