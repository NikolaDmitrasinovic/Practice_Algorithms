namespace PracticeLibrary;

public class Class1
{
    public static int MaxArea(int[] heights)
    {
        var left = 0;
        var right = heights.Length - 1;

        var maxArea = 0;

        while(left < right)
        {
            var width = right - left;
            var containerHeight = Math.Min(heights[left], heights[right]);

            var area = containerHeight * width;

            if (area > maxArea)
                maxArea = area;

            if (heights[left] < heights[right])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}
