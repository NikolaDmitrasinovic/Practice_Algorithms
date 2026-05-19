namespace BasicAlgorithms;

public static class TwoSum
{
    /*
     * Given an array of integers nums and an integer target, return the indices of the two numbers such that they add up to target.
     * Constraints:
     *  - Exactly one solution exists
     *  - You cannot use the same element twice
     *  - Return the indices, not the values
     *
     * Example:
     *  Input:
     *   nums = [2, 7, 11, 15]
     *  target = 9
     *  Output:
     *   [0, 1]
     * Explanation:
     *  nums[0] + nums[1] = 2 + 7 = 9
     */
    
    public static int[] FindBruteForce(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return [i, j];
                }
            }
        }
        
        throw new Exception("Not found");
    }

    public static int[] Find(int[] nums, int target)
    {
        if (nums.Length < 2)
            throw new Exception("No solution found");
        
        var map =  new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var needed = target - nums[i];
            
            if (map.TryGetValue(needed, out var value)) // map.ContainsKey(needed) -> [map[needed], i]
                return [value, i]; // new[] { value, i }
            
            map[nums[i]] = i;
        }
        
        throw new Exception("No solution found");
    }
}