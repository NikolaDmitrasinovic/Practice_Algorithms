namespace BasicAlgorithms;

public static class ThreeSum
{
    /*
     * Given an integer array nums,
     * return all unique triplets:
     *  [nums[i], nums[j], nums[k]]
     * such that:
     *  nums[i] + nums[j] + nums[k] == 0
     *
     * Example
     * Input:
     *  [-1,0,1,2,-1,-4]
     * Valid triplets:
     *  [-1,-1,2]
     *  [-1,0,1]
     * because:
     *  -1 + -1 + 2 = 0
     *  -1 + 0 + 1 = 0
     *
     * Only unique combinations allowed.
     */
    
    /*
     * brute force approach:
     * for i
     *  for j
     *   for k
     * complexity gets too expensive: O(n^3)
     */

    public static IList<IList<int>> Find(int[] nums)
    {
        Array.Sort(nums);
        var results = new List<IList<int>>();

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
                    results.Add([nums[i], nums[left],  nums[right]]);
                    left++;
                    right--;

                    while (left < right && nums[left] == nums[left - 1])
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
        
        return results;
    }
    
    // Time complexity: O(n^2) while inside a while is still linear growth in this case
    // Space complexity: in general O(1), but output still can grow 
}