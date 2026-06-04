namespace PracticeLibrary;

public class Bridge4DayRecap
{
    public static int BestTimeToBuyAndSellStock(int[] prices)
    {
        var minValue = int.MaxValue;
        var maxProfit = 0;

        foreach (var price in prices)
        {
            if (minValue > price)
                minValue = price;
            
            maxProfit = Math.Max(maxProfit, price - minValue);
        }
        
        return maxProfit;
    }

    public static List<List<int>> Solve3Sum(int[] numbers)
    {
        var solutions = new List<List<int>>();
        Array.Sort(numbers);

        for (var i = 0; i < numbers.Length - 2; i++)
        {
            if (i > 0 && numbers[i] == numbers[i-1])
                continue;
            
            var left = i + 1;
            var right = numbers.Length - 1;

            while (left < right)
            {
                var result = numbers[i] + numbers[left] + numbers[right];

                if (result == 0)
                {
                    solutions.Add([numbers[i], numbers[left], numbers[right]]);
                    left++;
                    right--;
                    
                    while (left < right && numbers[left] == numbers[left - 1])
                        left++;
                    while (left < right && numbers[right] == numbers[right - 1])
                        right--;
                }
                else if (result < 0)
                    left++;
                else
                    right--;
            }
        }
        
        return solutions;
    }

    public static int LongestSubstring(string s)
    {
        return 0;
    }
}