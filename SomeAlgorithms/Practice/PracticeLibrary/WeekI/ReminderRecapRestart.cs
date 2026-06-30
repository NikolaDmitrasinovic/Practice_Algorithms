namespace PracticeLibrary.WeekI;

public static class ReminderRecapRestart
{
    public static int[] SolveTwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var need = target - nums[i];
            if (map.TryGetValue(need, out var value))
                return [value, i];
            
            map[nums[i]] = i;
        }
        
        throw new Exception("No solution found");
    }

    public static int[] SolveTwoSumIi(int[] nums, int target)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var currentSum = nums[left] + nums[right];
            if (currentSum == target)
                return [left, right];
            
            if (currentSum < target)
                left++;
            else
                right--;
        }
        
        throw new Exception("No solution found");
    }

    public static bool SolveIsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            
            if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                return false;
            
            left++;
            right--;
        }
        
        return true;
    }

    public static int SolveWaterContainer(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;
        var mostWater = 0;

        while (left < right)
        {
            var width = right - left;
            var height = Math.Min(heights[left], heights[right]);
            var waterAmount = width * height;

            if (waterAmount > mostWater)
                mostWater = waterAmount;
            
            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }
        
        return mostWater;
    }
}