namespace PracticeLibrary.WeekI;

public static class Recap
{
    public static int[] SolveTwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var needed = target - nums[i];
            if (map.TryGetValue(needed, out var value))
                return [value, i];
            else
                map[nums[i]] = i;
        }
        
        throw new Exception("No Solution Found");
    }

    public static int[] SolveTwoSumIi(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var sum = nums[left] + nums[right];
            
            if (sum == target)
                return [left, right];
            else if (sum < target)
                left++;
            else
                right--;
        }
        
        throw new Exception("No solution found");
    }

    public static bool IsValidPalindrome(string input)
    {
        var left = 0;
        var right = input.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(input[left]))
                left++;
            
            while (left < right && !char.IsLetterOrDigit(input[right]))
                right--;
            
            if (char.ToLowerInvariant(input[left]) != char.ToLowerInvariant(input[right]))
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }

    public static int HoldsMostWater(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        var area = 0;

        while (left < right)
        {
            var width = right - left;
            var height = Math.Min(heights[left], heights[right]);
            area = Math.Max(area, width * height);
            
            if (heights[left] >  heights[right])
                right--;
            else
                left++;
        }
        
        return area;
    }

    public static int BestTimeForStock(int[] prices)
    {
        var lowestPrice = int.MaxValue;
        var maxProfit = 0;

        for (var i = 0; i < prices.Length; i++)
        {
            lowestPrice = Math.Min(prices[i], lowestPrice);
            maxProfit = Math.Max(maxProfit, prices[i] - lowestPrice);
        }
        
        return maxProfit;
    }

    public static List<List<int>> ThreeSumSolutions(int[] nums)
    {
        var solutions = new List<List<int>>();
        
        Array.Sort(nums);

        

        for (var i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            
            var left = i + 1;
            var right = nums.Length - 1;
            
            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    solutions.Add([nums[i], nums[left], nums[right]]);
                    left++;
                    right--;
                    
                    while (left < right && nums[left] == nums[ - 1])
                        left++;
                    
                    while (left < right && nums[right] == nums[right + 1])
                        right--;
                }
                else if (sum < 0)
                    left++;
                else
                    right--;
            }
        }
        
        return solutions;
    }

    public static int LongestSubstring(string input)
    {
        var maxLength = 0;
        var substring = new HashSet<char>();

        var left = 0;

        for (var right = 0; right < input.Length; right++)
        {
            while (substring.Contains(input[right]))
            {
                substring.Remove(input[left]);
                left++;
            }
            
            substring.Add(input[right]);

            var currentLength = right - left + 1;
            maxLength = Math.Max(maxLength, currentLength);
        }
        
        return maxLength;
    }
}