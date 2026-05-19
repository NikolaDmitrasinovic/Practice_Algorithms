namespace BasicAlgorithms;

public static class TwoSumII
{
    /*
     * Same as Two Sum, BUT!!!
     * The array is now:
     *  ✅ already sorted
     * Example:
     *  [2,7,11,15]
     * Target:
     *  9
     */

    public static int[] Find(int[] nums, int target)
    {
        if (nums.Length < 2)
            throw new Exception("No solution found");
        
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            var sum = nums[left] + nums[right];

            if (sum == target)
                return [left, right];
            
            if (sum < target)
                left++;
            else
                right--;
        }
        
        throw new Exception("No solution found");
    }
}