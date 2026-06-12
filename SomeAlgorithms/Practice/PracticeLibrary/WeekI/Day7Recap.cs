namespace PracticeLibrary.WeekI;

public class Day7Recap
{
    public static int[] FindTarget(int[] arr, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < arr.Length - 1; i++)
        {
            var needed = target - arr[i];
            
            if (map.TryGetValue(needed, out var value))
                return [value, i];
            else
                map[arr[i]] = i;
        }
        
        throw new Exception("No solution found");
    }

    public static List<List<int>> FindThree(int[] arr)
    {
        var results = new List<List<int>>();
        Array.Sort(arr);

        for (var i = 0; i < arr.Length - 2; i++)
        {
            var left = i + 1;
            var right = arr.Length - 1;

            while (left < right)
            {
                var sum = arr[i] +  arr[left] + arr[right];

                if (sum == 0)
                {
                    results.Add([arr[i], arr[left], arr[right]]);
                    left++;
                    right--;
                    
                    while (left < right && arr[left] == arr[left - 1])
                        left++;
                    while (left < right && arr[right] == arr[right + 1])
                        right--;
                }
                else if (sum > 0)
                    right--;
                else
                    left++;
            }
        }
        
        return results;
    }
}